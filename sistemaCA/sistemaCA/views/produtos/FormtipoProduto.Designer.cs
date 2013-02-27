namespace sistemaCA.views.produtos
{
    partial class FormtipoProduto
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
            this.dgv_tipoproduto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoproduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tipoproduto
            // 
            this.dgv_tipoproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoproduto.Location = new System.Drawing.Point(13, 70);
            this.dgv_tipoproduto.Name = "dgv_tipoproduto";
            this.dgv_tipoproduto.Size = new System.Drawing.Size(389, 145);
            this.dgv_tipoproduto.TabIndex = 0;
            this.dgv_tipoproduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tipoproduto_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_pesquisa);
            this.groupBox1.Controls.Add(this.btn_ok);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(23, 19);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(245, 20);
            this.tb_pesquisa.TabIndex = 4;
            this.tb_pesquisa.TextChanged += new System.EventHandler(this.tb_pesquisa_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(291, 15);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Pesquisar";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FormtipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_tipoproduto);
            this.Name = "FormtipoProduto";
            this.Text = "Tipo Produto";
            this.Load += new System.EventHandler(this.FormtipoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoproduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tipoproduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.Button btn_ok;
    }
}