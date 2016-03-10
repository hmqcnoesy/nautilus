using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using Nautilus.Data;
using System.Data.OracleClient;

namespace Nautilus.DataAccess
{
    public class AliquotRepo : NautilusEntityRepo
    {
        public AliquotRepo(string connectionString) : base(connectionString)
        {
        }


        public AliquotRepo(string dataSource, string userId, string password) : base(dataSource, userId, password)
        {
        }


        public Aliquot Get(decimal id)
        {
            return base.Get<Aliquot>(id);
        }


        public IEnumerable<Aliquot> Get(IEnumerable<decimal> ids)
        {
            return base.Get<Aliquot>(ids);
        }


        public IEnumerable<Aliquot> Get(string criterion, object value)
        {
            return base.Get<Aliquot>(criterion, value);
        }


        public Aliquot GetHierarchy(decimal id)
        {
            return GetHierarchies(new List<decimal> { id }).Single();
        }


        public IEnumerable<Aliquot> GetHierarchies(IEnumerable<decimal> ids)
        {
            var aliquots = Get(ids);
            PopulateHierarchies(aliquots);
            return aliquots;
        }


        public void PopulateHierarchy(Aliquot aliquot)
        {
            PopulateHierarchies(new List<Aliquot> { aliquot });
        }


        public void PopulateHierarchies(IEnumerable<Aliquot> aliquots)
        {
            var sqlParams = string.Join(",", aliquots.Select(a => a.Aliquot_Id));
            IEnumerable<Test> tests;
            IEnumerable<Result> results;

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                var sql = $"select * from lims_sys.test where aliquot_id in ({sqlParams})";
                tests = connection.Query<Test>(sql);
                sql = $"select r.* from lims_sys.result r, lims_sys.test t where t.test_id = r.test_id and t.aliquot_id in ({sqlParams})";
                results = connection.Query<Result>(sql);
            }

            foreach (var aliquot in aliquots)
                aliquot.Tests = tests.Where(t => t.Aliquot_Id == aliquot.Aliquot_Id);

            foreach (var test in tests)
                test.Results = results.Where(r => r.Test_Id == test.Test_Id);
        }


        public void PopulateTests(Aliquot aliquot)
        {
            PopulateTests(new List<Aliquot> { aliquot });
        }


        public void PopulateTests(IEnumerable<Aliquot> aliquots)
        {
            var tests = Get<Test>("aliquot_id", aliquots.Select(a => a.Aliquot_Id));

            foreach (var aliquot in aliquots)
            {
                aliquot.Tests = tests.Where(t => t.Aliquot_Id == aliquot.Aliquot_Id);
            }
        }


        public IEnumerable<Aliquot> GetParticleSizeAliquotsHavingAvailableTests()
        {
            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                var sql = @"select distinct a.aliquot_id, a.name, a.status, a.description, au.u_mix_grind_lwr storage
                    from lims_sys.aliquot a, lims_sys.aliquot_user au, lims_sys.test t 
                    where a.aliquot_id = au.aliquot_id 
                    and a.aliquot_id = t.aliquot_id 
                    and a.name like '%-PS-%' 
                    and t.status in ('V','P') 
                    order by aliquot_id ";
                return connection.Query<Aliquot>(sql);
            }
        }
    }
}
