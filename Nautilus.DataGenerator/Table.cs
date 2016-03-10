using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.DataGenerator
{
    public class Table
    {
        public Table(string tableName, string typeName = "")
        {
            this.TableName = tableName;
            if (string.IsNullOrEmpty(typeName))
            {
                this.TypeName = tableName;
            }
            else
            {
                this.TypeName = typeName;
            }
        }


        public string TableName { get; set; }
        public string TypeName { get; set; }
        public string PrimaryKeyColumnName { get; set; }
        public string SequenceName { get; set; }
        public List<Column> Columns { get; set; }
    }
}
