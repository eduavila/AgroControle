using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaCA.views.Pesquisa
{
    class Pesquisa
    {
        public DataClasses1DataContext Banco { get; set; }
        public int ID{get;set;}
        
        public Pesquisa()
        {
            Banco = new DataClasses1DataContext();
            
        }
        // pesquisando funcionairo no banco de dados
        public void PesquisarFuncionario(string Pesquisa,DataGridView dgw)
        {
            var pesqui = from func in Banco.tblfuncionarios
                         where func.nome.Contains(Pesquisa)
                         select new
                             {
                                 id = func.id_funcionario,
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
                             id = func.id_funcionario,
                             nome = func.nome,
                             sobrenome = func.sobrenome
                         };

            dgw.DataSource = pesqui;
                                 
        }







    }















    // classe  pesquisar talhao  herda da clase form pesquisa

    class FormPesquisaIDtalhao : FormPesquisa
    {
        // propriedades
       

        public void PesquisaTalhao(string pesquisa,DataGridView dgw)
        {
            var pesqui = from talhao in base.Banco.tbltalhaos
                         where talhao.descricao.Contains(pesquisa)
                         select new
                         {
                             id = talhao.id_talhao,
                             descricao = talhao.descricao,
                             tamanho = talhao.tamanho
                         };

            dgw.DataSource = pesqui;
        }

        
        public void Listatalhao(DataGridView dgw)
        {
            var pesqui = from talhao in base.Banco.tbltalhaos
                         select new
                         {
                             id = talhao.id_talhao,
                             descricao = talhao.descricao,
                             tamanho = talhao.tamanho
                         };

            dgw.DataSource = pesqui;
        }

        //  metodos sobre escrevendo os outro da classe pai
        public override void PreecherGrid()
        {
            Listatalhao(dgw_pesquisa);
        }

        public override void Pesquisar(string pesquisa, DataGridView dgw)
        {
            PesquisaTalhao(pesquisa, dgw);
        }
        public override void AlterarHeadGrid()
        {
            dgw_pesquisa.Columns["id"].HeaderText = "ID Talhão";
            dgw_pesquisa.Columns["descricao"].HeaderText = "Descrição";
            dgw_pesquisa.Columns["tamanho"].HeaderText = "Área Hectares";
        }
        
       
    }

    // criando classe pesquisa safra


    class FormPesquisaSafra : FormPesquisa
    {
        // propriedades


        public void PesquisaSafra(string pesquisa, DataGridView dgw)
        {
            var pesqui = from safra in base.Banco.tblsafras
                         where safra.descricao.Contains(pesquisa)
                         select new
                         {
                             id = safra.id_safra,
                             descricao = safra.descricao,
                             datainicio = safra.dataincio
                         };

            dgw.DataSource = pesqui;
        }


        public void ListaSafra(DataGridView dgw)
        {
            var pesqui = from safra in base.Banco.tblsafras
                         select new
                         {
                             id = safra.id_safra,
                             descricao = safra.descricao,
                             datainicio = safra.dataincio
                         };

            dgw.DataSource = pesqui;
        }

        //  metodos sobre escrevendo os outro da classe pai
        public override void PreecherGrid()
        {
            ListaSafra(dgw_pesquisa);
        }

        public override void Pesquisar(string pesquisa, DataGridView dgw)
        {
            PesquisaSafra(pesquisa, dgw);
        }
        public override void AlterarHeadGrid()
        {
            dgw_pesquisa.Columns["id"].HeaderText = "ID Safra";
            dgw_pesquisa.Columns["descricao"].HeaderText = "Descrição";
            dgw_pesquisa.Columns["datainicio"].HeaderText = "Data Início";
        }


    }







    // pesqusa maquinario


    class FormPesquisaMaquinas : FormPesquisa
    {
        // propriedades


        public void PesquisaMaquinas(string pesquisa, DataGridView dgw)
        {
            var pesqui = from maquinas in base.Banco.tblbens
                         where maquinas.descricao.Contains(pesquisa)
                         select new
                         {
                             id = maquinas.id_ben,
                             descricao = maquinas.descricao,
                             placa = maquinas.placa
                         };

            dgw.DataSource = pesqui;
        }


        public void ListaMaquinas(DataGridView dgw)
        {
            var pesqui = from maquinas in base.Banco.tblbens
                         select new
                         {
                             id = maquinas.id_ben,
                             descricao = maquinas.descricao,
                             placa = maquinas.placa
                         };

            dgw.DataSource = pesqui;
        }

        //  metodos sobre escrevendo os outro da classe pai
        public override void PreecherGrid()
        {
            ListaMaquinas(dgw_pesquisa);
        }

        public override void Pesquisar(string pesquisa, DataGridView dgw)
        {
            PesquisaMaquinas(pesquisa, dgw);
        }
        public override void AlterarHeadGrid()
        {
            dgw_pesquisa.Columns["id"].HeaderText = "ID Máquina";
            dgw_pesquisa.Columns["descricao"].HeaderText = "Descrição";
            dgw_pesquisa.Columns["placa"].HeaderText = "Placa";
        }


    }

}
