using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.views.bens;
using sistemaCA.views.produtos;
using sistemaCA.views.safra;
using sistemaCA.views.talhao;
using sistemaCA.views.fornecedor;
using sistemaCA.views.aplicacao;
using sistemaCA.Modulos.ControleMaquinas;
using sistemaCA.Properties;

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

        private void safraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSafra formsafra = new FormSafra();
            formsafra.Show();

        }

        private void talhãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTalhao formtalhao = new FormTalhao();
            formtalhao.Show();
        }

        private void bensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFornecedores fornecedor =new FormFornecedores();
            fornecedor.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbens Formben =new Formbens();
            Formben.Show();
        }

        private void retornoAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aplicaçãoPréviaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormPrevisaoAplicacao Aplicacao = new FormPrevisaoAplicacao();
            Aplicacao.Show();
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void previsãoRevisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRevisao revisao = new FormRevisao();
            revisao.Show();
        }

        private void telaprincipal_Load_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Usuário: " + sistemaCA.Program.Usuario;
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
