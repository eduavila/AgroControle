using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.views;

namespace sistemaCA
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
            else
            {
                timer1.Enabled = false;
                FormLogin formlogin = new FormLogin();
                formlogin.Show();

                this.Visible = false;

                
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
