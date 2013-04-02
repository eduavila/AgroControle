namespace sistemaCA.views.aplicacao
{
    partial class FormPrevisaoAplicacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Barra_rodape1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dSRelatorio = new sistemaCA.Modulos.aplicacao.Relatorios.DSRelatorio();
            this.tblaplicacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblaplicacaoTableAdapter = new sistemaCA.Modulos.aplicacao.Relatorios.DSRelatorioTableAdapters.tblaplicacaoTableAdapter();
            this.tableAdapterManager = new sistemaCA.Modulos.aplicacao.Relatorios.DSRelatorioTableAdapters.TableAdapterManager();
            this.dgw_aplicacao = new System.Windows.Forms.DataGridView();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblaplicacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_aplicacao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgw_aplicacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aplicações";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Barra_rodape1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Barra_rodape1
            // 
            this.Barra_rodape1.Name = "Barra_rodape1";
            this.Barra_rodape1.Size = new System.Drawing.Size(0, 17);
            this.Barra_rodape1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Deletar);
            this.groupBox2.Controls.Add(this.btn_cadastrar);
            this.groupBox2.Controls.Add(this.btn_visualizar);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 62);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(227, 20);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(87, 33);
            this.btn_Deletar.TabIndex = 40;
            this.btn_Deletar.Text = "Excluir";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click_1);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(21, 20);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(87, 33);
            this.btn_cadastrar.TabIndex = 34;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click_1);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(124, 20);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(87, 33);
            this.btn_visualizar.TabIndex = 39;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(762, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 41;
            this.button1.Text = "Relatorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dSRelatorio
            // 
            this.dSRelatorio.DataSetName = "DSRelatorio";
            this.dSRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblaplicacaoBindingSource
            // 
            this.tblaplicacaoBindingSource.DataMember = "tblaplicacao";
            this.tblaplicacaoBindingSource.DataSource = this.dSRelatorio;
            // 
            // tblaplicacaoTableAdapter
            // 
            this.tblaplicacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblaplicacaoTableAdapter = this.tblaplicacaoTableAdapter;
            this.tableAdapterManager.tblprodutosaplicadoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaCA.Modulos.aplicacao.Relatorios.DSRelatorioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgw_aplicacao
            // 
            this.dgw_aplicacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_aplicacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_aplicacao.Location = new System.Drawing.Point(3, 16);
            this.dgw_aplicacao.Name = "dgw_aplicacao";
            this.dgw_aplicacao.Size = new System.Drawing.Size(835, 368);
            this.dgw_aplicacao.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FormPrevisaoAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrevisaoAplicacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previsão de Aplicação";
            this.Load += new System.EventHandler(this.FormAplicacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblaplicacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_aplicacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Barra_rodape1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button button1;
        private Modulos.aplicacao.Relatorios.DSRelatorio dSRelatorio;
        private System.Windows.Forms.BindingSource tblaplicacaoBindingSource;
        private Modulos.aplicacao.Relatorios.DSRelatorioTableAdapters.tblaplicacaoTableAdapter tblaplicacaoTableAdapter;
        private Modulos.aplicacao.Relatorios.DSRelatorioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgw_aplicacao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}