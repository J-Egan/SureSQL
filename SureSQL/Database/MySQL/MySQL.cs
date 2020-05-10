using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SureSQL.Database.MySQL
{
    class MySQL
    {
        private MySqlConnection Connection;
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        private string Query_GetTables = "SHOW TABLES";
        private string Query_GetStoredProcedures = "SHOW PROCEDURE STATUS";
        private string Query_GetFunctions = "SHOW FUNCTION STATUS";
        private string Query_GetViews = "SHOW FULL TABLES WHERE table_type = 'VIEW'";

        public MySQL() { }

        public MySQL(string server, string user, string password)
        {
            this.Server = server;
            this.User = user;
            this.Password = password;
            this.Connect();
        }
        public MySQL(string server, string user, string password, string database)
        {
            this.Server = server;
            this.User = user;
            this.Password = password;
            this.Database = database;
            this.Connect();
        }


        public void Connect()
        {
            string ConnetionString;
            if (this.Database == null)
            {
                ConnetionString = "SERVER=" + this.Server + ";" +
                    "UID=" + this.User + ";" +
                    "PASSWORD=" + this.Password + ";";
            }
            else
            {
                ConnetionString = "SERVER=" + this.Server + ";" +
                    "DATABASE=" + this.Database + ";" +
                    "UID=" + this.User + ";" +
                    "PASSWORD=" + this.Password + ";";
            }

            Connection = new MySqlConnection(ConnetionString);
        }
        private bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<string> GetDatabases()
        {
            return RunQuery("SHOW DATABASES;");
        }

        public List<string> RunQuery(string query)
        {
            List<string> results = new List<string>();
            //open connection
            this.OpenConnection();
            //run query
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, this.Connection);
                MySqlDataReader DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    string data = "";
                    for (int i = 0; i < DataReader.FieldCount; i++)
                    {
                        data += DataReader.GetValue(i);
                    }
                    results.Add(data);
                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                    case 1064:
                        MessageBox.Show("You have an error in your SQL syntax;");
                        break;
                }
                throw;
            }
            //close connection
            this.CloseConnection();

            //return result set
            return results;
        }

        public void updateDatabase()
        {
            Query_GetStoredProcedures = "USE " + this.Database + ";" + Query_GetStoredProcedures;
            Query_GetTables = "USE " + this.Database + ";" + Query_GetTables;
            Query_GetFunctions = "USE " + this.Database + ";" + Query_GetFunctions;
            Query_GetViews = "USE " + this.Database + ";" + Query_GetViews;
        }
        public List<string> GetProcedures()
        {
            return this.RunQuery(Query_GetStoredProcedures);
        }
        public List<string> GetTables()
        {
            return this.RunQuery(Query_GetTables);
        }
        public List<string> GetFunctions()
        {
            return this.RunQuery(Query_GetFunctions);
        }
        public List<string> GetViews()
        {
            return this.RunQuery(Query_GetViews);
        }
    }
}