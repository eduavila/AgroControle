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
using sistemaCA;

namespace sistemaCA.views
{
    public partial class formFuncionario : Form
    {
        public formFuncionario()
        {
            InitializeComponent();
        }

        public void formFuncionario_Load(object sender, EventArgs e)
        {

            
            DataClasses1DataContext  db = new DataClasses1DataContext();
            var func = from funcionario in db.tblfuncionarios
                       select funcionario;

            dgw_funcionario.DataSource = func ;

            dgw_funcionario.Columns["id_funcionario"].HeaderText = "ID";
            dgw_funcionario.Columns["nome"].HeaderText = "Nome ";
            dgw_funcionario.Columns["sobrenome"].HeaderText = "Sobrenome";
            dgw_funcionario.Columns["cpf"].HeaderText = "CPF";
            dgw_funcionario.Columns["rg"].HeaderText = "RG";
            dgw_funcionario.Columns["ctps"].HeaderText = "CTPS";
            dgw_funcionario.Columns["data_admissao"].HeaderText = "Data Admissão";
            dgw_funcionario.Columns["renumeracao_mensal"].HeaderText = "Renumeração Mensal";
            dgw_funcionario.Columns["funcao"].HeaderText = "Função";
            dgw_funcionario.Columns["endere"].HeaderText = "Endereço";
            dgw_funcionario.Columns["bairro"].HeaderText = "Bairro";
            dgw_funcionario.Columns["email"].HeaderText = "E-Mail";
            dgw_funcionario.Columns["obs"].HeaderText = "Observação";
            dgw_funcionario.Columns["sexo"].HeaderText = "Sexo";
            // colocando nome nas coluna do datagrid

          

            
            
            
            
            
          

            

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Exception()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {

        
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formFuncionario_Shown(object sender, EventArgs e)
        {

        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
        
            // pega a rows selecinado no gridview

            int selecionado = dgw_funcionario.CurrentCell.RowIndex;

            int idfunc;

            idfunc = int.Parse(dgw_funcionario.Rows[selecionado].Cells["id_funcionario"].Value.ToString());

            FormFuncionarioV FromVisualizar = new FormFuncionarioV(idfunc);

            FromVisualizar.ShowDialog();
            Funcionarios.PreecherGridview(dgw_funcionario);


            //


            //DataClasses1DataContext db = new DataClasses1DataContext();
            //tblfuncionario funcionario = new tblfuncionario();


            //// criar pesquisa  no banco para encontrar registro selecionado
            //var pesquisa = from funcio in db.tblfuncionarios
            //               where funcio.id_funcionario == idfunc
            //               select funcio;


            //funcionario = pesquisa.Single();

            //// criando formulario para mostrar dados do registro que esta no banco 
            //form_cadastro_fu formAlterar = new form_cadastro_fu(funcionario, db);

            //// mostrando formulario

            //formAlterar.ShowDialog();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            // cria formulario de cadastro
            form_cadastro_fu func_cadastro = new form_cadastro_fu();
            func_cadastro.ShowDialog();
            //
            Funcionarios.PreecherGridview(dgw_funcionario);


        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {



                // metodo para pega index  dgw_funcionario.CurrentCell.RowIndex.ToString()
                int selecionado = dgw_funcionario.CurrentCell.RowIndex;

                int idfunc;

                idfunc = int.Parse(dgw_funcionario.Rows[selecionado].Cells["id_funcionario"].Value.ToString());



                DataClasses1DataContext db = new DataClasses1DataContext();


                var funci = from funcionario in db.tblfuncionarios
                            where funcionario.id_funcionario.Equals(idfunc)
                            select funcionario;

                tblfuncionario fun = funci.Single();


                db.tblfuncionarios.DeleteOnSubmit(fun);
                db.SubmitChanges();

                MessageBox.Show("Deletado com sucesso");

                Funcionarios.PreecherGridview(dgw_funcionario);

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro!");
            }

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgw_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (cb_seleciona != null)
            {
                if (cb_seleciona.Text == "ID")
                {

                     Funcionarios func = new Funcionarios();

                     func.PesquisarFuncionarioId(int.Parse(tb_pesquisar.Text), dgw_funcionario);
                   
                }
                else if (cb_seleciona.Text == "Nome")
                {
                    Funcionarios func = new Funcionarios();

                    func.PequisarFuncionarioNome(tb_pesquisar.Text, dgw_funcionario);

                }
                else if (cb_seleciona.Text == "CPF")
                {
                    Funcionarios func = new Funcionarios();
                    func.PequisarFuncionarioCPF(tb_pesquisar.Text, dgw_funcionario);

                }

            }
            else
            {
                Funcionarios.PreecherGridview(dgw_funcionario);

            }

        }

        private void cb_seleciona_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_seleciona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_seleciona.Text == "ID")
            {
                tb_pesquisar.Mask = "0000";
            }
            else
            {
                tb_pesquisar.Mask = "";
            }
        }
    }
}
