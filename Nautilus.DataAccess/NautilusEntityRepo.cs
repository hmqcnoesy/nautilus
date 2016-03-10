using Nautilus.Data;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;

namespace Nautilus.DataAccess
{
    public class NautilusEntityRepo
    {
        protected IDbConnectionFactory _dbConnectionFactory;


        public NautilusEntityRepo(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }


        public NautilusEntityRepo(string connectionString)
        {
            _dbConnectionFactory = new OracleConnectionFactory(connectionString);
        }


        public NautilusEntityRepo(string dataSource, string userId, string password)
        {
            _dbConnectionFactory = new OracleConnectionFactory(dataSource, userId, password);
        }


        public T Get<T>(decimal id) where T : NautilusEntity
        {
            var type = typeof(T);
            var tableName = GetTableName(type);
            var primaryKey = GetPrimaryKeyName(type);
            var sql = $"select * from lims_sys.{tableName} where {primaryKey} = :id";

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                return connection.Query<T>(sql, new { id = id }).Single();
            }
        }


        public IEnumerable<T> Get<T>(IEnumerable<decimal> ids) where T : NautilusEntity
        {
            var type = typeof(T);
            var tableName = GetTableName(type);
            var primaryKey = GetPrimaryKeyName(type);
            var sqlParams = string.Empty;
            var sqlParamObjs = GetParameterDictionary(ids, out sqlParams);
            var sql = $"select * from lims_sys.{tableName} where {primaryKey} in ({sqlParams})";

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                return connection.Query<T>(sql, new DynamicParameters(sqlParamObjs));
            }
        }


        public IEnumerable<T> Get<T>(string criterion, object value) where T : NautilusEntity
        {
            var type = typeof(T);
            var tableName = GetTableName(type);

            if (!DoesTypeHaveProperty(type, criterion)) throw new ArgumentException("Illegal criterion supplied");

            var sqlParams = string.Empty;
            var sqlParamObjs = GetParameterDictionary(value, out sqlParams);

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                var sql = string.Format("select * from lims_sys.{0} where {1} in ({2})", tableName, criterion, sqlParams);
                return connection.Query<T>(sql, new DynamicParameters(sqlParamObjs));
            }
        }


        public decimal GetSequenceNextVal<T>()
        {
            var sequenceName = typeof(T).GetField("SequenceName").GetValue(null) as string;
            return GetSequenceNextVal(sequenceName);
        }


        protected decimal GetSequenceNextVal(string sequenceName)
        {
            var sql = string.Format("select LIMS.{0}.NEXTVAL FROM DUAL", sequenceName);
            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                return (decimal)connection.ExecuteScalar(sql);
            }
        }


        /// <summary>
        /// Updates database with ALL property values for the "entity" object.  Update is based on the PrimaryKey value for the type.
        /// </summary>
        /// <param name="entity">The object to be updated in the database.</param>
        /// <returns>Integer indicating number of database records updated.</returns>
        public int Update(NautilusEntity entity)
        {
            var type = entity.GetType();
            var primaryKey = GetPrimaryKeyName(type);
            var propsToUpdate = type.GetProperties().Where(p => p.Name != primaryKey).Select(p => p.Name);
            return Update(entity, propsToUpdate);
        }


        /// <summary>
        /// Updates database with value specified for the "entity" object's "propertyToUpdate". Update is based on the PrimaryKey value for the type.
        /// </summary>
        /// <param name="entity">The object to be updated in the database.</param>
        /// <param name="propertyToUpdate">A single property name on the entity object to be saved in the database.</param>
        /// <returns>Integer indicating number of database records updated.</returns>
        public int Update(NautilusEntity entity, string propertyToUpdate)
        {
            return Update(entity, new List<string> { propertyToUpdate });
        }


        /// <summary>
        /// Updates database with values specified for the "entity" object. Update is based on the PrimaryKey value for the type.
        /// </summary>
        /// <param name="entity">The object to be updated in the database.</param>
        /// <param name="propertiesToUpdate">A list of property names on the entity object to be saved in the database.</param>
        /// <returns>Integer indicating number of database records updated.</returns>
        public int Update(NautilusEntity entity, IEnumerable<string> propertiesToUpdate)
        {
            var type = entity.GetType();
            var tableName = GetTableName(type);
            var primaryKey = GetPrimaryKeyName(type);
            var primaryKeyValue = type.GetProperty(primaryKey).GetValue(entity, null);
            var parameterValues = new Dictionary<string, object>();

            foreach (var prop in propertiesToUpdate)
            {
                parameterValues.Add(prop, type.GetProperty(prop).GetValue(entity, null));
            }

            var sql = $"update lims_sys.{tableName} set ";
            sql += string.Join(", ", parameterValues.Select(kvp => kvp.Key + " = :" + kvp.Key));
            sql += $" where {primaryKey} = :{primaryKey}";

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                SetLimsUserRole(connection);
                parameterValues.Add(primaryKey, primaryKeyValue);
                return connection.Execute(sql, new DynamicParameters(parameterValues));
            }
        }


        /// <summary>
        /// Creates a new record in the database for the passed-in object. Assign a primary key value first.
        /// </summary>
        /// <param name="entity">The object to be inserted in the database.</param>
        /// <returns>Integer indicating number of database records updated.</returns>
        public int Insert(NautilusEntity entity)
        {
            var type = entity.GetType();
            var tableName = GetTableName(type);
            var propsToUpdate = type.GetProperties();
            var parameterValues = new Dictionary<string, object>();

            foreach (var prop in propsToUpdate)
            {
                parameterValues.Add(prop.Name, prop.GetValue(entity, null));
            }

            var sql = $"insert into lims_sys.{tableName} (";
            sql += string.Join(", ", parameterValues.Select(kvp => kvp.Key));
            sql += ") values (";
            sql += string.Join(", ", parameterValues.Select(kvp => ":" + kvp.Key));
            sql += ")";

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                SetLimsUserRole(connection);
                return connection.Execute(sql, new DynamicParameters(parameterValues));
            }
        }


        /// <summary>
        /// Irreversably deletes a record in the database for the passed-in object based on primary key value.
        /// </summary>
        /// <param name="entity">The object to be deleted in the database.</param>
        /// <returns>Integer indicating number of database records affected.</returns>
        public int Delete(NautilusEntity entity)
        {
            var type = entity.GetType();
            var tableName = GetTableName(type);
            var primaryKey = GetPrimaryKeyName(type);
            var primaryKeyValue = type.GetProperty(primaryKey).GetValue(entity, null);

            var sql = $"delete from lims_sys.{tableName} where {primaryKey} = :id";

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                SetLimsUserRole(connection);
                return connection.Execute(sql, new { id = primaryKeyValue });
            }
        }


        /// <summary>
        /// Applies LIMS_USER role for current session, using passed in connection.  Required for data changes.
        /// </summary>
        /// <param name="openConnection">Previously opened db connection</param>
        protected void SetLimsUserRole(IDbConnection openConnection)
        {
            var sql = "set role lims_user";
            openConnection.Execute(sql);
        }


        /// <summary>
        /// Creates a dictionary of parameter names and values suitable for inclusion in a SQL WHERE IN clause.
        /// </summary>
        /// <param name="value">A single object or enumerable collection</param>
        /// <param name="sqlParams">String output suitable for IN clause e.g. ":p000,:p001,:p002"</param>
        /// <returns>Dictionary of parameter names (e.g. :p000, :p001) and corresponding values (e.g. 'A', 'N')</returns>
        protected Dictionary<string, object> GetParameterDictionary(object value, out string sqlParams)
        {
            var pNames = new List<string>();
            var dict = new Dictionary<string, object>();
            var enumerableValue = value as System.Collections.IEnumerable;
            var isString = value is string;
            
            if (!isString && enumerableValue != null)
            {
                var values = (value as System.Collections.IEnumerable);
                var counter = 0;
                foreach (var v in values)
                {
                    pNames.Add(":p" + counter);
                    dict.Add(":p" + counter, v);
                    counter++;
                }
            }
            else
            {
                pNames.Add(":p0");
                dict.Add(":p0", value);
            }

            sqlParams = string.Join(",", pNames);
            return dict;
        }


        private string GetTableName(Type type)
        {
            return type.GetField("TableName").GetValue(null) as string;
        }


        private string GetPrimaryKeyName(Type type)
        {
            return type.GetField("PrimaryKey").GetValue(null) as string;
        }


        private bool DoesTypeHaveProperty(Type type, string propertyName)
        {
            var matchingProp = type.GetProperties()
                .FirstOrDefault(p => string.Equals(p.Name, propertyName, StringComparison.OrdinalIgnoreCase));

            return matchingProp != null;
        }
    }
}