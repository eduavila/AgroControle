using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.views.Pesquisa;


namespace sistemaCA.Modulos.ControleMaquinas
{
    public partial class FormCadastroRevisao : Form
    {
        public FormCadastroRevisao()
        {
            InitializeComponent();

        }

        private void FormCadastroRevisao_Load(object sender, EventArgs e)
        {
            ControleRevisao Revisao = new ControleRevisao();

            Revisao.ListandoProduto(produto);
        }

        private void motivoLabel_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            ControleRevisao Revisao = new ControleRevisao();

            Revisao.Motivo = tb_descricao.Text;
            Revisao.data_cadastro = DateTime.Today.Date;
            Revisao.data_revisao = Dtp_datarevisao.Value;
            Revisao.Status = cb_status.Text;
            Revisao.ID_Ben = int.Parse(tb_maquina.Text);
            Revisao.ID_Safra = int.Parse(tb_safra.Text);



            // metodo de cadastro revisao.
            Revisao.CadastroRevisao();

            Revisao.CadastraProdutoAplicado(dgw_produtos);


        }

        private void dTItemRevisaoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPesquisaMaquinas pes_maqui = new FormPesquisaMaquinas();
            pes_maqui.ShowDialog();
            tb_maquina.Text = pes_maqui.ID.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPesquisaSafra safra = new FormPesquisaSafra();
            safra.ShowDialog();
            tb_safra.Text = safra.ID.ToString();
        }
       
    }
}
