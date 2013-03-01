namespace sistemaCA.views.bens
{
    partial class FormCadastrarBen
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
            this.Descrição = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tipomaquina = new System.Windows.Forms.ComboBox();
            this.tb_CodControle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dataaquisicao = new System.Windows.Forms.DateTimePicker();
            this.tb_precoaquisicao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_hodome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_horime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cadastra = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.mtb_placa = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Location = new System.Drawing.Point(206, 40);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(55, 13);
            this.Descrição.TabIndex = 45;
            this.Descrição.Text = "Descrição";
            this.Descrição.Click += new System.EventHandler(this.Descrição_Click);
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(209, 58);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(342, 20);
            this.tb_descricao.TabIndex = 46;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tipo Máquina";
            // 
            // tb_tipomaquina
            // 
            this.tb_tipomaquina.FormattingEnabled = true;
            this.tb_tipomaquina.Items.AddRange(new object[] {
            "Máquina",
            "Caminhões",
            "Implementos"});
            this.tb_tipomaquina.Location = new System.Drawing.Point(29, 113);
            this.tb_tipomaquina.Name = "tb_tipomaquina";
            this.tb_tipomaquina.Size = new System.Drawing.Size(121, 21);
            this.tb_tipomaquina.TabIndex = 51;
            // 
            // tb_CodControle
            // 
            this.tb_CodControle.Location = new System.Drawing.Point(29, 58);
            this.tb_CodControle.Name = "tb_CodControle";
            this.tb_CodControle.Size = new System.Drawing.Size(121, 20);
            this.tb_CodControle.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Código Controle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Data Aquisição";
            // 
            // dtp_dataaquisicao
            // 
            this.dtp_dataaquisicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataaquisicao.Location = new System.Drawing.Point(209, 114);
            this.dtp_dataaquisicao.Name = "dtp_dataaquisicao";
            this.dtp_dataaquisicao.Size = new System.Drawing.Size(98, 20);
            this.dtp_dataaquisicao.TabIndex = 50;
            // 
            // tb_precoaquisicao
            // 
            this.tb_precoaquisicao.Location = new System.Drawing.Point(371, 113);
            this.tb_precoaquisicao.Name = "tb_precoaquisicao";
            this.tb_precoaquisicao.Size = new System.Drawing.Size(109, 20);
            this.tb_precoaquisicao.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Preço Aquisição";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_hodome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_horime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(29, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 66);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informções Maquinario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Horas";
            // 
            // tb_hodome
            // 
            this.tb_hodome.Location = new System.Drawing.Point(229, 37);
            this.tb_hodome.Name = "tb_hodome";
            this.tb_hodome.Size = new System.Drawing.Size(80, 20);
            this.tb_hodome.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Hodometro Inicial";
            // 
            // tb_horime
            // 
            this.tb_horime.Location = new System.Drawing.Point(27, 37);
            this.tb_horime.Name = "tb_horime";
            this.tb_horime.Size = new System.Drawing.Size(80, 20);
            this.tb_horime.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Horimetro Inicial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Placa";
            // 
            // btn_cadastra
            // 
            this.btn_cadastra.Location = new System.Drawing.Point(347, 325);
            this.btn_cadastra.Name = "btn_cadastra";
            this.btn_cadastra.Size = new System.Drawing.Size(87, 33);
            this.btn_cadastra.TabIndex = 65;
            this.btn_cadastra.Text = "Cadastrar";
            this.btn_cadastra.UseVisualStyleBackColor = true;
            this.btn_cadastra.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(476, 325);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(87, 33);
            this.btn_cal.TabIndex = 66;
            this.btn_cal.Text = "Cancelar";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // mtb_placa
            // 
            this.mtb_placa.Location = new System.Drawing.Point(29, 175);
            this.mtb_placa.Name = "mtb_placa";
            this.mtb_placa.Size = new System.Drawing.Size(100, 20);
            this.mtb_placa.TabIndex = 67;
            // 
            // FormCadastrarBen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 378);
            this.Controls.Add(this.mtb_placa);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_cadastra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_precoaquisicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_CodControle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tipomaquina);
            this.Controls.Add(this.dtp_dataaquisicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.Descrição);
            this.Name = "FormCadastrarBen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Máquinario / Camilhões";
            this.Load += new System.EventHandler(this.FromCadatroBens_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label Descrição;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tb_tipomaquina;
        private System.Windows.Forms.TextBox tb_CodControle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dataaquisicao;
        private System.Windows.Forms.TextBox tb_precoaquisicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_hodome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_horime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cadastra;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.MaskedTextBox mtb_placa;
    }
}