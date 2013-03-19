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
    public partial class FormAlterarRevisao : Form
    {
        public FormAlterarRevisao()
        {
            InitializeComponent();
        }

        public FormAlterarRevisao(int idrevisao)
        {
            InitializeComponent();

            ControleRevisao revisao = new ControleRevisao();

            revisao.VisualizarRevisaoDl(idrevisao);

            tb_id.Text = revisao.ID_Revisao.ToString();
            tb_descricao.Text = revisao.Motivo;
            dtp_data_cadastro.Value = revisao.data_cadastro;
            Dtp_datarevisao.Value = revisao.data_revisao;
            tb_maquina.Text = revisao.ID_Ben.ToString();
            tb_safra.Text = revisao.ID_Safra.ToString();
            cb_status.Text = revisao.Status;

            revisao.visualiarItemRevisa(dgw_produtos, idrevisao);


            



        }

        private void FormAlterarRevisao_Load(object sender, EventArgs e)
        {

        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {

            tb_descricao.Enabled = true;
            Dtp_datarevisao.Enabled = true;
            tb_maquina.Enabled = true;
            btnMaquina.Enabled = true;
            btnsafra.Enabled = true;
            tb_safra.Enabled = true;
            cb_status.Enabled = true;

            dgw_produtos.Enabled = true;


          

           

        }

        private void dgw_produtos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dgw_produtos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
