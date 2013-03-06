using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.aplicacao
{
    public partial class FormPrevisaoAplicacao : Form
    {
        public FormPrevisaoAplicacao()
        {
            InitializeComponent();
        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormAplicacao_Load(object sender, EventArgs e)
        {
            Aplicacao aplicacao = new Aplicacao();
            aplicacao.ListarAplicacoes(dgw_aplicacao);
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastraAplicacao Cadastro = new FormCadastraAplicacao();
            Cadastro.ShowDialog();

            Aplicacao aplicacao = new Aplicacao();
            aplicacao.ListarAplicacoes(dgw_aplicacao);
        }
    }
}
