using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.safra
{
    public partial class FormCadastroSafra : Form
    {
        public FormCadastroSafra()
        {
            InitializeComponent();
        }

        private void FromCadastroSafra_Load(object sender, EventArgs e)
        {
            tb_status.Text = "Aberta";
            tb_status.Enabled = false;



            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // cria nova safra
            Safra safra = new Safra();
            // add os valores no objeto safra 
            safra.Descricao = tb_descricao.Text;
            safra.DataInicio = dt_datainicio.Value;
            safra.IdCultura = int.Parse(tb_tipocultura.Text);
            safra.status = tb_status.Text;
            safra.Obs = tb_obs.Text;


            // metodo que cadastra a safra
            safra.Cadastrar();

            MessageBox.Show("Registro Cadastrado com sucesso!");

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormTipoCultura FormTipo = new FormTipoCultura();
            FormTipo.ShowDialog();
            tb_tipocultura.Text = FormTipo.Id_cultura.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
