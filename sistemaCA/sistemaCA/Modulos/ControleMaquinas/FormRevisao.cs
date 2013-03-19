using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.Modulos.ControleMaquinas
{
    public partial class FormRevisao : Form
    {
        public FormRevisao()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroRevisao FormCada =new FormCadastroRevisao();
            FormCada.ShowDialog();
            // atualizando.
            ControleRevisao Revisao = new ControleRevisao();
            Revisao.VisualizarRevisao(dgw_revisao);
        }

        private void FormRevisao_Load(object sender, EventArgs e)
        {
            
            
            // preechendo grid.
            ControleRevisao Revisao = new ControleRevisao();
            Revisao.VisualizarRevisao(dgw_revisao);

            toolStripStatusLabel1.Text = dgw_revisao.RowCount + " Revisões Cadatrada.";
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (dgw_revisao.CurrentCell != null)
            {
                int selecionado = dgw_revisao.CurrentCell.RowIndex;
                int idaplicacao;
                idaplicacao = int.Parse(dgw_revisao.Rows[selecionado].Cells["id"].Value.ToString());

                FormAlterarRevisao revisao = new FormAlterarRevisao(idaplicacao);
                revisao.ShowDialog();
                
                // preechendo grid.
                ControleRevisao Revisao = new ControleRevisao();
                Revisao.VisualizarRevisao(dgw_revisao);


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgw_revisao.CurrentCell != null)
            {
                int selecionado = dgw_revisao.CurrentCell.RowIndex;
                int idrevisao;
                idrevisao = int.Parse(dgw_revisao.Rows[selecionado].Cells[0].Value.ToString());

                var resultado = MessageBox.Show("Tem Certeza de quer excluir o Registro Selecionado ?", "Excluir Registro", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    ControleRevisao revisao = new ControleRevisao();
                    revisao.ExcluirRevisao(idrevisao);


                  // atualizando grid
                    revisao.VisualizarRevisao(dgw_revisao);
                }
            }
        }
    }
}
