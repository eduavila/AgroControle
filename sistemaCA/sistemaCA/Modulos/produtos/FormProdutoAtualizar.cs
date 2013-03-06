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
    public partial class FormProdutoAtualizar : Form
    {
        public FormProdutoAtualizar()
        {
            InitializeComponent();
        }

        public FormProdutoAtualizar(int id)
        {
            InitializeComponent();

            Produto produto = new Produto();

            produto.VisualizarProduto(id);

            tb_id.Text = produto.Idproduto.ToString();
            tb_nome.Text = produto.Nome;
            tb_descricao.Text = produto.Descricao;
            cb_unidademedida.Text = produto.UnidadeMedida;
            cb_tipoproduto.Text = produto.Id_tipoproduto.ToString();



            tb_id.Enabled = false;
            tb_nome.Enabled = false;
            tb_descricao.Enabled = false;
            cb_unidademedida.Enabled = false;
            cb_tipoproduto.Enabled = false;

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
            tb_nome.Enabled = true;
            tb_descricao.Enabled = true;
            cb_unidademedida.Enabled = true;
            cb_tipoproduto.Enabled = true;
        }

        private void FromProdutoAtulizar_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto();

            produto.Idproduto = int.Parse(tb_id.Text);
            produto.Nome = tb_nome.Text;
            produto.Descricao = tb_descricao.Text;
            produto.UnidadeMedida = cb_unidademedida.Text;
            produto.Id_tipoproduto = int.Parse(cb_tipoproduto.Text);

            produto.AlterarProduto();

            
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Produto Dproduto =new Produto();

            var  resultado = MessageBox.Show("Tem Certeza de quer excluir o Registro Selecionado ?","Excluir Registro" ,MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Dproduto.DeletarProduto(int.Parse(tb_id.Text));
                MessageBox.Show("Foi Excluido com sucesso");
                this.Close();
            
            }

        }
    }
}
