using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;

namespace Nautilus.DataGenerator
{
    class Program
    {
        private static string _outputDir = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "..\\..\\..\\..", "Nautilus.Data\\Nautilus.Data\\generated");
        private static string _connectionString = "Data Source=;User Id=;Password=;Unicode=True;";
        

        static void Main(string[] args)
        {
            if (!Directory.Exists(_outputDir)) Directory.CreateDirectory(_outputDir);

            var tables = GetAllNonUserTables();
            tables.AddRange(GetAllUserTables());

            foreach(var table in tables)
            {
                CreatePocoFileForTable(table);
                Console.WriteLine("Wrote POCO file for " + table.TypeName);
            }

            Console.WriteLine("Get output POCO files here:");
            Console.WriteLine(_outputDir);
        }


        private static List<Table> GetAllNonUserTables()
        {
            var tables = new List<Table>();

            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                var sql = @"select initcap(table_name) 
                            from all_tables 
                            where owner = 'LIMS' 
                            and table_name not like 'U\_%' escape '\' 
                            and table_name not like '%\_USER' escape '\' 
                            order by 1";
                var cmd = new OracleCommand(sql, connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var tableName = reader[0].ToString();
                    var table = new Table(tableName);
                    table.Columns = GetTableColumns(connection, tableName);
                    table.PrimaryKeyColumnName = GetPrimaryKeyColumnName(connection, tableName);
                    if (!string.IsNullOrEmpty(table.PrimaryKeyColumnName)) table.SequenceName = GetSequenceName(connection, tableName); 
                    tables.Add(table);
                    Console.WriteLine("Got non-user table {0} with {1} columns.", table.TypeName, table.Columns.Count);
                }

                reader.Close();
            }

            return tables;
        }

        private static List<Table> GetAllUserTables()
        {
            var tables = new List<Table>();

            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                var sql = @"select initcap(table_name) from all_tables 
                            where owner = 'LIMS' and (table_name like '%USER' or table_name like 'U\_%' escape '\') 
                            order by 1";
                var cmd = new OracleCommand(sql, connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var table = new Table(reader[0].ToString(), reader[0].ToString() + "_" + reader[1].ToString());
                    table.Columns = GetTableColumns(connection, reader[0].ToString());
                    tables.Add(table);
                    Console.WriteLine("Got user table {0} with {1} columns.", table.TypeName, table.Columns.Count);
                }

                reader.Close();
            }

            return tables;
        }


        private static List<Column> GetTableColumns(OracleConnection openConnection, string tableName)
        {
            var columns = new List<Column>();
            
            var sql = @"select initcap(column_name), column_id, data_type, nvl(data_precision, data_length), nullable
                        from all_tab_cols
                        where owner = 'LIMS' and hidden_column = 'NO' and table_name = upper(:in_table_name)
                        order by column_id";
            var cmd = new OracleCommand(sql, openConnection);
            cmd.Parameters.AddWithValue(":in_table_name", tableName);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                columns.Add(new Column
                {
                    Name = reader[0].ToString(),
                    ColumnId = reader.GetInt32(1),
                    OracleDataType = reader[2].ToString(),
                    Length = reader.GetInt32(3),
                    IsNullable = reader[4].ToString() == "Y"
                });
            }

            reader.Close();

            return columns;
        }

        private static void CreatePocoFileForTable(Table table)
        {
            CorrectEnclosingTypeNamesIfConflictingMemberName(table);

            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine();
            sb.AppendLine("namespace Nautilus.Data");
            sb.AppendLine("{");
            sb.AppendLine($"    public partial class {table.TypeName} : NautilusEntity");
            sb.AppendLine("    {");
            sb.AppendLine($"        public const string TableName = \"{table.TableName}\";");

            if (!string.IsNullOrEmpty(table.PrimaryKeyColumnName))
            {
                sb.AppendLine($"        public const string PrimaryKey = \"{table.PrimaryKeyColumnName}\";");
            }

            if (!string.IsNullOrEmpty(table.SequenceName))
            {
                sb.AppendLine($"        public const string SequenceName = \"{table.SequenceName}\";");
            }

            sb.AppendLine();

            foreach(var col in table.Columns)
            {
                sb.AppendLine("        /// <summary>");
                sb.AppendLine($"        /// Gets or sets {col.Name}, {col.OracleDataTypeLength}");
                sb.AppendLine("        /// </summary>");
                sb.AppendLine($"        public {col.CSharpDataType} {col.Name} {{ get; set; }}");
                sb.AppendLine();
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");

            File.WriteAllText(Path.Combine(_outputDir, table.TypeName + ".cs"), sb.ToString());
        }


        private static string GetPrimaryKeyColumnName(OracleConnection connection, string tableName)
        {
            var constraintColumnName = string.Empty;
            var sql = @"SELECT initcap(cols.column_name)
                FROM all_constraints cons, all_cons_columns cols
                WHERE cons.table_name = upper(:in_table_name) 
                AND cols.owner = 'LIMS'
                and cons.constraint_type = 'P'
                AND cons.constraint_name = cols.constraint_name
                AND cons.owner = cols.owner
                ORDER BY cols.table_name, cols.position";
            var cmd = new OracleCommand(sql, connection);
            cmd.Parameters.AddWithValue(":in_table_name", tableName);
            var reader = cmd.ExecuteReader();
            var count = 0;

            while (reader.Read())
            {
                constraintColumnName = reader[0].ToString();
                count++;
            }

            reader.Close();

            if (count == 1) return constraintColumnName;
            else return string.Empty;
        }


        private static string GetSequenceName(OracleConnection connection, string tableName)
        {
            var sequenceName = string.Empty;
            var sql = @"select initcap(sequence_name) 
                        from all_sequences 
                        where sequence_owner = 'LIMS' 
                        and sequence_name = upper('sq_' || :in_table_name)";
            var cmd = new OracleCommand(sql, connection);
            cmd.Parameters.AddWithValue(":in_table_name", tableName);
            var reader = cmd.ExecuteReader();
            var count = 0;

            while (reader.Read())
            {
                sequenceName = reader[0].ToString();
                count++;
            }

            reader.Close();

            if (count == 1) return sequenceName;
            else return string.Empty;
        }


        private static void CorrectEnclosingTypeNamesIfConflictingMemberName(Table table)
        {
            if (table.Columns.Count(c => c.Name == table.TypeName) > 0) table.TypeName += "_";
        }
    }
}
