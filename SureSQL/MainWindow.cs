using SureSQL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SureSQL
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
      
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            Model Model = Model.Instance;
            //Load Main form as child.
            Form f = new form_Main(Model);
            f.MdiParent = this;
            f.Show();
        }
    }
}
