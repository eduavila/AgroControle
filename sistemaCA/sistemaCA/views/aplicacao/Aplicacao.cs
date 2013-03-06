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



      
       
      
    }
}
