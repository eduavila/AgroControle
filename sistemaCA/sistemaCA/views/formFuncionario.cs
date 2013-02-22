using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views
{
    public partial class formFuncionario : Form
    {
        public formFuncionario()
        {
            InitializeComponent();
        }

        private void formFuncionario_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_admissaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // função cancela pra criar funcionario
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                tblfuncionario func = new tblfuncionario();


                func.nome = tb_nome.Text;
                func.cpf = tb_cpf.Text;
                func.rg = tb_rg.Text;
                func.endere = tb_endereco.Text;
                func.bairro = tb_bairro.Text;
                func.cidade = tb_cidade.Text;
                func.funcao = tb_funcao.Text;
                func.data_admissao = dtp_admisao.Value;


                func.renumeracao_mensal = float.Parse(tb_renumeracao.Text);
                func.email = tb_email.Text;
                func.telefone = tb_telefone.Text;



                db.tblfuncionarios.InsertOnSubmit(func);
                db.SubmitChanges();

                MessageBox.Show("Funcioanrio Foi Cadastrado com Sucesso");

            
            
            }
            catch
            {

                MessageBox.Show("Ocorreu um Erro ao Cadastrar Funcionario.");
            
            }
            


           // limpando os 
            

           



                 




        }

        private void Exception()
        {
            throw new NotImplementedException();
        }
    }
}
