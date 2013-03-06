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
    public partial class FormTipoCultura : Form
    {
        public int Id_cultura { get; set; }

        public FormTipoCultura()
        {
            InitializeComponent();
        }

        private void FormTipoCultura_Load(object sender, EventArgs e)
        {
            Cultura cult = new Cultura();

            cult.ListarCultura(dgw_cultura);

            dgw_cultura.Columns["id_cultura"].HeaderText = "ID";
            dgw_cultura.Columns["nome"].HeaderText = "Nome";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tb_pesquisa.Text == " ")
            {

                Cultura cult = new Cultura();

                cult.ListarCultura(dgw_cultura);

            }
            else
            {
                Cultura cult = new Cultura();

                cult.Pesquisar(tb_pesquisa.Text, dgw_cultura);
            
            
            }
        }

        private void dgw_cultura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selecionado = dgw_cultura.CurrentCell.RowIndex;
            

            Id_cultura = int.Parse(dgw_cultura.Rows[selecionado].Cells["id_cultura"].Value.ToString());

            Close();
        }

        private void dgw_cultura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
