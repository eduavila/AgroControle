using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.views.aplicacao;
using sistemaCA.views.Pesquisa;
namespace sistemaCA.Modulos.aplicacao
{
    public partial class FormAlterarAplicacao : Form
    {
        public FormAlterarAplicacao()
        {
            InitializeComponent();
        }

        public FormAlterarAplicacao(int id_aplicacao)
        {
            InitializeComponent();

            //desativando componetes

            tb_id.Enabled = false;
            tb_cadastro.Enabled = false;
            tb_descricao.Enabled = false;
            tb_areaplicada.Enabled = false;
            dtp_aplicacao.Enabled = false;
            tb_idFunc.Enabled = false;
            tb_obs.Enabled = false;
            tb_talhao.Enabled = false;
            tb_safra.Enabled = false;
            tb_status.Enabled = false;
            tb_maquinas.Enabled = false;
            btn_salvar.Visible = false;

            // preechendo campos com 
            Aplicacao aplica = new Aplicacao();
            aplica.VisualizarAplicacao(id_aplicacao);

            tb_id.Text = aplica.Id_aplicacao.ToString();
            tb_descricao.Text = aplica.Descricao;
            tb_areaplicada.Text = aplica.AreaAplicada.ToString();
            tb_idFunc.Text = aplica.ID_Funcionario.ToString();
            tb_obs.Text = aplica.Obs;
            tb_talhao.Text = aplica.ID_talhao.ToString();
            tb_safra.Text = aplica.ID_Safra.ToString();
            tb_status.Text = aplica.Status;
            tb_maquinas.Text = aplica.ID_Ben.ToString();
            dtp_aplicacao.Value = aplica.DataAplicacao;
            tb_cadastro.Text = aplica.DataCadastro.ToString();




            // preechendo grid de produto
            ProdutoAplicado produ = new ProdutoAplicado();


            produ.ListandoTodoProduto(id_aplicacao, dgw_produto);

            





        }
        private void FormAlterarAplicacao_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPesquisaSafra pesqui = new FormPesquisaSafra();
            pesqui.ShowDialog();
            tb_safra.Text = pesqui.ID.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPesquisaMaquinas pesqui = new FormPesquisaMaquinas();
            pesqui.ShowDialog();
            tb_maquinas.Text = pesqui.ID.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPesquisaIDtalhao pesqui = new FormPesquisaIDtalhao();
            pesqui.ShowDialog();
            tb_talhao.Text = pesqui.ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPesquisa pesq = new FormPesquisa();
            pesq.ShowDialog();
            tb_idFunc.Text = pesq.ID.ToString();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            // abilitando alterações

            
            
            tb_descricao.Enabled = true;
            tb_areaplicada.Enabled = true;
            dtp_aplicacao.Enabled = true;
            tb_obs.Enabled = true;
            tb_talhao.Enabled = false;
            tb_safra.Enabled = false;

            btn_salvar.Visible = true;


            btn_safra.Enabled = true;
            btn_maquina.Enabled = true;
            btn_talhao.Enabled = true;
            btn_funcionario.Enabled = true;
            





        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Aplicacao aplicacao = new Aplicacao();

            aplicacao.Status = tb_status.Text;
            aplicacao.Descricao = tb_descricao.Text;
            aplicacao.DataAplicacao = dtp_aplicacao.Value;
            aplicacao.AreaAplicada = float.Parse(tb_areaplicada.Text);
            aplicacao.ID_Ben = int.Parse(tb_maquinas.Text);
            aplicacao.ID_Funcionario = int.Parse(tb_idFunc.Text);
            aplicacao.ID_talhao = int.Parse(tb_talhao.Text);
            aplicacao.ID_Safra = int.Parse(tb_safra.Text);
            aplicacao.Obs = tb_obs.Text;

            aplicacao.AlterarAplicacao(int.Parse(tb_id.Text));

            Close();
            

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza de quer excluir o Registro Selecionado ?", "Excluir Registro", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                ProdutoAplicado produtos = new ProdutoAplicado();
                produtos.DeletandoTodoProduto(int.Parse(tb_id.Text));

                Aplicacao aplicacao = new Aplicacao();
                aplicacao.DeletarAplicacao(int.Parse(tb_id.Text));

               

                Close();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tb_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgw_produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgw_produto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}
