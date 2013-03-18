namespace sistemaCA.Modulos.aplicacao.relatorios
{
    partial class FormRelatorioAplicacao
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
            this.dsRelatorioAplicao = new sistemaCA.Modulos.aplicacao.relatorios.dsRelatorioAplicao();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRelatorioAplicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblaplicacaoTableAdapter = new sistemaCA.Modulos.aplicacao.relatorios.dsRelatorioAplicaoTableAdapters.tblaplicacaoTableAdapter();
            this.tblprodutosaplicadoTableAdapter1 = new sistemaCA.Modulos.aplicacao.relatorios.dsRelatorioAplicaoTableAdapters.tblprodutosaplicadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblaplicacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioAplicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioAplicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblaplicacaoBindingSource
            // 
            this.tblaplicacaoBindingSource.DataMember = "tblaplicacao";
            this.tblaplicacaoBindingSource.DataSource = this.dsRelatorioAplicao;
            // 
            // dsRelatorioAplicao
            // 
            this.dsRelatorioAplicao.DataSetName = "dsRelatorioAplicao";
            this.dsRelatorioAplicao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsetaplicacao";
            reportDataSource1.Value = this.tblaplicacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaCA.Modulos.aplicacao.relatorios.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(777, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsRelatorioAplicaoBindingSource
            // 
            this.dsRelatorioAplicaoBindingSource.DataSource = this.dsRelatorioAplicao;
            this.dsRelatorioAplicaoBindingSource.Position = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = this.dsRelatorioAplicao;
            this.bindingSource1.Position = 0;
            // 
            // tblaplicacaoTableAdapter
            // 
            this.tblaplicacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tblprodutosaplicadoTableAdapter1
            // 
            this.tblprodutosaplicadoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormRelatorioAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 504);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioAplicacao";
            this.Text = "FormRelatorioAplicacao";
            this.Load += new System.EventHandler(this.FormRelatorioAplicacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblaplicacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioAplicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioAplicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsRelatorioAplicaoBindingSource;
        private dsRelatorioAplicao dsRelatorioAplicao;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource tblaplicacaoBindingSource;
        private dsRelatorioAplicaoTableAdapters.tblaplicacaoTableAdapter tblaplicacaoTableAdapter;
        private dsRelatorioAplicaoTableAdapters.tblprodutosaplicadoTableAdapter tblprodutosaplicadoTableAdapter1;

      


    }
}