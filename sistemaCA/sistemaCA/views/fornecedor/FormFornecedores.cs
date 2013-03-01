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
    public partial class FormFornecedores : Form
    {
        public FormFornecedores()
        {
            InitializeComponent();
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            Fornecedores fornecedor = new Fornecedores();
            fornecedor.ListarFornecedores(dgw_Fornecedores);

            // alterando titulo da colunas
            dgw_Fornecedores.Columns["id_fornecedor"].HeaderText = "ID";
            dgw_Fornecedores.Columns["nomefatasia"].HeaderText = "Nome Fantasia";
            dgw_Fornecedores.Columns["razaosocial"].HeaderText = "Razão Social";
            dgw_Fornecedores.Columns["cpf"].HeaderText = "CPF";
            dgw_Fornecedores.Columns["CNPJ"].HeaderText = "CNPJ";
            dgw_Fornecedores.Columns["ie"].HeaderText = "Inscrição Estadual";
            dgw_Fornecedores.Columns["endereco"].HeaderText = "Endereço";
            dgw_Fornecedores.Columns["cidade"].HeaderText = "Cidade";
            dgw_Fornecedores.Columns["fone"].HeaderText = "Telefone";
            dgw_Fornecedores.Columns["email"].HeaderText = "E-Mail";
            dgw_Fornecedores.Columns["obs"].HeaderText = "Observação";


            // alterado posição da coluna no data grid

            dgw_Fornecedores.Columns["id_fornecedor"].DisplayIndex = 0;
            dgw_Fornecedores.Columns["nomefatasia"].DisplayIndex = 1;
            dgw_Fornecedores.Columns["razaosocial"].DisplayIndex = 2;
            dgw_Fornecedores.Columns["cpf"].DisplayIndex = 3;
            dgw_Fornecedores.Columns["CNPJ"].DisplayIndex = 4;
            dgw_Fornecedores.Columns["ie"].DisplayIndex = 5;
            dgw_Fornecedores.Columns["endereco"].DisplayIndex = 6;
            dgw_Fornecedores.Columns["cidade"].DisplayIndex = 7;
            dgw_Fornecedores.Columns["fone"].DisplayIndex = 8;
            dgw_Fornecedores.Columns["email"].DisplayIndex = 9;
            dgw_Fornecedores.Columns["obs"].DisplayIndex = 10;

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCasdatroFornecedor cadastro = new FormCasdatroFornecedor();
            cadastro.ShowDialog();


            // atualizando data grid
            Fornecedores fornecedor = new Fornecedores();
            fornecedor.ListarFornecedores(dgw_Fornecedores);
        }
    }
}
