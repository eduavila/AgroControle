using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.Modulos.Usuarios
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ck_cadastro_CheckedChanged(object sender, EventArgs e)
        {
            // abilitando 
            if (ck_cadastro.Checked == true)
            {
                ckl_cadastro.Enabled = true;
            }
            else
            {
                ckl_cadastro.Enabled = false;
            }
        }

        private void ck_aplicacao_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_aplicacao.Checked == true)
            {
                ckl_aplicacao.Enabled = true;
            }
            else
            {
                ckl_aplicacao.Enabled = false;
            }
        }

        private void ck_revisao_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_revisao.Checked == true)
            {
                ckl_revisao.Enabled = true;
            }
            else
            {
                ckl_revisao.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_admin.Checked == true)
            {
                ckl_admin.Enabled = true;
            }
            else {
                ckl_admin.Enabled = false;
            }

        }
    }
}
