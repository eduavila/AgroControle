using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.Modulos.aplicacao.relatorios
{
    public partial class FormRelatorioAplicacao : Form
    {
        public FormRelatorioAplicacao()
        {
            InitializeComponent();
        }


        // contrutor com id da aplicaçao

        public FormRelatorioAplicacao(int id_aplicacao)
        {
            InitializeComponent();










        }

        private void FormRelatorioAplicacao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
