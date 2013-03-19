using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.Modulos.ControleMaquinas
{

    // classe de Maquinas
    public class ControleRevisao
    {
        DataClasses1DataContext Banco { get; set; }
        tblrevisaofutura Revisao { get; set; }


        public int ID_Revisao { get; set; }
        public string Motivo { get; set;}
        public DateTime data_cadastro { get; set; }
        public DateTime data_revisao { get; set; }
        public string Status { get; set; }
        public int ID_Ben { get; set; }
        public int ID_Safra { get; set; }


        public ControleRevisao()
        { 
            Banco = new DataClasses1DataContext();
            Revisao = new tblrevisaofutura();
        
        }

        public void VisualizarRevisao(DataGridView dgw)
        {
            var result = from revisao in Banco.tblrevisaofuturas
                         join maquina in Banco.tblbens on revisao.id_ben equals maquina.id_ben
                         join safra in Banco.tblsafras on revisao.id_safra equals safra.id_safra
                         select new { 
                             id = revisao.id_revisao,
                             decricao = revisao.motivo,
                             data_cadastro = revisao.data_cadastro,
                             data_revisao = revisao.data_revisao,
                             safra = safra.descricao,
                             maquina= maquina.codigoControle,
                         };

            dgw.DataSource = result;
        
        }






        public void CadastroRevisao()
        {
            try
            {
                Revisao.motivo = this.Motivo;
                Revisao.data_cadastro = this.data_cadastro;
                Revisao.data_revisao = this.data_revisao;
                Revisao.status = this.Status;
                Revisao.id_ben = this.ID_Ben;
                Revisao.id_safra = this.ID_Safra;

                Banco.tblrevisaofuturas.InsertOnSubmit(Revisao);

                Banco.SubmitChanges();

                MessageBox.Show("Registro Cadastrado com Sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        
        }



        public void CadastraProdutoAplicado(DataGridView dgw)
        {
            try
            {


                for (int linha = 0; (dgw.RowCount - 1) > linha; linha++)
                {
                    tblitenrevisao Produto = new tblitenrevisao();
                    var result = dgw.Rows[linha].Cells["produto"].Value.ToString();
                    Produto.id_produtos = this.ProcurarProduto(result);
                    Produto.preco = float.Parse(dgw.Rows[linha].Cells["valor"].Value.ToString());
                    Produto.quantidade = int.Parse(dgw.Rows[linha].Cells["quantidade"].Value.ToString());
                    Produto.id_revisao = this.ProximoRegistro();
                    Banco.tblitenrevisaos.InsertOnSubmit(Produto);
                }
                Banco.SubmitChanges();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }



        }

        public void ListandoProduto(DataGridViewComboBoxColumn dgw)
        {
            var pro = from produ in Banco.tblprodutos select produ.descricao;
            dgw.DataSource = pro.ToList();

            
        }

        public int ProximoRegistro()
        {
            var aplica = from revisao in Banco.tblrevisaofuturas select revisao.id_revisao;

            int result = aplica.Max();

            return result;
        }



        // produrando produto pela descricao
        public int ProcurarProduto(string produ)
        {

            tblproduto Produto = new tblproduto();

            var result = from produto in Banco.tblprodutos
                         where produto.descricao == produ
                         select produto;

            Produto = result.Single();


            return Produto.id_produto;
        }



        public void VisualizarRevisaoDl(int idrevisao)
        {

            var result = from revisao in Banco.tblrevisaofuturas where revisao.id_revisao == idrevisao select revisao;

            
            Revisao = result.Single();

            this.ID_Revisao = Revisao.id_revisao;
            this.Motivo = Revisao.motivo;
            this.data_cadastro = Convert.ToDateTime(Revisao.data_cadastro);
            this.data_revisao = Convert.ToDateTime(Revisao.data_revisao);
            this.Status = Revisao.status;
            this.ID_Ben = Revisao.id_ben;
            this.ID_Safra = Revisao.id_safra;

        }

        public void visualiarItemRevisa(DataGridView dgw,int idrevisao)
        { 
            var result = from items in Banco.tblitenrevisaos 
                         join produto in Banco.tblprodutos on items.id_produtos equals produto.id_produto
                         
                         where items.id_revisao == idrevisao 
                         select new 
                         {
                            Produto = produto.descricao,
                            quantidade =items.quantidade,
                            valor = items.preco
                         };

            dgw.DataSource = result;
        
        }

    }
}
