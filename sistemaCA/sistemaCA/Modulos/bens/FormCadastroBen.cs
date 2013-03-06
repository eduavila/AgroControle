using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.bens
{
    public partial class FormCadastrarBen : Form
    {
        public FormCadastrarBen()
        {
            InitializeComponent();
        }

        private void FromCadatroBens_Load(object sender, EventArgs e)
        {

        }

        private void Descrição_Click(object sender, EventArgs e)
        {

        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Bens ben = new Bens();

                ben.Descricao = tb_descricao.Text;
                ben.Cod_Controle = tb_CodControle.Text;
                ben.Data_Aquisicao = dtp_dataaquisicao.Value;
                ben.Placa = mtb_placa.Text;
                ben.Preco_Aquisicao = double.Parse(tb_precoaquisicao.Text);
                ben.TipoBens = tb_tipomaquina.Text;

                ben.CadastrarBens();

                Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
