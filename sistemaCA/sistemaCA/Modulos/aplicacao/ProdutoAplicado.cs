using System;
using System.Linq;
using System.Windows.Forms;

namespace sistemaCA.Modulos.aplicacao
{
    public class ProdutoAplicado : ClasseBase
    {
        public tblproduto Produto { get; set; }
        public tblprodutosaplicado ProdutoAplica { get; set; }

        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public float Total { get; set; }
        public int Id_Produto { get; set; }
        public int Id_Fornecedor { get; set; }
        public int Id_aplicacao { get; set; }

        public ProdutoAplicado() : base(new DataClasses1DataContext())
        {
            Produto = new tblproduto();
        }

        // listando produto dentro do datagrid.
        public void ListandoTodoProduto(int idaplicacao, DataGridView dgw)
        {
            var result = from produtoaplica in Banco.tblprodutosaplicados
                         join produto in Banco.tblprodutos on produtoaplica.id_produto equals produto.id_produto
                         where produtoaplica.id_aplicacao == idaplicacao
                         select new
                         {
                             idproduto = produto.id_produto,
                             produto = produto.descricao,
                             quantidade = produtoaplica.quantidade,
                             valor = produtoaplica.preco

                         };



            var pro = from produ in Banco.tblprodutos select produ.descricao;

            dgw.AutoGenerateColumns = false;


            DataGridViewComboBoxColumn cb_produto = new DataGridViewComboBoxColumn();
            cb_produto.DataPropertyName = "produto";
            cb_produto.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            cb_produto.DisplayMember = "produto";
            cb_produto.ValueMember = "idproduto";
            cb_produto.DataSource = result.ToList();
            cb_produto.HeaderText = "Produto";

            DataGridViewTextBoxColumn tb_valor = new DataGridViewTextBoxColumn();
            tb_valor.DataPropertyName = "valor";
            tb_valor.HeaderText = "Valor";

            DataGridViewTextBoxColumn tb_quantidade = new DataGridViewTextBoxColumn();
            tb_quantidade.DataPropertyName = "quantidade";
            tb_quantidade.HeaderText = "Quantidade";


            dgw.Columns.Add(cb_produto);
            dgw.Columns.Add(tb_quantidade);
            dgw.Columns.Add(tb_valor);

            dgw.DataSource = result;




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


                for (int linha = 0; (dgw.RowCount - 1) > linha; linha++)
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
                MessageBox.Show("Erro ao Cadastra Produto Aplicado :" + erro.Message);
            }



        }


        public void DeletandoTodoProduto(int idaplicacao)
        {
            try
            {
                var result = from produtos in Banco.tblprodutosaplicados where produtos.id_aplicacao == idaplicacao select produtos;



                Banco.tblprodutosaplicados.DeleteAllOnSubmit(result);
                Banco.SubmitChanges();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }




    }
}
