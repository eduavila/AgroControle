using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaCA.views.aplicacao
{
    class Aplicacao
    {
        public DataClasses1DataContext Banco { get; set; }
        public tblaplicacao Aplica { get; set; }
        public string Descricao { get; set; }
        public int Id_aplicacao { get; set; }
        public DateTime DataAplicacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Status { get; set; }
        public float AreaAplicada { get; set; }
        public int ID_talhao { get; set; }
        public int ID_Safra { get; set; }
        public int ID_Ben { get; set; }
        public int ID_Funcionario { get; set;}
        public string Obs { get; set; }
        public int Id_ProdutoAplicado { get; set; }



        public Aplicacao()
        {
            Banco = new DataClasses1DataContext();
            Aplica = new tblaplicacao();
        }



        public void ListarAplicacoes(DataGridView dgw)
        {
            try
            {
                var pesqui = from aplica in Banco.tblaplicacaos
                             select new
                             {
                                 id_aplicacao = aplica.id_aplicacao,
                                 status = aplica.status,
                                 descricao = aplica.descricao,
                                 datacadastro = aplica.data_cadastro,
                                 dataaplicacao = aplica.data_aplicacao,
                                 id_maquina = aplica.id_ben,
                                 id_safra = aplica.id_safra,
                                 id_func = aplica.id_funcionario,
                                 id_talhao = aplica.id_talhao,
                                 obs = aplica.obs
                                 
                             };
                dgw.DataSource = pesqui;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void VisualizarAplicacao(int id_aplica)
        {
            try
            {

                var pesqui = from aplicacao in Banco.tblaplicacaos
                             where aplicacao.id_aplicacao == id_aplica
                             select aplicacao;

                Aplica = pesqui.Single();

                this.Id_aplicacao = Aplica.id_aplicacao;
                this.Descricao = Aplica.descricao;
                this.DataCadastro = Aplica.data_cadastro;
                this.DataAplicacao = Convert.ToDateTime(Aplica.data_aplicacao);
                this.ID_Ben = Aplica.id_ben;
                this.ID_Funcionario = Aplica.id_funcionario;
                this.ID_talhao = Aplica.id_talhao;
                this.ID_Safra = Aplica.id_safra;
                this.Obs = Aplica.obs;
                this.AreaAplicada = float.Parse(Aplica.areaaplicada.ToString());
                this.Status = Aplica.status;
                



            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        
        
        
        }







        public void AlterarAplicacao(int id_aplica)
        {
            try
            {
                var pesqui = from aplicacao in Banco.tblaplicacaos
                             where aplicacao.id_aplicacao == id_aplica
                             select aplicacao;

                Aplica = pesqui.Single();

                Aplica.descricao = this.Descricao;
                Aplica.data_aplicacao = this.DataAplicacao;
                Aplica.id_ben = this.ID_Ben;
                Aplica.id_funcionario = this.ID_Funcionario;
                Aplica.id_talhao = this.ID_talhao;
                Aplica.id_safra = this.ID_Safra;
                Aplica.obs = this.Obs;
                Aplica.areaaplicada = this.AreaAplicada;

                Banco.SubmitChanges();

                MessageBox.Show("Registro Alterado com Sucesso.");


            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        
        
        }



        //· cadastro de aplicações
        public void CadastraAplicacao()
        {
            try
            {
                Aplica.data_aplicacao = this.DataAplicacao;
                Aplica.status = this.Status;
                Aplica.areaaplicada = this.AreaAplicada;
                Aplica.data_cadastro = this.DataCadastro;
                Aplica.id_talhao = this.ID_talhao;
                Aplica.id_safra = this.ID_Safra;
                Aplica.id_funcionario = this.ID_Funcionario;
                Aplica.id_ben = this.ID_Ben;
                Aplica.obs = this.Obs;
                Aplica.descricao = this.Descricao;

                Banco.tblaplicacaos.InsertOnSubmit(Aplica);
                Banco.SubmitChanges();
                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);            
            }
        
        }


        public void DeletarAplicacao(int idaplica)
        {
            try
            {
                var pesqui = from aplicacao in Banco.tblaplicacaos
                             where aplicacao.id_aplicacao == idaplica
                             select aplicacao;

                Aplica = pesqui.Single();

                Banco.tblaplicacaos.DeleteOnSubmit(Aplica);

                Banco.SubmitChanges();
                MessageBox.Show("Registro Excluido com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        
        }
       
      
    }
}
