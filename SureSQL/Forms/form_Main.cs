using SureSQL.Database.MySQL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SureSQL.Forms
{
    public partial class form_Main : Form, IContextSender
    {
        Model Model;
        public form_Main()
        {
            InitializeComponent();
        }

        public form_Main(Model Model)
        {
            InitializeComponent();
            this.Model = Model;
            tab_main.DrawItem += new DrawItemEventHandler(DrawOnTab);
            tab_main.MouseClick += new MouseEventHandler(tab_main_MouseDown);
        }

        private void DrawOnTab(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tab_main.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        void tab_main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Middle Click to remove tab
            if (e.Button == MouseButtons.Middle)
            {
                foreach (TabPage t in tab_main.TabPages)
                {
                    if (t.ClientRectangle.Contains(e.Location))
                    {
                        if (!t.Text.Equals("Root"))
                        {
                            tab_main.TabPages.Remove(t);
                        }
                    }

                }

            }
        }

        private void menu_NewConnection_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Run manual search
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (!chk_DelaySearch.Checked)
            {
                //Run search dynamically
            }
        }

        private void menu_MySQL_Click(object sender, EventArgs e)
        {
            //set model property
            Model.AddSingleProperty("SQL", "MySQL");

            //Open Connection Menu
            Form conn = new form_newConnection(Model, this);
            conn.Show();
        }

        public void ContextUpdate()
        {
            //Attempt to connect to database
            if (Model.CheckSingleProperty("SQL"))
            {
                string db_type = "";
                Model.GetSingleProperty("SQL", out db_type);

                switch (db_type)
                {
                    case "MySQL":
                        if (!Model.CheckSingleProperty("SelectedDatabase"))
                        {
                            try
                            {
                                MySQL mySql;
                                //Connect to SQL server
                                string server, username, password;
                                server = Model.GetSingleProperty("server", out server);
                                username = Model.GetSingleProperty("username", out username);
                                password = Model.GetSingleProperty("password", out password);

                                mySql = new MySQL(server, username, password);

                                //get SQL tables information
                                List<object> databases = new List<object>(mySql.GetDatabases());

                                Model.AddMultiProperty("databases", databases);

                                //Update form with new information
                                Form f = new form_SelectDatabase(Model, this);
                                f.Show();
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }
                        else
                        {
                            try
                            {
                                MySQL mySql;
                                //Connect to SQL server
                                string server, username, password, database;
                                server = Model.GetSingleProperty("server", out server);
                                username = Model.GetSingleProperty("username", out username);
                                password = Model.GetSingleProperty("password", out password);
                                database = Model.GetSingleProperty("SelectedDatabase", out database);

                                mySql = new MySQL(server, username, password, database);

                                //update database with database name
                                mySql.updateDatabase();

                                //get SQL information
                                List<object> storedProcedures = new List<object>(mySql.GetProcedures());
                                Model.AddMultiProperty("storedProcedures", storedProcedures);

                                List<object> functions = new List<object>(mySql.GetFunctions());
                                Model.AddMultiProperty("functions", functions);

                                List<object> views = new List<object>(mySql.GetViews());
                                Model.AddMultiProperty("views", views);

                                //Update Titles
                                string title; 
                                Model.GetSingleProperty("SelectedDatabase", out title);
                                lbl_CurrentDB.Text = title;

                                //Update form with new information
                                Form f = new form_Root(Model);
                                f.TopLevel = false;
                                f.Parent = tabRoot;
                                f.Show();

                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                        break;

                    case "TSQL":
                        break;

                    default:
                        break;
                }
            }

        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            //demo second tab
            Form test = new form_Tree();
            test.TopLevel = false;
            TabPage tp = new TabPage("Test Tab");
            tab_main.TabPages.Add(tp);

            test.Parent = tp;
            test.Show();

        }

    }
}
