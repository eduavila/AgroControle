using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaCA.views.fornecedor
{
    class Fornecedores
    {

        // propriedades

        public DataClasses1DataContext Banco { get; set; }
        public tblfornecedor Fornecedor { get; set; }


        // pridedade forncedor
        public int Id_fornecedor { get; set; }
        public string NomeFatasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }
        public string IE { get; set; }
        // fim propriedade fornecedor


        // construtor padrao
        public Fornecedores()
        {
            Banco = new DataClasses1DataContext();
            Fornecedor = new tblfornecedor();
        }

        public void ListarFornecedores(DataGridView dgw)
        {

            var result = from fornecedor in Banco.tblfornecedors
                         select fornecedor;

            dgw.DataSource = result;
        
        }

        public void CadatraFornecededor()
        {
            try
            {
                Fornecedor.nomefatasia = this.NomeFatasia;
                Fornecedor.razaosocial = this.RazaoSocial;
                Fornecedor.cpf = this.Cpf;
                Fornecedor.cnpj = this.Cnpj;
                Fornecedor.cidade = this.Cidade;
                Fornecedor.endereco = this.Endereco;
                Fornecedor.email = this.Email;
                Fornecedor.fone = this.Fone;
                Fornecedor.obs = this.Obs;
                Fornecedor.ie = this.IE;
                this.Banco.tblfornecedors.InsertOnSubmit(Fornecedor);

                this.Banco.SubmitChanges();
                MessageBox.Show("Registro Cadastrado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
             
        }





        
    }
}
