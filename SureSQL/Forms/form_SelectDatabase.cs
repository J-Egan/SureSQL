using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SureSQL.Forms
{
    public partial class form_SelectDatabase : Form
    {
        Model Model;
        IContextSender Sender;
        public form_SelectDatabase()
        {
            InitializeComponent();
        }

        public form_SelectDatabase(Model Model, IContextSender Sender)
        {
            InitializeComponent();
            this.Model = Model;
            this.Sender = Sender;
        }

        private void form_SelectDatabase_Load(object sender, EventArgs e)
        {
            List<object> databases;
            Model.GetMultiProperty("databases", out databases);

            foreach (object O in databases)
            {
                lst_databases.Items.Add(O.ToString());
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //get selected item
            if (lst_databases.SelectedItem != null)
            {
                string database = lst_databases.SelectedItem.ToString();

                Model.AddSingleProperty("SelectedDatabase", database);
                this.Sender.ContextUpdate();
                this.Close();
            }
        }
    }
}
