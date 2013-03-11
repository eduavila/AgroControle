using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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
            produto.Name = "produto";
            

            produto.DataSource = pro.ToList();

            dgw.Columns.Add(produto);
            
        }

        public int ProximoRegistro()
        {
            var aplica = from aplicacao in Banco.tblaplicacaos select aplicacao.id_aplicacao;

            int result = aplica.Max();

            return result;
        }


        




        // produrando produto pela descricao
        public int ProcurarProduto(string produ)
        {

            var result = from produto in Banco.tblprodutos
                         where produto.descricao == produ
                         select produto;

            Produto = result.Single(); 

        
             return Produto.id_produto;
        }

        


        public void CadastraProdutoAplicado(DataGridView dgw)
        {
            try
            {


            for(int linha= 0 ;(dgw.RowCount-1) > linha ;linha++)
            {
                tblprodutosaplicado Produto = new tblprodutosaplicado();
                var result = dgw.Rows[linha].Cells["produto"].Value.ToString();
                Produto.id_produto = this.ProcurarProduto(result);
                Produto.preco = float.Parse(dgw.Rows[linha].Cells["valor"].Value.ToString());
                Produto.quantidade = int.Parse(dgw.Rows[linha].Cells["quantidade"].Value.ToString());
                Produto.id_aplicacao = this.ProximoRegistro();
                Banco.tblprodutosaplicados.InsertOnSubmit(Produto);
            }
            Banco.SubmitChanges();

            
         }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastra Produto Aplicado :"+erro.Message);
            }


        
        }
    }
}
