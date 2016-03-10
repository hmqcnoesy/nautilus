using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using Nautilus.Data;
using System.Data.OracleClient;

namespace Nautilus.DataAccess
{
    public class SampleRepo : NautilusEntityRepo
    {
        public SampleRepo(string connectionString) : base(connectionString)
        {
        }


        public SampleRepo(string dataSource, string userId, string password) : base(dataSource, userId, password)
        {
        }


        public Sample Get(decimal id)
        {
            return base.Get<Sample>(id);
        }


        public IEnumerable<Sample> Get(IEnumerable<decimal> ids)
        {
            return base.Get<Sample>(ids);
        }


        public IEnumerable<Sample> Get(string criterion, object value)
        {
            return base.Get<Sample>(criterion, value);
        }


        public Sample GetHierarchy(decimal id)
        {
            return GetHierarchies(new List<decimal> { id }).Single();
        }


        public IEnumerable<Sample> GetHierarchies(IEnumerable<decimal> ids)
        {
            var samples = Get(ids);
            PopulateHierarchies(samples);
            return samples;
        }


        public void PopulateHierarchy(Sample sample)
        {
            PopulateHierarchies(new List<Sample> { sample });
        }


        public void PopulateHierarchies(IEnumerable<Sample> samples)
        {
            var sqlParams = string.Join(",", samples.Select(s => s.Sample_Id));
            IEnumerable<Aliquot> aliquots;
            IEnumerable<Test> tests;
            IEnumerable<Result> results;

            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                var sql = $"select * from lims_sys.aliquot where sample_id in ({sqlParams})";
                aliquots = connection.Query<Aliquot>(sql);
                sql = $"select t.* from lims_sys.test t, lims_sys.aliquot a where a.aliquot_id = t.aliquot_id and a.sample_id in ({sqlParams})";
                tests = connection.Query<Test>(sql);
                sql = $"select r.* from lims_sys.result r, lims_sys.test t, lims_sys.aliquot a where a.aliquot_id = t.aliquot_id and t.test_id = r.test_id and a.sample_id in ({sqlParams})";
                results = connection.Query<Result>(sql);
            }

            foreach(var sample in samples)
                sample.Aliquots = aliquots.Where(a => a.Sample_Id == sample.Sample_Id);

            foreach (var aliquot in aliquots)
                aliquot.Tests = tests.Where(t => t.Aliquot_Id == aliquot.Aliquot_Id);

            foreach (var test in tests)
                test.Results = results.Where(r => r.Test_Id == test.Test_Id);
        }


        public void PopulateAliquots(Sample sample)
        {
            PopulateAliquots(new List<Sample> { sample });
        }


        public void PopulateAliquots(IEnumerable<Sample> samples)
        {
            var aliquots = Get<Aliquot>("sample_id", samples.Select(s => s.Sample_Id));

            foreach (var sample in samples)
            {
                sample.Aliquots = aliquots.Where(a => a.Sample_Id == sample.Sample_Id);
            }
        }
    }
}
