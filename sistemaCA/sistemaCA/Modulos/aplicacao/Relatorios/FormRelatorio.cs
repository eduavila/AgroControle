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

namespace sistemaCA.Modulos.aplicacao.Relatorios
{
    public partial class FormRelatorio : Form
    {
        public int IDAplicacao { get; set; }
        public FormRelatorio()
        {
            InitializeComponent();
        }
        public FormRelatorio(int idaplicacao)
        {
            InitializeComponent();
            IDAplicacao = idaplicacao;
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSRelatorio.tblaplicacao' table. You can move, or remove it, as needed.
            this.tblaplicacaoTableAdapter.Fill(this.DSRelatorio.tblaplicacao, IDAplicacao);
            this.tblprodutosaplicadoTableAdapter.Fill(this.DSRelatorio.tblprodutosaplicado, IDAplicacao);

            this.reportViewer1.LocalReport.SubreportProcessing +=
             new SubreportProcessingEventHandler(SubreportProcessingEventHandler);


            this.reportViewer1.RefreshReport();
        }

        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("DsSubRelatorio", tblprodutosaplicacaoBindingSource));
        }
    }
}
