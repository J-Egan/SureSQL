using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureSQL.Parser
{
    class parser_MySQL
    {
        public string RAWSQL { get; set; }
        public string CleanSQL { get; set; }
        Model Model;

        public parser_MySQL(Model Model, string RAWSQL)
        {
            this.RAWSQL = RAWSQL;
            this.Model = Model;
            ParseSQL();
        }

        public void ParseSQL()
        {
            //find BEGIN and END
            //get the content of the SQL 
            int start = RAWSQL.IndexOf("BEGIN");
            int end = RAWSQL.IndexOf("END");

            //remove 'BEGIN' from the procedure
            start += 5;

            this.CleanSQL = RAWSQL.Substring(start, end - start);

            //breakdown SQL into single words
            string[] SQLWords = this.CleanSQL.Split(' ');

            parsedProcessor processor = new parsedProcessor();

            Action checkViews = () =>
            {
                List<object> views;
                Model.GetMultiProperty("views", out views);

                foreach (string SQL in SQLWords)
                {
                    foreach (var view in views)
                    {
                        if (SQL == view.ToString())
                        {
                            //Add to processing queue
                            TreeItem ti = new TreeItem(SQL, TreeItem.Type.VIEW);
                            processor.AddToQue(ti);
                        }
                    }
                }
                processor.CompletedProcesses[(int)TreeItem.Type.VIEW] = 1;
            };
            Action checkProcedures = () =>
            {
                List<object> Procedures;
                Model.GetMultiProperty("storedProcedures", out Procedures);

                foreach (string SQL in SQLWords)
                {
                    foreach (var procedure in Procedures)
                    {
                        if (SQL == procedure.ToString())
                        {
                            //Add to processing queue
                            TreeItem ti = new TreeItem(SQL, TreeItem.Type.PROCEDURE);
                            processor.AddToQue(ti);
                        }
                    }
                }
                processor.CompletedProcesses[(int)TreeItem.Type.PROCEDURE] = 1;
            };
            Action checkTables = () =>
            {
                List<object> Tables;
                Model.GetMultiProperty("tables", out Tables);

                foreach (string SQL in SQLWords)
                {
                    foreach (var table in Tables)
                    {
                        if (SQL == table.ToString())
                        {
                            //Add to processing queue
                            TreeItem ti = new TreeItem(SQL, TreeItem.Type.TABLE);
                            processor.AddToQue(ti);
                        }
                    }
                }
                processor.CompletedProcesses[(int)TreeItem.Type.TABLE] = 1;
            };
            Action checkFunctions = () =>
            {
                List<object> Functions;
                Model.GetMultiProperty("functions", out Functions);

                foreach (string SQL in SQLWords)
                {
                    foreach (var function in Functions)
                    {
                        if (SQL == function.ToString())
                        {
                            //Add to processing queue
                            TreeItem ti = new TreeItem(SQL, TreeItem.Type.FUNCTION);
                            processor.AddToQue(ti);
                        }
                    }
                }
                processor.CompletedProcesses[(int)TreeItem.Type.FUNCTION] = 1;
            };

            //Start searching in parallel
            Parallel.Invoke(checkViews, checkProcedures, checkTables, checkFunctions);
            processor.startProcessing();
            
        }

    }
}
