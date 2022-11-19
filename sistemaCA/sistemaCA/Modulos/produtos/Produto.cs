using System;
using System.Linq;
using System.Windows.Forms;

namespace sistemaCA.views.produtos
{
    class Produto : ClasseBase
    {
        public int Idproduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public int Id_tipoproduto { get; set; }


        public Produto() : base(new DataClasses1DataContext())
        { }

        public void ListaProdutos(DataGridView dgw)
        {

            dgw.DataSource = Banco.spListaProduto();

        }


        public void CadastarProduto()
        {
            try
            {
                Banco.spCadastarProduto(this.Nome, this.Descricao, this.UnidadeMedida, this.Id_tipoproduto);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        // deletar produto parametro ID produto a ser deletado
        public void DeletarProduto(int id)
        {
            try
            {

                Banco.spDeletarProduto(id);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        public void VisualizarProduto(int id)
        {
            try
            {

                tblproduto produto = new tblproduto();

                // criar pesquisa  no banco para encontrar registro selecionado
                var pesquisa = from Produtos in Banco.tblprodutos
                               where Produtos.id_produto == id
                               select Produtos;


                produto = pesquisa.Single();


                this.Idproduto = produto.id_produto;
                this.Nome = produto.nome;
                this.UnidadeMedida = produto.unidade_medida;
                this.Id_tipoproduto = produto.id_tipoproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }


        public void AlterarProduto()
        {
            try
            {
                Banco.spAlterarProduto(this.Idproduto, this.Nome, this.Descricao, this.UnidadeMedida, this.Id_tipoproduto);
            }
            catch (Exception exe)
            {

                MessageBox.Show(" Erro  : " + exe.Message);
            }

        }








    }
}
