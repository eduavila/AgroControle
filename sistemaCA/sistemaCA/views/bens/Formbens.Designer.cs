namespace sistemaCA.views.bens
{
    partial class Formbens
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
            this.dgw_bens = new System.Windows.Forms.DataGridView();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_bens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_bens
            // 
            this.dgw_bens.AllowUserToAddRows = false;
            this.dgw_bens.AllowUserToDeleteRows = false;
            this.dgw_bens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgw_bens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgw_bens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_bens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_bens.Location = new System.Drawing.Point(3, 16);
            this.dgw_bens.Name = "dgw_bens";
            this.dgw_bens.ReadOnly = true;
            this.dgw_bens.Size = new System.Drawing.Size(839, 387);
            this.dgw_bens.TabIndex = 0;
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(120, 30);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(87, 33);
            this.btn_visualizar.TabIndex = 42;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(17, 30);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(87, 33);
            this.btn_cadastrar.TabIndex = 41;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_bens);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 406);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Máquinarios";
            // 
            // Formbens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 513);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formbens";
            this.Text = "Máquinarios / Caminhões";
            this.Load += new System.EventHandler(this.Formbens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_bens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_bens;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}