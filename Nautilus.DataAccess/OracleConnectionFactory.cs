using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.DataAccess
{
    public class OracleConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;


        public OracleConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }


        public OracleConnectionFactory(string dataSource, string userId, string password)
        {
            var ocsb = new OracleConnectionStringBuilder();
            ocsb.DataSource = dataSource;
            ocsb.UserID = userId;
            ocsb.Password = password;
            ocsb.Unicode = true;
            _connectionString = ocsb.ConnectionString;
        }


        public IDbConnection CreateConnection()
        {
            var connection = new OracleConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}
