using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureSQL.Database.TSQL
{
    class TSQL
    {
        private string _ListDatabases = "SELECT name FROM sys.databases";
        private string _GetProcedures = "SELECT name FROM sys.procedures";
        private string _GetFunctions = "SELECT name FROM dbo.sysobjects WHERE type IN ('FN','IF', 'TF')";
        private string _GetViews = "SELECT name FROM sys.views";
        private string _GetTables;

        private string ConnectionString { get; set; }

        public TSQL(SqlConnectionStringBuilder cstring) 
        {
            this.ConnectionString = cstring.ConnectionString;
        }

        public void SetSchema(string SchemaName)
        {
            this._GetTables = "SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_CATALOG = '" + SchemaName + "' and TABLE_TYPE = 'BASE TABLE'";
            this._ListDatabases = "SELECT name FROM "+ SchemaName + ".sys.databases";
            this._GetProcedures = "SELECT name FROM " + SchemaName + ".sys.procedures";
            this._GetFunctions = "SELECT name FROM " + SchemaName + ".dbo.sysobjects WHERE type IN ('FN','IF', 'TF')";
            this._GetViews = "SELECT name FROM " + SchemaName + ".sys.views";
        }

        public List<string> GetProcedures() 
        {
            List<string> procedures = new List<string>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                SqlDataReader reader;
                conn.Open();

                //get procedures
                SqlCommand cmd = new SqlCommand(_GetProcedures, conn);
                reader = cmd.ExecuteReader();

                //save to list
                while (reader.Read())
                {
                    procedures.Add((string)reader.GetValue(0));
                }

            }//using will close open connections

            return procedures;
        }

        public List<string> GetViews()
        {
            List<string> views = new List<string>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                SqlDataReader reader;
                conn.Open();

                //get procedures
                SqlCommand cmd = new SqlCommand(_GetViews, conn);
                reader = cmd.ExecuteReader();

                //save to list
                while (reader.Read())
                {
                    views.Add((string)reader.GetValue(0));
                }

            }//using will close open connections

            return views;
        }

        public List<string> GetFunctions()
        {
            List<string> functions = new List<string>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                SqlDataReader reader;
                conn.Open();

                //get procedures
                SqlCommand cmd = new SqlCommand(_GetFunctions, conn);
                reader = cmd.ExecuteReader();

                //save to list
                while (reader.Read())
                {
                    functions.Add((string)reader.GetValue(0));
                }

            }//using will close open connections

            return functions;
        }

        public List<string> GetTables()
        {
            List<string> tables = new List<string>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                SqlDataReader reader;
                conn.Open();

                //get procedures
                SqlCommand cmd = new SqlCommand(_GetTables, conn);
                reader = cmd.ExecuteReader();

                //save to list
                while (reader.Read())
                {
                    tables.Add((string)reader.GetValue(0));
                }

            }//using will close open connections

            return tables;
        }

        public List<string> GetDatabases()
        {
            List<string> schemas = new List<string>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                SqlDataReader reader;
                conn.Open();

                //get procedures
                SqlCommand cmd = new SqlCommand(_ListDatabases, conn);
                reader = cmd.ExecuteReader();

                //save to list
                while (reader.Read())
                {
                    schemas.Add((string)reader.GetValue(0));
                }

            }//using will close open connections

            return schemas;
        }
    }
}
