using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.views.produtos;

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
            //formUsuario formuser = new formUsuario();

            //formuser.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            //formuser.MdiParent = this;
            //formuser.Show();

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFuncionario formfunci = new formFuncionario();
            formfunci.ShowDialog();
        }

        private void telaprincipal_Load(object sender, EventArgs e)
        {
            

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsuario formuser = new formUsuario();

            formuser.Show();

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProduto fpro = new formProduto();

            fpro.ShowDialog();

            
            
        }
    }
}
