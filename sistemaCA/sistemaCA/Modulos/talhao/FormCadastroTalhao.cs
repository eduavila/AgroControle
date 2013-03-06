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
    public partial class FormCadastroTalhao : Form
    {
        public FormCadastroTalhao()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                Talhao talhao = new Talhao();

                talhao.Descricao = tb_descricao.Text;
                talhao.tamanho = float.Parse(tb_tamanho.Text);
                talhao.Localizacao = tb_local.Text;
                talhao.Obs = tb_obs.Text;
                talhao.SitemaCutivo = cb_cultivo.Text;

                talhao.CadastrarTalhao();
                MessageBox.Show("Cadastro Registro com sucesso!");
                Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
