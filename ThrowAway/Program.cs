using Nautilus.Data;
using Nautilus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowAway
{
    class Program
    {
        static void Main(string[] args)
        {
            var srepo = new SampleRepo("qa", "lims_read", "lims_read_prod7");
            var samps = srepo.Get<Sample>("name", new List<string> { "P1001-001", "P1210-003" });
            Console.Write("two: ");
            Console.WriteLine(samps.Count());
            var samp = srepo.Get<Sample>(145280);
            Console.Write("P1512-181: ");
            Console.WriteLine(samp.Name);
            var samp2 = srepo.Get(145280);
            Console.Write("true: ");
            Console.WriteLine(samp.Description == samp2.Description);
            samps = srepo.Get("sample_id", new List<decimal> { 145255, 144495 });
            Console.Write("two: ");
            Console.WriteLine(samps.Count());
            samps = srepo.Get("date_results_required", new List<DateTime> { new DateTime(2016, 1, 28), new DateTime(2016, 1, 19) });
            Console.Write("eleven: ");
            Console.WriteLine(samps.Count());
            samps = srepo.Get("date_results_required", new DateTime(2016, 1, 28));
            Console.Write("nine: ");
            Console.WriteLine(samps.Count());
            samps = srepo.Get("sample_id", 145280);
            Console.Write("one: ");
            Console.WriteLine(samps.Count());
            samps = srepo.Get("name", "P1512-128");
            Console.Write("206420: ");
            Console.WriteLine(samps.ElementAt(0).Workflow_Node_Id);
            samps = srepo.Get("name", "-128");
            Console.Write("zero: ");
            Console.WriteLine(samps.Count());
            samps = srepo.Get("description", "BORON POTASSIUM NITRATE (BKNO3), PELLETS");
            Console.Write("seventeen: ");
            Console.WriteLine(samps.Count());
            srepo.PopulateHierarchy(samps.ElementAt(2));
            Console.Write("aliquots: ");
            Console.WriteLine(string.Join(", ", samps.ElementAt(2).Aliquots.Select(q => q.Name)));
            samps = srepo.Get("old_status", null);
            Console.Write("true, but Dapper bug: ");
            Console.WriteLine(samps.Count() == 0);

            var arepo = new AliquotRepo("qa", "lims_read", "lims_read_prod7");
            var a = arepo.Get(274238);
            Console.Write("P1512-198-SI-1: ");
            Console.WriteLine(a.Name);
            var als = srepo.Get<Aliquot>(new List<decimal> { 274238, 274237, 274236, 274235 });
            Console.Write("four: ");
            Console.WriteLine(als.Count());
            var als2 = arepo.Get(new List<decimal> { 274238, 274237, 274236, 274235 });
            Console.Write("four: ");
            Console.WriteLine(als2.Count());


            var genericRepo = new NautilusEntityRepo("qa", "lims_app_is", "mdm3_rj");
            var calc = genericRepo.Get<Calculation>(75);
            calc.Description = DateTime.Now.ToString("HH mm ss");
            genericRepo.Update(calc, "Description");
            Console.Write("timestamp: ");
            Console.WriteLine(genericRepo.Get<Calculation>(75).Description);

            calc = new Calculation();
            calc.Calculation_Id = genericRepo.GetSequenceNextVal<Calculation>();
            calc.Name = "testing inserts";
            calc.Version = "1";
            calc.Version_Status = "A";
            calc.Calculation_Value_Type = "N";
            genericRepo.Insert(calc);
            Console.Write("testing inserts: ");
            Console.WriteLine(genericRepo.Get<Calculation>(calc.Calculation_Id).Name);

            calc.Name = "XXXXXXX";
            genericRepo.Update(calc, "Name");
            Console.Write("XXXXXXX: ");
            Console.WriteLine(genericRepo.Get<Calculation>(calc.Calculation_Id).Name);

            genericRepo.Delete(calc);
            Console.Write("zero: ");
            Console.WriteLine(genericRepo.Get<Calculation>(new List<decimal> { calc.Calculation_Id }).Count());

            Console.WriteLine("any key to continue");
            Console.ReadKey();
        }
    }
}
