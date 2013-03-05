using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.Pesquisa
{
    public partial class FormPesquisa : Form
    {
        public DataClasses1DataContext Banco { get; set; }
        public int ID { get; set; }
        public FormPesquisa()
        {
            InitializeComponent();
            Banco = new DataClasses1DataContext();
           
            // preechendo grid
            PreecherGrid();

            // alterando titulo do grid
            AlterarHeadGrid();
        }

        private void dgw_pesquisa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


      

        private void tb_pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tb_pesquisa.Text == "")
            {
                PreecherGrid();
            }
            else if (tb_pesquisa.Text != null)
            {
                Pesquisar(tb_pesquisa.Text, dgw_pesquisa);
            }
        }

        private void dgw_pesquisa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        public virtual void dgw_pesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ID = PegaID();
        }


        /*
            Metodos virtual para a recrever .
        

        */
        // metodo para pega o id com 2 clicke
        public virtual int PegaID()
        {

            int selecionado = dgw_pesquisa.CurrentCell.RowIndex;
            int idfuncionario;
            idfuncionario = int.Parse(dgw_pesquisa.Rows[selecionado].Cells[0].Value.ToString());
            Close();
            return idfuncionario;
        }

        public virtual void PreecherGrid()
        {
            Pesquisa pesqui = new Pesquisa();

            pesqui.ListaFuncionario(dgw_pesquisa);
        }
        public virtual void Pesquisar(string pesquisa, DataGridView dgw)
        {
            Pesquisa pesqui = new Pesquisa();
            pesqui.PesquisarFuncionario(pesquisa, dgw);

        }
        public virtual void AlterarHeadGrid()
        {
            dgw_pesquisa.Columns["id"].HeaderText = "ID Funcionário";
            dgw_pesquisa.Columns["nome"].HeaderText = "Nome";
            dgw_pesquisa.Columns["sobrenome"].HeaderText = "SobreNome";
        
        }

        private void dgw_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
               this.ID = PegaID();
            
            }
        }
    }
}
