using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA;

namespace sistemaCA.views.safra
{
    class Safra
    {
        public DataClasses1DataContext Banco { get; set; }
        
        // propriedades do banco de ddados
        public int IdSafra { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFechamento { get; set; }
        public string Obs { get; set; }
        public string status { get; set; }
        public int IdCultura { get; set; }


        public Safra()
        {
            Banco = new DataClasses1DataContext();

            
        
        }


        public void ListarSafra(DataGridView dgw)
        {
            dgw.DataSource = Banco.psListarSafra();
       
        }


        public void Cadastrar()
        {
            try
            {
                Banco.spCadastrarSafra(this.Descricao, this.status, this.Obs, this.DataInicio, this.IdCultura, this.DataFechamento);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        public void VisualizarSafra(int id_safra)
        {
            try
            {

                tblsafra safra = new tblsafra();

                var pesquisa = from saf in Banco.tblsafras
                               where saf.id_safra == id_safra
                               select saf;


                safra = pesquisa.Single();





                this.IdSafra = safra.id_safra;
                this.Descricao = safra.descricao;
                this.DataInicio = safra.dataincio;
                this.DataFechamento =DateTime.Parse(safra.datafechamento.ToString());
                this.Obs = safra.obs;
                this.status = safra.status;
                this.IdCultura = Convert.ToInt32(safra.id_cultura);

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                     
            
            }
                           
        
        
        }


        public void AtualizarSafra()
        {
            try
            {

                this.Banco.spAtualizarSafra(this.IdSafra, this.Descricao, this.status, this.Obs, this.DataInicio, this.IdCultura, this.DataFechamento);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            
            }
        
        }





        public void DeletarSafra(int id_safra)
        {
            try
            {

                Banco.spDeletarSafra(id_safra);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }


// metodo para trabalha com datetime
        

    


    
    }
}
