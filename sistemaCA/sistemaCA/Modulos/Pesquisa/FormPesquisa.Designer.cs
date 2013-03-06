namespace sistemaCA.views.Pesquisa
{
    public partial class FormPesquisa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.dgw_pesquisa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_pesquisa);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 51);
            this.groupBox1.TabIndex = 5;
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
            // dgw_pesquisa
            // 
            this.dgw_pesquisa.AllowUserToAddRows = false;
            this.dgw_pesquisa.AllowUserToDeleteRows = false;
            this.dgw_pesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw_pesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_pesquisa.Location = new System.Drawing.Point(12, 72);
            this.dgw_pesquisa.Name = "dgw_pesquisa";
            this.dgw_pesquisa.ReadOnly = true;
            this.dgw_pesquisa.Size = new System.Drawing.Size(390, 139);
            this.dgw_pesquisa.TabIndex = 4;
            this.dgw_pesquisa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_pesquisa_CellContentDoubleClick);
            this.dgw_pesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_pesquisa_CellDoubleClick);
            this.dgw_pesquisa.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_pesquisa_CellEndEdit);
            this.dgw_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgw_pesquisa_KeyPress);
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 226);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgw_pesquisa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tb_pesquisa;
        public System.Windows.Forms.DataGridView dgw_pesquisa;
    }
}