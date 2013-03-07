using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaCA.Modulos.aplicacao
{
    public class ProdutoAplicado
    {
        public DataClasses1DataContext Banco { get; set; }
        public tblproduto Produto { get; set; }
        public tblprodutosaplicado ProdutoAplica { get; set; }

        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public float Total { get; set; }
        public int Id_Produto { get; set; }
        public int Id_Fornecedor { get; set; }
        public int Id_aplicacao { get; set; }

        public ProdutoAplicado()
        {
            Banco = new DataClasses1DataContext();
            Produto = new tblproduto();
        }



        public void ListandoProduto(DataGridView dgw)
        {
           
            var pro = from produ in Banco.tblprodutos select produ.descricao;

            DataGridViewComboBoxColumn produto = new DataGridViewComboBoxColumn();
            produto.HeaderText = "Produto";

            produto.DataSource = pro.ToList();

            dgw.Columns.Add(produto);
        }

        public int ProximoRegistro()
        {
            var aplica = from aplicacao in Banco.tblaplicacaos select aplicacao.id_aplicacao;

            int result = aplica.Max()+1;

            return result;
        }




        public void CadastraProdutoAplicado()
        {
            try
            {
                ProdutoAplica.quantidade = this.Quantidade;
                ProdutoAplica.preco = this.Preco;
                ProdutoAplica.id_aplicacao = this.Id_aplicacao;
                ProdutoAplica.id_produto = this.Id_Produto;


                Banco.tblprodutosaplicados.InsertOnSubmit(ProdutoAplica);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        
        }
    }
}
