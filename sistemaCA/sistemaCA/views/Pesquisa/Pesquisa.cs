using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaCA.views.FormPesquisa
{
    class Pesquisa
    {
        public DataClasses1DataContext Banco { get; set; }
        public int ID{get;set;}
        
        public Pesquisa()
        {
            Banco = new DataClasses1DataContext();
            
        }

        public void PesquisarFuncionario(string Pesquisa,DataGridView dgw)
        {
            var pesqui = from func in Banco.tblfuncionarios
                         where func.nome.Contains(Pesquisa)
                         select new
                             {
                                 idfunc = func.id_funcionario,
                                 nome = func.nome,
                                 sobrenome = func.sobrenome

                             };


            dgw.DataSource = pesqui;
            

        }
        public void ListaFuncionario(DataGridView dgw)
        {
            var pesqui = from func in Banco.tblfuncionarios
                         select new
                         {
                             idfunc = func.id_funcionario,
                             nome = func.nome,
                             sobrenome = func.sobrenome
                         };

            dgw.DataSource = pesqui;
                                 
        }







    }




    class FormPesquisaIDtalhao : FormPesquisa
    {
        public int IDtalhao { get; set; }

        public FormPesquisaIDtalhao():base()
        {
           


        }
       
    
    
    }
}
