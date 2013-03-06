using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.Modulos.aplicacao;

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
            if (dgw_aplicacao.CurrentCell != null)
            {
                int selecionado = dgw_aplicacao.CurrentCell.RowIndex;
                int idaplicacao;
                idaplicacao = int.Parse(dgw_aplicacao.Rows[selecionado].Cells["id_aplicacao"].Value.ToString());

                FormAlterarAplicacao Aplicacao = new FormAlterarAplicacao(idaplicacao);

                Aplicacao.ShowDialog();

                // atualiza o grid
                Aplicacao aplicacao = new Aplicacao();
                aplicacao.ListarAplicacoes(dgw_aplicacao);

            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastraAplicacao Cadastro = new FormCadastraAplicacao();
            Cadastro.ShowDialog();

            // atualiza grid
            Aplicacao aplicacao = new Aplicacao();
            aplicacao.ListarAplicacoes(dgw_aplicacao);
        }
    }
}
