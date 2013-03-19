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
    }
}
