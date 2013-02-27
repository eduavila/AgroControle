using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.produtos
{
    public partial class FormtipoProduto : Form
    {


        // propridade para pegar o id produto enviar par outro formulario
        public int IDtipoProduto { get; set; }

        public FormtipoProduto()
        {
            InitializeComponent();
        }

        private void FormtipoProduto_Load(object sender, EventArgs e)
        {
            TipoProduto tipop = new TipoProduto();
            tipop.ListarTipoProduto(dgv_tipoproduto);

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            // pesquisa se o campo tb_pesquisar nao estiver vazio
            if(tb_pesquisa.Text != null )
            {
                TipoProduto tipop = new TipoProduto();
                tipop.Pesquisa(tb_pesquisa.Text, dgv_tipoproduto);
            
            }
        }

        private void dgv_tipoproduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // pegando id produto com douplo clicke
            int selecionado = dgv_tipoproduto.CurrentCell.RowIndex;
          
            this.IDtipoProduto = int.Parse(dgv_tipoproduto.Rows[selecionado].Cells["id_tipoproduto"].Value.ToString());
            this.Close();
        }

        private void tb_pesquisa_TextChanged(object sender, EventArgs e)
        {
                TipoProduto tipop = new TipoProduto();
                tipop.Pesquisa(tb_pesquisa.Text, dgv_tipoproduto);

                if (tb_pesquisa.Text == "")
                {
                    tipop.ListarTipoProduto(dgv_tipoproduto);
                }
        }
    }
}
