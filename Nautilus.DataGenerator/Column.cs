using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.DataGenerator
{
    public class Column
    {
        public string Name { get; set;  }
        public int ColumnId { get; set; }
        public string OracleDataType { get; set; }
        public bool IsNullable { get; set; }
        public int Length { get; set; }
        public string OracleDataTypeLength
        {
            get
            {
                var n = IsNullable ? "(null)" : "(not null)";
                if (this.OracleDataType == "DATE") return "DATE " + n;
                return $"{this.OracleDataType}({this.Length}) {n}";
            }
        }
        public string CSharpDataType {
            get
            {
                switch (this.OracleDataType)
                {
                    case "VARCHAR2":
                    case "CHAR":
                    case "CLOB":
                        return "string";
                    case "NUMBER":
                        return "decimal" + (this.IsNullable ? "?" : string.Empty);
                    case "LONG RAW":
                    case "BLOB":
                        return "byte[]";
                    case "FLOAT":
                        return "double" + (this.IsNullable ? "?" : string.Empty);
                    case "DATE":
                        return "DateTime" + (this.IsNullable ? "?" : string.Empty);
                    default:
                        throw new ApplicationException("Encountered unknown Oracle type: " + this.OracleDataType);
                }
            }
        }
    }
}
