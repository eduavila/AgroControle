using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();


            var q = from user in db.tblusuarios select user;


            foreach (var user in q)
            {


                if ((tb_user.Text == user.login.ToString()) && (tb_senha.Text == user.senha.ToString()))
                {

                    telaprincipal formprincipal = new telaprincipal();
                    formprincipal.Show();
                    this.Close();
                    break;
                }
                else
                {

                    MessageBox.Show("Erro Ao Autenticar : Usuário não existe ou senha icorreta", "Erro Autenticação ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                }

            }





            // acesso usuario 
            //if ((tb_user.Text == "admin") && (tb_senha.Text == "admin"))
            //{
            //    telaprincipal formprincipal = new telaprincipal();
            //    formprincipal.Show();
            //    this.Close();

            //}
            //else
            //{
            //    MessageBox.Show("Erro : Usuário não existe ou Senha Incorreta.");


            //}
        }
    }
}
