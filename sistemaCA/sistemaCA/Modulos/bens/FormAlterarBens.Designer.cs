namespace sistemaCA.views.bens
{
    partial class FormAlterarBens
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtb_hododmetro = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtb_horimetro = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_dataaquisicao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_precoaquisicao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_placa = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_codigoControle = new System.Windows.Forms.MaskedTextBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mtb_hododmetro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mtb_horimetro);
            this.groupBox1.Location = new System.Drawing.Point(46, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 68);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "KM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Hodometro";
            // 
            // mtb_hododmetro
            // 
            this.mtb_hododmetro.Location = new System.Drawing.Point(173, 41);
            this.mtb_hododmetro.Mask = "00000";
            this.mtb_hododmetro.Name = "mtb_hododmetro";
            this.mtb_hododmetro.Size = new System.Drawing.Size(79, 20);
            this.mtb_hododmetro.TabIndex = 16;
            this.mtb_hododmetro.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Horas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Horimetro";
            // 
            // mtb_horimetro
            // 
            this.mtb_horimetro.Location = new System.Drawing.Point(18, 42);
            this.mtb_horimetro.Mask = "00000";
            this.mtb_horimetro.Name = "mtb_horimetro";
            this.mtb_horimetro.Size = new System.Drawing.Size(79, 20);
            this.mtb_horimetro.TabIndex = 13;
            this.mtb_horimetro.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Data Aquisição";
            // 
            // dtp_dataaquisicao
            // 
            this.dtp_dataaquisicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataaquisicao.Location = new System.Drawing.Point(219, 136);
            this.dtp_dataaquisicao.Name = "dtp_dataaquisicao";
            this.dtp_dataaquisicao.Size = new System.Drawing.Size(97, 20);
            this.dtp_dataaquisicao.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Preço Aquisição";
            // 
            // tb_precoaquisicao
            // 
            this.tb_precoaquisicao.Location = new System.Drawing.Point(383, 136);
            this.tb_precoaquisicao.Name = "tb_precoaquisicao";
            this.tb_precoaquisicao.Size = new System.Drawing.Size(91, 20);
            this.tb_precoaquisicao.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Placa";
            // 
            // mtb_placa
            // 
            this.mtb_placa.Location = new System.Drawing.Point(46, 209);
            this.mtb_placa.Name = "mtb_placa";
            this.mtb_placa.Size = new System.Drawing.Size(100, 20);
            this.mtb_placa.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Máquinario",
            "Caminhões",
            "Implementos",
            "Avião"});
            this.cb_tipo.Location = new System.Drawing.Point(43, 136);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 19;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(219, 78);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(295, 20);
            this.tb_descricao.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código Controle";
            // 
            // mtb_codigoControle
            // 
            this.mtb_codigoControle.Location = new System.Drawing.Point(43, 78);
            this.mtb_codigoControle.Name = "mtb_codigoControle";
            this.mtb_codigoControle.Size = new System.Drawing.Size(100, 20);
            this.mtb_codigoControle.TabIndex = 13;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(443, 413);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(113, 35);
            this.btn_deletar.TabIndex = 26;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(314, 413);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(113, 35);
            this.btn_alterar.TabIndex = 27;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(188, 413);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(113, 35);
            this.btn_salvar.TabIndex = 28;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Visible = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(45, 28);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(31, 20);
            this.tb_id.TabIndex = 30;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(42, 10);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 29;
            this.ID.Text = "ID";
            // 
            // FormAlterarBens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 460);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_dataaquisicao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_precoaquisicao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtb_placa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_codigoControle);
            this.Name = "FormAlterarBens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Máquinas";
            this.Load += new System.EventHandler(this.FormAlterarBens_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtb_hododmetro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtb_horimetro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_dataaquisicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_precoaquisicao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_placa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_codigoControle;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label ID;
    }
}