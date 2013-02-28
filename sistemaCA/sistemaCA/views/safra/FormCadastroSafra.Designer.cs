namespace sistemaCA.views.safra
{
    partial class FormCadastroSafra
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_tipocultura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_datainicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "psquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_tipocultura
            // 
            this.tb_tipocultura.Location = new System.Drawing.Point(263, 103);
            this.tb_tipocultura.Name = "tb_tipocultura";
            this.tb_tipocultura.Size = new System.Drawing.Size(61, 20);
            this.tb_tipocultura.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cultura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Descrição";
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(263, 47);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(86, 20);
            this.tb_status.TabIndex = 27;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(25, 48);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(205, 20);
            this.tb_descricao.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 24;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 30);
            this.button4.TabIndex = 23;
            this.button4.Text = "Cadastrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status";
            // 
            // dt_datainicio
            // 
            this.dt_datainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_datainicio.Location = new System.Drawing.Point(25, 106);
            this.dt_datainicio.Name = "dt_datainicio";
            this.dt_datainicio.Size = new System.Drawing.Size(99, 20);
            this.dt_datainicio.TabIndex = 30;
            this.dt_datainicio.Value = new System.DateTime(2013, 2, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data Inicio";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(25, 179);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(179, 77);
            this.tb_obs.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Observação";
            // 
            // FormCadastroSafra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 354);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_datainicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_tipocultura);
            this.Controls.Add(this.label4);
            this.Name = "FormCadastroSafra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Safra";
            this.Load += new System.EventHandler(this.FromCadastroSafra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_tipocultura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_datainicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label3;
    }
}