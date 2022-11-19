using System;
using System.Linq;
using System.Windows.Forms;

namespace sistemaCA.views.fornecedor
{
    class Fornecedores : ClasseBase
    {

        // propriedades
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
        public Fornecedores() : base(new DataClasses1DataContext())
        {
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

        // lista somente o fornecedor selecionado
        public void VisualizarFornecedor(int idfornecedor)
        {

            var pesqui = from forne in Banco.tblfornecedors
                         where forne.id_fornecedor == idfornecedor
                         select forne;

            Fornecedor = pesqui.Single();

            this.Id_fornecedor = Fornecedor.id_fornecedor;
            this.NomeFatasia = Fornecedor.nomefatasia;
            this.RazaoSocial = Fornecedor.razaosocial;
            this.Cpf = Fornecedor.cpf;
            this.Cnpj = Fornecedor.cnpj;
            this.Cidade = Fornecedor.cidade;
            this.Endereco = Fornecedor.endereco;
            this.Email = Fornecedor.email;
            this.Fone = Fornecedor.fone;
            this.Obs = Fornecedor.obs;
            this.IE = Fornecedor.ie;

        }


        public void AlterarFornecedor(int idfornecedor)
        {
            try
            {
                var pesqui = from forne in Banco.tblfornecedors
                             where forne.id_fornecedor == idfornecedor
                             select forne;

                Fornecedor = pesqui.Single();

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

                Banco.SubmitChanges();

                MessageBox.Show("Registro Alterado com Sucesso.");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }


        public void DeletarFornecedor(int id_fornecedor)
        {
            try
            {
                var pesqui = from fornecedor in Banco.tblfornecedors
                             where fornecedor.id_fornecedor == id_fornecedor
                             select fornecedor;

                Fornecedor = pesqui.Single();

                Banco.tblfornecedors.DeleteOnSubmit(Fornecedor);
                Banco.SubmitChanges();
                MessageBox.Show("Registro Excluido com Sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }





    }
}
