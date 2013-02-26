using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA;
namespace sistemaCA.views.produtos
{
    public partial class FormProdutosAtualizar : Form
    {
       

        public FormProdutosAtualizar()
        {
            InitializeComponent();

            
        }

      

        private void FormProdutosCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {


            Produto produto = new Produto();
            produto.Nome = tb_nome.Text;
            produto.Descricao = tb_descricao.Text;
            produto.UnidadeMedida = cb_unidademedida.Text;
            produto.Id_tipoproduto = int.Parse(tb_tipoproduto.Text);

            produto.CadastarProduto();


            //produto.descricao tb_descricao.Text = produto.descricao;
            //tb_nome.Text = produto.nome;
            //cb_unidademedida. = produto.unidade_medida;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormtipoProduto formtipo = new FormtipoProduto();
            formtipo.ShowDialog();
            tb_tipoproduto.Text = formtipo.IDtipoProduto.ToString();
            
        }
    }
}
