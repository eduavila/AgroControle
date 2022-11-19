using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace sistemaCA.views.funcionario
{
    class Funcionarios : ClasseBase
    {
        public int IDFuncionario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Ctps { get; set; }
        public string Endere { get; set; }
        public string Bairro { get; set; }
        public string Funcao { get; set; }
        public DateTime DataAdmisao { get; set; }
        public float RenumeracaoMensal { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Obs { get; set; }
        public string Sexo { get; set; }

        public Funcionarios() : base(new DataClasses1DataContext())
        { }


        /// <summary>
        /// Função para preecher grid funcionario
        /// </summary>
        /// <param name="dgw">obj Datagrid para se preechido</param>
        /// <param name="funcionario">obj funcionario a ser atualizado</param>

        public static void PreecherGridview(DataGridView dgw)
        {

            DataClasses1DataContext Banco = new DataClasses1DataContext();



            var func = from Funcionario in Banco.tblfuncionarios
                       select Funcionario;



            dgw.DataSource = func;

            //dgw.Columns["id_funcionario"].HeaderText = "ID";
            //dgw.Columns["nome"].HeaderText = "Nome ";
            //dgw.Columns["sobrenome"].HeaderText = "Sobrenome";
            //dgw.Columns["cpf"].HeaderText = "CPF";
            //dgw.Columns["rg"].HeaderText = "RG";
            //dgw.Columns["ctps"].HeaderText = "CTPS";
            //dgw.Columns["data_admissao"].HeaderText = "Data Admissão";
            //dgw.Columns["renumeracao_mensal"].HeaderText = "Renumeração Mensal";
            //dgw.Columns["funcao"].HeaderText = "Função";
            //dgw.Columns["endere"].HeaderText = "Endereço";
            //dgw.Columns["bairro"].HeaderText = "Bairro";
            //dgw.Columns["email"].HeaderText = "E-Mail";
            //dgw.Columns["obs"].HeaderText = "Observação";
            //dgw.Columns["sexo"].HeaderText = "Sexo";
        }

        public void Pesquisar(string pesquisa, string entidade, DataGridView dgw)
        {

        }

        private DataClasses1DataContext DataClasses1DataContext()
        {
            throw new NotImplementedException();
        }



        public void alterar(tblfuncionario func)
        {
            //form_cadastro_fu FormCada = new form_cadastro_fu();

            //try
            //{






            //    FormCada.tb_nome.Text = "";
            //    FormCada.tb_cpf.Text = "";
            //    FormCada.tb_rg.Text = "";
            //    FormCada.tb_ctps.Text = "";
            //    FormCada.tb_endereco.Text = "";
            //    FormCada.tb_bairro.Text = "";

            //    FormCada.tb_funcao.Text = "";
            //    FormCada.tb_renumeracao.Text = "";
            //    FormCada.tb_email.Text = "";
            //    FormCada.tb_telefone.Text = "";
            //    FormCada.tb_celular.Text = "";
            //    FormCada.tb_obs.Text = "";




            //    MessageBox.Show("Funcioanrio Foi Cadastrado com Sucesso");


            //}
            //catch
            //{

            //    MessageBox.Show("Ocorreu um Erro ao Cadastrar Funcionario.");

            //}



        }

        public void Visualizar(int func)
        {
            tblfuncionario funcionario = new tblfuncionario();

            // criar pesquisa  no banco para encontrar registro selecionado
            var pesquisa = from Funcionario in this.Banco.tblfuncionarios
                           where Funcionario.id_funcionario == func
                           select Funcionario;


            funcionario = pesquisa.Single();


            this.IDFuncionario = funcionario.id_funcionario;
            this.Nome = funcionario.nome;
            this.Sobrenome = funcionario.sobrenome;
            this.Cpf = funcionario.cpf;
            this.Rg = funcionario.rg;
            this.Ctps = funcionario.ctps;
            this.RenumeracaoMensal = float.Parse(funcionario.renumeracao_mensal.ToString());
            this.DataAdmisao = DateTime.Parse(funcionario.data_admissao.ToString());
            this.Funcao = funcionario.funcao;
            this.Email = funcionario.email;
            this.Endere = funcionario.endere;
            this.Bairro = funcionario.bairro;
            this.Telefone = funcionario.telefone;
            this.Celular = funcionario.celular;
            this.Obs = funcionario.obs;
            this.Sexo = funcionario.sexo;
        }



        public void AlterarFuncionario()
        {
            try
            {

                Banco.spAlterarFuncionario(this.IDFuncionario, this.Nome, this.Funcao, this.Ctps, this.RenumeracaoMensal, this.Endere, this.Bairro, this.Telefone, this.Email, this.Rg, this.Cpf, this.Obs, this.Celular, this.Sobrenome, this.Sexo);



            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }



        public void DeletarFuncionario(int idfuncio)
        {
            try
            {

                Banco.spDeletarFuncionario(idfuncio);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        public void PesquisarFuncionarioId(int idfunc, DataGridView dgw)
        {
            try
            {
                if (idfunc != 0)
                {
                    dgw.DataSource = Banco.spPesquisaFunId(idfunc);

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        public void PequisarFuncionarioNome(string nome, DataGridView dgw)
        {

            dgw.DataSource = Banco.spPesquisaFunNome(nome);

        }


        public void PequisarFuncionarioCPF(string cpf, DataGridView dgw)
        {

            dgw.DataSource = Banco.spPesquisaFunCPF(cpf);

        }



    }


}