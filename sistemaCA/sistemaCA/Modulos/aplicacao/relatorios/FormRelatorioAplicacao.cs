using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace sistemaCA.Modulos.aplicacao.relatorios
{
    public partial class FormRelatorioAplicacao : Form
    {
        public int IDAplicacao;

        public FormRelatorioAplicacao()
        {
            InitializeComponent();
        }


        // contrutor com id da aplicaçao

        public FormRelatorioAplicacao(int id_aplicacao)
        {
            InitializeComponent();
            IDAplicacao = id_aplicacao;

        }

        public void FormRelatorioAplicacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRelatorioAplicao.tblaplicacao' table. You can move, or remove it, as needed.

            this.tblaplicacaoTableAdapter.Fill(this.dsRelatorioAplicao.tblaplicacao, IDAplicacao);

            this.reportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
