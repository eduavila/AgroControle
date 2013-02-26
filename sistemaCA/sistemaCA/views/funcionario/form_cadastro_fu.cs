using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.views.funcionario;


namespace sistemaCA.views.funcionario
{
    public partial class form_cadastro_fu : Form
    {
        public tblfuncionario Func { get; set; }
        public DataClasses1DataContext Banco { get; set; }

        // contrutor para criar novo funcionario


        public form_cadastro_fu()
        {
            InitializeComponent();

            this.Banco = new DataClasses1DataContext();
           this.Func = new tblfuncionario();
           

        }

        // contrutor para alteração
        // parametro  nome banco e objeto
        public form_cadastro_fu(tblfuncionario funcionario,DataClasses1DataContext db)
        {
            // incializando componetes do forms
            InitializeComponent();
            

            
            this.Func = funcionario;
            this.Banco = db;
            // mandando dado para forms

            tb_nome.Text = Func.nome;
            tb_sobrenome.Text = Func.sobrenome;
            tb_cpf.Text = Func.cpf;
            tb_ctps.Text = Func.ctps;
            tb_rg.Text = Func.rg;
            tb_endereco.Text = Func.endere;
            tb_bairro.Text = Func.bairro;
            tb_funcao.Text = Func.funcao;
            dtp_admisao.Value = DateTime.Parse(Func.data_admissao.ToString());
            tb_renumeracao.Text = Func.renumeracao_mensal.ToString();
            tb_email.Text = Func.email;

            tb_telefone.Text = Func.telefone;

            tb_celular.Text = Func.celular;

            tb_obs.Text = Func.obs;







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

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {

                // criar novo objeto funcionario
                DataClasses1DataContext db = new DataClasses1DataContext();

                Func.nome = tb_nome.Text;
                Func.sobrenome = tb_sobrenome.Text;
                Func.cpf = tb_cpf.Text;
                Func.ctps = tb_ctps.Text;
                Func.rg = tb_rg.Text;
                Func.endere = tb_endereco.Text;
                Func.bairro = tb_bairro.Text;
                Func.funcao = tb_funcao.Text;
                Func.data_admissao = dtp_admisao.Value;
                Func.renumeracao_mensal = float.Parse(tb_renumeracao.Text);
                Func.email = tb_email.Text;
                Func.telefone = tb_telefone.Text;
                Func.celular = tb_celular.Text;
                Func.obs = tb_obs.Text;

                // add o objeto func ao bando de dados.
                Banco.tblfuncionarios.InsertOnSubmit(Func);
                Banco.SubmitChanges();



                tb_nome.Text = "";
                tb_cpf.Text = "";
                tb_rg.Text = "";
                tb_ctps.Text = "";
                tb_endereco.Text = "";
                tb_bairro.Text = "";
              
                tb_funcao.Text = "";
                tb_renumeracao.Text = "";
                tb_email.Text = "";
                tb_telefone.Text = "";
                tb_celular.Text = "";
                tb_obs.Text = "";




                MessageBox.Show("Funcionario Foi Cadastrado com Sucesso");
                

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

        private void form_cadastro_fu_Shown(object sender, EventArgs e)
        {

            // colocando componetes desativados
            tb_nome.Enabled = false;
            tb_sobrenome.Enabled = false;
            tb_cpf.Enabled = false;
            tb_ctps.Enabled = false;
            tb_rg.Enabled = false;
            tb_endereco.Enabled = false;
            tb_bairro.Enabled = false;
            tb_funcao.Enabled = false;
            dtp_admisao.Enabled = false;
            tb_renumeracao.Enabled = false;
            tb_email.Enabled = false;
            tb_telefone.Enabled = false;
            tb_celular.Enabled = false;
            tb_obs.Enabled = false;
        }
    }
}
