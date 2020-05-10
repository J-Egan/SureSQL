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
    public partial class form_Root : Form
    {
        Model Model;
        public form_Root()
        {
            InitializeComponent();
        }

        public form_Root(Model Model)
        {
            InitializeComponent();
            this.Model = Model;

            //setup listners
            lst_Functions.MouseDoubleClick += new MouseEventHandler(lst_Functions_MouseDoubleClick);
            lst_StoredProcedures.MouseDoubleClick += new MouseEventHandler(lst_StoredProcedures_MouseDoubleClick);
            lst_Views.MouseDoubleClick += new MouseEventHandler(lst_Views_MouseDoubleClick);
        }

        private void form_Root_Load(object sender, EventArgs e)
        {
            //update lists
            List<object> storedProcedures;
            Model.GetMultiProperty("storedProcedures", out storedProcedures);
            foreach (var item in storedProcedures)
            {
                lst_StoredProcedures.Items.Add(item.ToString());
            }

            List<object> functions;
            Model.GetMultiProperty("functions", out functions);
            foreach (var item in functions)
            {
                lst_Functions.Items.Add(item.ToString());
            }

            List<object> views;
            Model.GetMultiProperty("views", out views);
            foreach (var item in views)
            {
                lst_Views.Items.Add(item.ToString());
            }
        }

        void lst_Functions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lst_Functions.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                //Run code to open new tree tab
                MessageBox.Show(index.ToString());
            }
        }
        void lst_StoredProcedures_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lst_StoredProcedures.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                //Run code to open new tree tab
                MessageBox.Show(index.ToString());
            }
        }
        void lst_Views_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lst_Views.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                //Run code to open new tree tab
                MessageBox.Show(index.ToString());
            }
        }
    }
}
