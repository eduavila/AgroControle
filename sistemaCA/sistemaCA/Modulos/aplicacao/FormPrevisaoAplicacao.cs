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
using sistemaCA.Modulos.aplicacao.relatorios;

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


            Barra_rodape1.Text = dgw_aplicacao.RowCount + " Aplicações Cadastrada.";


            


            
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

        private void dgw_aplicacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza de quer excluir o Registro Selecionado ?", "Excluir Registro", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int selecionado = dgw_aplicacao.CurrentCell.RowIndex;
                    int idaplicacao;
                    idaplicacao = int.Parse(dgw_aplicacao.Rows[selecionado].Cells["id_aplicacao"].Value.ToString());


                    ProdutoAplicado produtos = new ProdutoAplicado();
                    produtos.DeletandoTodoProduto(idaplicacao);

                    Aplicacao aplicacao = new Aplicacao();
                    aplicacao.DeletarAplicacao(idaplicacao);

                    // atualizando grid
                    aplicacao.ListarAplicacoes(dgw_aplicacao);

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

                
                

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_visualizar_Click_1(object sender, EventArgs e)
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

        private void btn_Deletar_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgw_aplicacao.CurrentCell != null)
            {
                int selecionado = dgw_aplicacao.CurrentCell.RowIndex;
                int idaplicacao;
                idaplicacao = int.Parse(dgw_aplicacao.Rows[selecionado].Cells["id_aplicacao"].Value.ToString());

                FormRelatorioAplicacao Aplicacao = new FormRelatorioAplicacao(idaplicacao);

                Aplicacao.ShowDialog();

            }
        }
    }
}
