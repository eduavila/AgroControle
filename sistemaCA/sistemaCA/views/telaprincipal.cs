using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views
{
    public partial class telaprincipal : Form
    {
        public telaprincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsuario formuser = new formUsuario();
            formuser.ShowDialog();

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFuncionario formfunci = new formFuncionario();
            formfunci.ShowDialog();
        }

        private void telaprincipal_Load(object sender, EventArgs e)
        {
            

        }
    }
}
