using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SureSQL.Forms
{
    public partial class form_newConnection : Form
    {
        Model Model;
        IContextSender Sender;
        public form_newConnection()
        {
            InitializeComponent();
        }

        public form_newConnection(Model Model, IContextSender Sender)
        {
            InitializeComponent();
            this.Model = Model;
            this.Sender = Sender;
        }


        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //check credentials have been entered
            if (txt_Server.Text.Length > 0)
            {
                //Attempt DB connection
                string server, username, password;
                server = txt_Server.Text;
                username = txt_Username.Text;
                password = txt_Password.Text;

                Model.AddSingleProperty("server", server);
                Model.AddSingleProperty("username", username);
                Model.AddSingleProperty("password", password);

                Sender.ContextUpdate();
                this.Close();
            }
            else
            {
                lbl_Error.Text += "Enter Server Address";
            }

        }

        private void form_newConnection_Load(object sender, EventArgs e)
        {
            lbl_Error.Text = "";
        }
    }
}
