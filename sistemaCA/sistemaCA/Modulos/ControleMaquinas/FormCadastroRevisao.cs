using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.Modulos.ControleMaquinas.dsRevisaoTableAdapters;

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
           

            // TODO: This line of code loads data into the 'dsRevisao.DTItemRevisao' table. You can move, or remove it, as needed.
            this.dTItemRevisaoTableAdapter.Fill(this.dsRevisao.DTItemRevisao);

            // TODO: This line of code loads data into the 'dsRevisao.DTRevisao' table. You can move, or remove it, as needed.
            this.dTRevisaoTableAdapter.Fill(this.dsRevisao.DTRevisao);

            DataClasses1DataContext db = new DataClasses1DataContext();
            // prechendo como box safra.
            var result = from safra in db.tblsafras select new { safra = safra.descricao };


            safraComboBox.DataSource = result;
            safraComboBox.DisplayMember = "safra";
            safraComboBox.ValueMember = "safra";
            // ----------------------------------------------------------

            // prenchendo combo maquinas
            var bens = from maquina in db.tblbens select new {maquina = maquina.codigoControle };

            máquinaComboBox.DataSource = bens;
            máquinaComboBox.DisplayMember = "maquina";
            máquinaComboBox.ValueMember = "maquina";



            // prenchendo combox produtos
            var pro = from produ in db.tblprodutos
                          select new {produto = produ.descricao};

            dataGridViewComboBoxColumn2.DataSource = pro;
            dataGridViewComboBoxColumn2.DisplayMember = "produto";
            dataGridViewComboBoxColumn2.ValueMember = "produto";
            //------------------------

            

            

        }

        private void motivoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dTRevisaoTableAdapter.FillBy(this.dsRevisao.DTRevisao);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {

           


          
            


        }
    }
}
