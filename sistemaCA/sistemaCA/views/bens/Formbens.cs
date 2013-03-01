using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.bens
{
    public partial class Formbens : Form
    {
        public Formbens()
        {
            InitializeComponent();
        }

        private void Formbens_Load(object sender, EventArgs e)
        {
            Bens ben = new Bens();
            ben.VisualizarBens(dgw_bens);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarBen Ben = new FormCadastrarBen();
            Ben.ShowDialog();


            // atualizar data grid termina de cadastrar

            Bens ben = new Bens();
            ben.VisualizarBens(dgw_bens);    
        }
    }
}
