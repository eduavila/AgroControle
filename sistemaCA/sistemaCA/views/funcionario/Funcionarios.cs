using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;



namespace sistemaCA.views.funcionario
{
    class Funcionarios
    {

        //public DataClasses1DataContext Banco { get; set; }


        public void tblfuncionario()
        {

            


        }


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


    }


}
