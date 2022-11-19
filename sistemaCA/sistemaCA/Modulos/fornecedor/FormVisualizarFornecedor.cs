using System;
using System.Windows.Forms;

namespace sistemaCA.views.fornecedor
{
    public partial class FormVisualizarFornecedor : Form
    {
        public FormVisualizarFornecedor()
        {
            InitializeComponent();
        }
        public FormVisualizarFornecedor(int idFornecedor)
        {
            InitializeComponent();



            // criando buscando o fornecedor selecionado


            Fornecedores fornecedor = new Fornecedores();

            fornecedor.VisualizarFornecedor(idFornecedor);


            tb_idfornecedor.Text = fornecedor.Id_fornecedor.ToString();
            tb_nomeFantasia.Text = fornecedor.NomeFatasia;
            tb_razaosocial.Text = fornecedor.RazaoSocial;
            mtb_cpf.Text = fornecedor.Cpf;
            mtb_cnpj.Text = fornecedor.Cnpj;
            tb_endereco.Text = fornecedor.Endereco;
            tb_cidade.Text = fornecedor.Cidade;
            mtb_telefone.Text = fornecedor.Fone;
            mtb_email.Text = fornecedor.Email;
            mtb_ie.Text = fornecedor.IE;
            tb_obs.Text = fornecedor.Obs;




            // desabilitando componetes


            tb_idfornecedor.Enabled = false;
            tb_nomeFantasia.Enabled = false;
            tb_razaosocial.Enabled = false;
            mtb_cpf.Enabled = false;
            mtb_cnpj.Enabled = false;
            tb_endereco.Enabled = false;
            tb_cidade.Enabled = false;
            mtb_telefone.Enabled = false;
            mtb_email.Enabled = false;
            mtb_ie.Enabled = false;
            tb_obs.Enabled = false;

            btn_salvar.Visible = false;

        }

        private void FormVisualizarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // criando buscando o fornecedor selecionado
            Fornecedores fornecedor = new Fornecedores();

            fornecedor.Id_fornecedor = int.Parse(tb_idfornecedor.Text);
            fornecedor.NomeFatasia = tb_nomeFantasia.Text;
            fornecedor.RazaoSocial = tb_razaosocial.Text;
            fornecedor.Cpf = mtb_cpf.Text;
            fornecedor.Cnpj = mtb_cnpj.Text;
            fornecedor.Endereco = tb_endereco.Text;
            fornecedor.Cidade = tb_cidade.Text;
            fornecedor.Fone = mtb_telefone.Text;
            fornecedor.Email = mtb_email.Text;
            fornecedor.IE = mtb_ie.Text;
            fornecedor.Obs = tb_obs.Text;

            fornecedor.AlterarFornecedor(fornecedor.Id_fornecedor);

            Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            tb_nomeFantasia.Enabled = true;
            tb_razaosocial.Enabled = true;
            mtb_cpf.Enabled = true;
            mtb_cnpj.Enabled = true;
            tb_endereco.Enabled = true;
            tb_cidade.Enabled = true;
            mtb_telefone.Enabled = true;
            mtb_email.Enabled = true;
            mtb_ie.Enabled = true;
            tb_obs.Enabled = true;

            btn_salvar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza de quer excluir o Registro Selecionado ?", "Excluir Registro", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                Fornecedores fornecedor = new Fornecedores();
                fornecedor.DeletarFornecedor(int.Parse(tb_idfornecedor.Text));
                Close();

            }
        }
    }
}
