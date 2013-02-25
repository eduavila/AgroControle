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

namespace sistemaCA.views
{
    public partial class formFuncionario : Form
    {
        public formFuncionario()
        {
            InitializeComponent();
        }

        private void formFuncionario_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var func = from funcionario in db.tblfuncionarios
                       select funcionario; 
                       


            dgw_funcionario.DataSource = func;

            
            

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

            form_cadastro_fu func_cadastro = new form_cadastro_fu();
            func_cadastro.ShowDialog();



        }
    }
}
