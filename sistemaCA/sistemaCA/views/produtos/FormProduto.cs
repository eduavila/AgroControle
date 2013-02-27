using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.views.produtos;


namespace sistemaCA.views.produtos
{
    public partial class formProduto : Form
    {
        public formProduto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProduto_Load(object sender, EventArgs e)
        {


            Produto Prod = new Produto();



            Prod.ListaProdutos(dgw_produto);// listando produto no data grid


            // alterando cabeçalho do datagrid produto
            dgw_produto.Columns["id_produto"].HeaderText = "ID";
            dgw_produto.Columns["nome"].HeaderText = "Nome";
            dgw_produto.Columns["unidade_medida"].HeaderText = "Unidade Medida ";
            dgw_produto.Columns["id_tipoproduto"].HeaderText = "Tipo Produto ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // teste com classe 
            int selecionado = dgw_produto.CurrentCell.RowIndex;

            int idprod;

            idprod = int.Parse(dgw_produto.Rows[selecionado].Cells["id_produto"].Value.ToString());

            // criando novo formulario atualizar com parametro do numero 1 da cells do data grid
            FormProdutoAtualizar formproduto = new FormProdutoAtualizar(idprod);
            formproduto.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProdutosAtualizar Fprodutocadastro = new FormProdutosAtualizar();
            Fprodutocadastro.ShowDialog();


        }
    }
}
