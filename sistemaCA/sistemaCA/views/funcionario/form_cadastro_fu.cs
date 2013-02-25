using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.funcionario
{
    public partial class form_cadastro_fu : Form
    {
        public form_cadastro_fu()
        {
            InitializeComponent();
        }

        private void form_cadastro_fu_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tb_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                tblfuncionario func = new tblfuncionario();


                func.nome = tb_nome.Text;
                func.sobrenome = tb_sobrenome.Text;
                func.cpf = tb_cpf.Text;
                func.ctps = tb_ctps.Text;
                func.rg = tb_rg.Text;
                func.endere = tb_endereco.Text;
                func.bairro = tb_bairro.Text;
                func.cidade = tb_cidade.Text;
                func.funcao = tb_funcao.Text;
                func.data_admissao = dtp_admisao.Value;
                func.renumeracao_mensal = float.Parse(tb_renumeracao.Text);
                func.email = tb_email.Text;
                func.telefone = tb_telefone.Text;
                func.celular = tb_celular.Text;
                func.obs = tb_obs.Text;

                // add o objeto func ao bando de dados.
                db.tblfuncionarios.InsertOnSubmit(func);
                db.SubmitChanges();



                tb_nome.Text = "";
                tb_cpf.Text = "";
                tb_rg.Text = "";
                tb_ctps.Text = "";
                tb_endereco.Text = "";
                tb_bairro.Text = "";
                tb_cidade.Text = "";
                tb_funcao.Text = "";
                tb_renumeracao.Text = "";
                tb_email.Text = "";
                tb_telefone.Text = "";
                tb_celular.Text = "";
                tb_obs.Text = "";




                MessageBox.Show("Funcioanrio Foi Cadastrado com Sucesso");



            }
            catch
            {

                MessageBox.Show("Ocorreu um Erro ao Cadastrar Funcionario.");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
