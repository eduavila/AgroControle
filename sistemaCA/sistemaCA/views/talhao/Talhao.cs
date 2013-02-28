using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaCA.views.talhao
{
    class Talhao
    {
        public DataClasses1DataContext Banco { get; set; }    
        // atributos
        public int Id_talhao { get; set; }
        public string Descricao { get; set; }
        public string Localizacao { get; set; }
        public double tamanho { get; set; }
        public string Obs { get; set; }
        public string SitemaCutivo { get; set; }

        // metodo contrutor
        public Talhao()
        {
            this.Banco = new DataClasses1DataContext();     
        
        }

        public void ListarTalhao(DataGridView dgw)
        {

            try
            {
                var lista = from talhao in Banco.tbltalhaos select talhao;

                dgw.DataSource = lista;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        // metodo cadastra talhao tabalhando direto com ORM  para cadastro.

        public void CadastrarTalhao()
        {
            try
            {
                tbltalhao talhao = new tbltalhao();

                talhao.descricao = this.Descricao;
                talhao.localizacao = this.Localizacao;
                talhao.tamanho = this.tamanho;
                talhao.obs = this.Obs;
                talhao.sistemaCutivo = this.SitemaCutivo;


                this.Banco.tbltalhaos.InsertOnSubmit(talhao);

                this.Banco.SubmitChanges();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
         }


        public void Pesquisar(string pesquisa,DataGridView dgw)
        {
            try
            {
                var result = from talhao in Banco.tbltalhaos
                             where talhao.descricao.Contains(pesquisa)
                             select talhao;


                dgw.DataSource = result;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }



        public tbltalhao VisualizarTalhao(int idtalhao)
        {
              
            tbltalhao talhao;

            var result = from talha in Banco.tbltalhaos 
                         where talha.id_talhao == idtalhao select talha;

            talhao = result.Single();

            this.Id_talhao = talhao.id_talhao;
            this.Descricao = talhao.descricao;
            this.Localizacao = talhao.localizacao;
            this.Obs = talhao.obs;
            this.tamanho = Convert.ToDouble(talhao.tamanho);

            return talhao;
        
        }


        

        // altera usuario recebe parameto ID talhao

        public void AlterarTalhao(int idtalhao )
        {
            try
            {

                tbltalhao talhao;

                var result = from talha in Banco.tbltalhaos
                             where talha.id_talhao == idtalhao
                             select talha;

                talhao = result.Single();

                talhao.descricao = this.Descricao;
                talhao.obs = this.Obs;
                talhao.localizacao = this.Localizacao;
                talhao.sistemaCutivo = this.SitemaCutivo;
                talhao.tamanho = this.tamanho;


                
                Banco.SubmitChanges();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                
            }


          }

        public void DeletarTalhao(int idtalhao)
        {
            try
            {

                tbltalhao Talhao;

                var pesquisa = from talhao in Banco.tbltalhaos
                               where talhao.id_talhao == idtalhao
                               select talhao;

                Talhao = pesquisa.Single();

                Banco.tbltalhaos.DeleteOnSubmit(Talhao);
                Banco.SubmitChanges();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            
            }


        
        }




    }
}
