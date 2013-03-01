using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.fornecedor
{
    public partial class FormCasdatroFornecedor : Form
    {
        public FormCasdatroFornecedor()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            // criando novo fornecedor

            Fornecedores fornecedor = new Fornecedores();

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

            fornecedor.CadatraFornecededor();
            // fim de cadastro.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
