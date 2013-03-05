using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.FormPesquisa
{
    public partial class FormPesquisa : Form
    {
        public int ID { get; set; }
        public FormPesquisa()
        {
            InitializeComponent();


            PreecherGrid();
        }

        private void dgw_pesquisa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = PegaID();
        }


        // metodo para pega o id com 2 clicke
        public virtual int PegaID()
        {
            
            int selecionado = dgw_pesquisa.CurrentCell.RowIndex;
            int idfuncionario;
            idfuncionario = int.Parse(dgw_pesquisa.Rows[selecionado].Cells["id_funcionario"].Value.ToString());

            return idfuncionario;
        }

        public virtual void PreecherGrid()
        { 
            Pesquisa pesqui = new Pesquisa();

            pesqui.ListaFuncionario(dgw_pesquisa);                
        }
        public virtual void Pesquisar(string pesquisa,DataGridView dgw)
        {
            Pesquisa pesqui = new Pesquisa();
            pesqui.PesquisarFuncionario(pesquisa,dgw);
        
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
    }
}
