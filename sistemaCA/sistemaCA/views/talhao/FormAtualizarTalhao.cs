using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.talhao
{
    public partial class FormAtualizarTalhao : Form
    {
        public FormAtualizarTalhao()
        {
            InitializeComponent();
        }

        // contrutor padrao recebendo o idtalhao
        public FormAtualizarTalhao(int idtalhao)
        {
            InitializeComponent();


            // iniciando o talhao 

            Talhao talhao = new Talhao();
           
            talhao.VisualizarTalhao(idtalhao);

            tb_id.Text = talhao.Id_talhao.ToString();
            tb_descricao.Text = talhao.Descricao;
            cb_cultivo.Text = talhao.SitemaCutivo;
            tb_tamanho.Text = talhao.tamanho.ToString();
            tb_local.Text = talhao.Localizacao;
            tb_obs.Text = talhao.Obs;

            //



            // desativando componentes

            tb_id.Enabled = false;
            tb_descricao.Enabled = false;
            tb_tamanho.Enabled = false;
            tb_local.Enabled = false;
            tb_obs.Enabled = false;
            cb_cultivo.Enabled = false;




        }

        private void FormAtualizarTalhao_Load(object sender, EventArgs e)
        {
            btn_alterar.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ativando todo os componete para 

            tb_descricao.Enabled = true;
            tb_tamanho.Enabled = true;
            cb_cultivo.Enabled = true;
            tb_local.Enabled = true;
            tb_obs.Enabled = true;
            btn_salvar.Visible = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            Talhao talhao = new Talhao();

            talhao.Id_talhao = int.Parse(tb_id.Text);
            talhao.Descricao = tb_descricao.Text;
            talhao.Localizacao = tb_local.Text;
            talhao.tamanho =double.Parse(tb_tamanho.Text);
            talhao.Obs = tb_obs.Text;
            talhao.SitemaCutivo = cb_cultivo.Text;
            talhao.AlterarTalhao(talhao.Id_talhao);

            MessageBox.Show("Registro Salvo com sucesso!");
            Close();

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza de quer excluir o Registro Selecionado ?", "Excluir Registro", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                
                Talhao talhao = new Talhao();

                talhao.DeletarTalhao(int.Parse(tb_id.Text));



                MessageBox.Show("Foi Excluido com sucesso");
                this.Close();

            }
        }
    }
}
