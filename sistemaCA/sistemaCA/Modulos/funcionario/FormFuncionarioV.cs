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
    public partial class FormFuncionarioV : Form
    {
        public FormFuncionarioV()
        {
            InitializeComponent();
        }

        public FormFuncionarioV(int id)
        {
            // incializando componetes do forms
            InitializeComponent();



            
            // mandando dado para forms

            Funcionarios Func = new Funcionarios();
            Func.Visualizar(id);
            tb_id_funcionario.Text = Func.IDFuncionario.ToString();
            tb_nome.Text = Func.Nome;
            tb_sobrenome.Text = Func.Sobrenome;
            tb_ctps.Text = Func.Ctps;
            tb_rg.Text = Func.Rg;
            cb_sexo.Text = Func.Sexo;
            tb_endereco.Text = Func.Endere;
            tb_bairro.Text = Func.Bairro;
            tb_funcao.Text = Func.Funcao;
            dtp_admisao.Value = DateTime.Parse(Func.DataAdmisao.ToString());
            tb_renumeracao.Text = Func.RenumeracaoMensal.ToString();
            tb_email.Text = Func.Email;
            tb_cpf.Text = Func.Cpf;
            tb_telefone.Text = Func.Telefone;

            tb_celular.Text = Func.Celular;

            tb_obs.Text = Func.Obs;



            // colocando componetes desativados
            tb_id_funcionario.Enabled = false;
            tb_nome.Enabled = false;
            tb_sobrenome.Enabled = false;
            tb_cpf.Enabled = false;
            tb_ctps.Enabled = false;
            tb_rg.Enabled = false;
            tb_endereco.Enabled = false;
            cb_sexo.Enabled = false;
            tb_bairro.Enabled = false;
            tb_funcao.Enabled = false;
            dtp_admisao.Enabled = false;
            tb_renumeracao.Enabled = false;
            tb_email.Enabled = false;
            tb_telefone.Enabled = false;
            tb_celular.Enabled = false;
            tb_obs.Enabled = false;

            btn_salvar.Visible = false;
        
        
        }


        private void FormFuncionarioV_Load(object sender, EventArgs e)
        {

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            // habilitando componetes para alterações
            var msg = MessageBox.Show("Deseja alterar registros?", "Alterar Registro", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == msg)
            {
                tb_nome.Enabled = true;
                tb_sobrenome.Enabled = true;
                tb_cpf.Enabled = true;
                tb_ctps.Enabled = true;
                tb_rg.Enabled = true;
                tb_endereco.Enabled = true;
                tb_bairro.Enabled = true;
                tb_funcao.Enabled = true;
                dtp_admisao.Enabled = true;
                tb_renumeracao.Enabled = true;
                tb_email.Enabled = true;
                tb_telefone.Enabled = true;
                tb_celular.Enabled = true;
                tb_obs.Enabled = true;
                cb_sexo.Enabled = true;

                btn_salvar.Visible = true;
                
            }

            //------------------------------
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionarios funcio = new Funcionarios();
                funcio.IDFuncionario = int.Parse(tb_id_funcionario.Text);
                funcio.Nome = tb_nome.Text;
                funcio.Sobrenome = tb_sobrenome.Text;
                funcio.Endere = tb_endereco.Text;
                funcio.Funcao = tb_funcao.Text;
                funcio.Cpf = tb_cpf.Text;
                funcio.Ctps = tb_ctps.Text;
                funcio.Rg = tb_rg.Text;
                funcio.Bairro = tb_bairro.Text;
                funcio.DataAdmisao = DateTime.Parse(dtp_admisao.Text);
                funcio.RenumeracaoMensal = float.Parse(tb_renumeracao.Text);
                funcio.Email = tb_email.Text;
                funcio.Telefone = tb_telefone.Text;
                funcio.Celular = tb_celular.Text;
                funcio.Obs = tb_obs.Text;

                funcio.AlterarFuncionario();

                MessageBox.Show("Registro Alterado com Sucesso!");
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza de quer excluir o Registro Selecionado ?", "Excluir Registro", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                Funcionarios funcio = new Funcionarios();
                funcio.DeletarFuncionario(int.Parse(tb_id_funcionario.Text));
                this.Close();

            }
            
        }
    }
}
