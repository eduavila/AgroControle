namespace sistemaCA.views.safra
{
    partial class FormAtualizarSafra
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_datainicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.tb_tipocultura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_idsafra = new System.Windows.Forms.TextBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Observação";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(33, 197);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(179, 77);
            this.tb_obs.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data Inicio";
            // 
            // dt_datainicio
            // 
            this.dt_datainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_datainicio.Location = new System.Drawing.Point(33, 124);
            this.dt_datainicio.Name = "dt_datainicio";
            this.dt_datainicio.Size = new System.Drawing.Size(99, 20);
            this.dt_datainicio.TabIndex = 41;
            this.dt_datainicio.Value = new System.DateTime(2013, 2, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Descrição";
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(271, 65);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(86, 20);
            this.tb_status.TabIndex = 38;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(33, 66);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(205, 20);
            this.tb_descricao.TabIndex = 37;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(369, 120);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(33, 23);
            this.btn_pesquisar.TabIndex = 36;
            this.btn_pesquisar.Text = "psquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_tipocultura
            // 
            this.tb_tipocultura.Location = new System.Drawing.Point(271, 122);
            this.tb_tipocultura.Name = "tb_tipocultura";
            this.tb_tipocultura.Size = new System.Drawing.Size(92, 20);
            this.tb_tipocultura.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cultura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "ID ";
            // 
            // tb_idsafra
            // 
            this.tb_idsafra.Location = new System.Drawing.Point(33, 27);
            this.tb_idsafra.Name = "tb_idsafra";
            this.tb_idsafra.Size = new System.Drawing.Size(37, 20);
            this.tb_idsafra.TabIndex = 45;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(332, 312);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(80, 30);
            this.btn_deletar.TabIndex = 50;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(238, 312);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(77, 30);
            this.btn_alterar.TabIndex = 49;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(146, 312);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(77, 30);
            this.btn_salvar.TabIndex = 52;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // FormAtualizarSafra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 354);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_idsafra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_datainicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.tb_tipocultura);
            this.Controls.Add(this.label4);
            this.Name = "FormAtualizarSafra";
            this.Text = "Visualizar Safra";
            this.Load += new System.EventHandler(this.FormAtualizarSafra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_datainicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox tb_tipocultura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_idsafra;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_salvar;
    }
}