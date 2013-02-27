namespace sistemaCA.views.safra
{
    partial class FormTipoCultura
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
            this.dgw_cultura = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_cultura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_cultura
            // 
            this.dgw_cultura.AllowUserToDeleteRows = false;
            this.dgw_cultura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_cultura.Location = new System.Drawing.Point(12, 73);
            this.dgw_cultura.Name = "dgw_cultura";
            this.dgw_cultura.Size = new System.Drawing.Size(390, 139);
            this.dgw_cultura.TabIndex = 2;
            this.dgw_cultura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_cultura_CellContentClick);
            this.dgw_cultura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_cultura_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_pesquisa);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(16, 19);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(342, 20);
            this.tb_pesquisa.TabIndex = 2;
            this.tb_pesquisa.TextChanged += new System.EventHandler(this.tb_pesquisa_TextChanged);
            // 
            // FormTipoCultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgw_cultura);
            this.Name = "FormTipoCultura";
            this.Text = "Tipo Cultura";
            this.Load += new System.EventHandler(this.FormTipoCultura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_cultura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_cultura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_pesquisa;

    }
}