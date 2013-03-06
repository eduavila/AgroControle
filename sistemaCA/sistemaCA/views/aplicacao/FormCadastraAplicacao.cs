using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.views;
using sistemaCA.views.Pesquisa;

namespace sistemaCA.views.aplicacao
{
    public partial class FormCadastraAplicacao : Form
    {
        public FormCadastraAplicacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPesquisa pesq = new FormPesquisa();
            pesq.ShowDialog();
            tb_idFunc.Text = pesq.ID.ToString();
              
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPesquisaIDtalhao pesqui = new FormPesquisaIDtalhao();
            pesqui.ShowDialog();
            tb_talhao.Text = pesqui.ID.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPesquisaMaquinas pesqui = new FormPesquisaMaquinas();
            pesqui.ShowDialog();
            tb_maquinas.Text = pesqui.ID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPesquisaSafra pesqui = new FormPesquisaSafra();
            pesqui.ShowDialog();
            tb_safra.Text = pesqui.ID.ToString();
        }
    }
}
