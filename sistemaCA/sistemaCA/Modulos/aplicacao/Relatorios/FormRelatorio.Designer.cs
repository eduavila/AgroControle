namespace sistemaCA.Modulos.aplicacao.Relatorios
{
    partial class FormRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblaplicacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSRelatorio = new sistemaCA.Modulos.aplicacao.Relatorios.DSRelatorio();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblaplicacaoTableAdapter = new sistemaCA.Modulos.aplicacao.Relatorios.DSRelatorioTableAdapters.tblaplicacaoTableAdapter();
            this.tblprodutosaplicacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblprodutosaplicadoTableAdapter = new sistemaCA.Modulos.aplicacao.Relatorios.DSRelatorioTableAdapters.tblprodutosaplicadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblaplicacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosaplicacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblaplicacaoBindingSource
            // 
            this.tblaplicacaoBindingSource.DataMember = "tblaplicacao";
            this.tblaplicacaoBindingSource.DataSource = this.DSRelatorio;
            // 
            // DSRelatorio
            // 
            this.DSRelatorio.DataSetName = "DSRelatorio";
            this.DSRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsRelatorio2";
            reportDataSource1.Value = this.tblaplicacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaCA.Modulos.aplicacao.Relatorios.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(677, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblaplicacaoTableAdapter
            // 
            this.tblaplicacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tblprodutosaplicacaoBindingSource
            // 
            this.tblprodutosaplicacaoBindingSource.DataMember = "tblprodutosaplicado";
            this.tblprodutosaplicacaoBindingSource.DataSource = this.DSRelatorio;
            // 
            // tblprodutosaplicadoTableAdapter
            // 
            this.tblprodutosaplicadoTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblaplicacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosaplicacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblaplicacaoBindingSource;
        private DSRelatorioTableAdapters.tblaplicacaoTableAdapter tblaplicacaoTableAdapter;
        private System.Windows.Forms.BindingSource tblprodutosaplicacaoBindingSource;
        private DSRelatorioTableAdapters.tblprodutosaplicadoTableAdapter tblprodutosaplicadoTableAdapter;
        private DSRelatorio DSRelatorio;
    }
}