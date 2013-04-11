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
    public partial class FormCadastraBen : Form
    {
        public FormCadastraBen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bens ben = new Bens();

            ben.Cod_Controle = mtb_codigoControle.Text;
            ben.Descricao = tb_descricao.Text;
            ben.TipoBens = cb_tipo.Text;
            ben.Data_Aquisicao = dtp_dataaquisicao.Value;
            ben.Preco_Aquisicao =float.Parse(tb_precoaquisicao.Text);
            ben.Placa = mtb_placa.Text;
            if (mtb_hododmetro.Text != "")
            {
                ben.Hodometro_incial = int.Parse(mtb_hododmetro.Text);
            }
            if (mtb_horimetro.Text != "")
            {
                ben.Horimetro_incial = int.Parse(mtb_horimetro.Text);
            }
            ben.CadastrarBens();
            Close();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
