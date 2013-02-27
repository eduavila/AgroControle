namespace sistemaCA.views.funcionario
{
    partial class FormFuncionarioV
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
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.tb_celular = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_admisao = new System.Windows.Forms.DateTimePicker();
            this.tb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_renumeracao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_funcao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ctps = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_rg = new System.Windows.Forms.MaskedTextBox();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_funcionario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_sexo.Location = new System.Drawing.Point(324, 226);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(54, 21);
            this.cb_sexo.TabIndex = 101;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(318, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 100;
            this.label17.Text = "Sexo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 383);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 99;
            this.label16.Text = "Observação";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(43, 399);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(254, 59);
            this.tb_obs.TabIndex = 98;
            // 
            // tb_celular
            // 
            this.tb_celular.Location = new System.Drawing.Point(462, 346);
            this.tb_celular.Name = "tb_celular";
            this.tb_celular.Size = new System.Drawing.Size(135, 20);
            this.tb_celular.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Celular";
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(544, 442);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(93, 35);
            this.btn_Deletar.TabIndex = 95;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(448, 442);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(93, 35);
            this.btn_Alterar.TabIndex = 94;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Sobrenome";
            // 
            // dtp_admisao
            // 
            this.dtp_admisao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_admisao.Location = new System.Drawing.Point(320, 294);
            this.dtp_admisao.Name = "dtp_admisao";
            this.dtp_admisao.Size = new System.Drawing.Size(126, 20);
            this.dtp_admisao.TabIndex = 92;
            this.dtp_admisao.Value = new System.DateTime(2013, 2, 22, 0, 0, 0, 0);
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(320, 346);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(135, 20);
            this.tb_telefone.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 90;
            this.label15.Text = "Telefone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(459, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = "Renumeração Mensal";
            // 
            // tb_renumeracao
            // 
            this.tb_renumeracao.Location = new System.Drawing.Point(462, 293);
            this.tb_renumeracao.Name = "tb_renumeracao";
            this.tb_renumeracao.Size = new System.Drawing.Size(108, 20);
            this.tb_renumeracao.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "E-Mail";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(43, 347);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(257, 20);
            this.tb_email.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 84;
            this.label11.Text = "Função";
            // 
            // tb_funcao
            // 
            this.tb_funcao.Location = new System.Drawing.Point(42, 294);
            this.tb_funcao.Name = "tb_funcao";
            this.tb_funcao.Size = new System.Drawing.Size(257, 20);
            this.tb_funcao.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Bairro";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(43, 227);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(257, 20);
            this.tb_bairro.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Data Adimissão";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(319, 172);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(257, 20);
            this.tb_endereco.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Endereço:";
            // 
            // tb_ctps
            // 
            this.tb_ctps.Location = new System.Drawing.Point(317, 124);
            this.tb_ctps.Name = "tb_ctps";
            this.tb_ctps.Size = new System.Drawing.Size(257, 20);
            this.tb_ctps.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "CTPS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "CPF:";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(40, 125);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(257, 20);
            this.tb_cpf.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "RG:";
            // 
            // tb_rg
            // 
            this.tb_rg.Location = new System.Drawing.Point(40, 173);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(179, 20);
            this.tb_rg.TabIndex = 72;
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.Location = new System.Drawing.Point(319, 68);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(257, 20);
            this.tb_sobrenome.TabIndex = 71;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(40, 69);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(257, 20);
            this.tb_nome.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nome :";
            // 
            // tb_id_funcionario
            // 
            this.tb_id_funcionario.Location = new System.Drawing.Point(40, 21);
            this.tb_id_funcionario.Name = "tb_id_funcionario";
            this.tb_id_funcionario.Size = new System.Drawing.Size(43, 20);
            this.tb_id_funcionario.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 102;
            this.label10.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 104;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFuncionarioV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_id_funcionario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.tb_celular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_admisao);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_renumeracao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_funcao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_ctps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_rg);
            this.Controls.Add(this.tb_sobrenome);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Name = "FormFuncionarioV";
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.FormFuncionarioV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox tb_obs;
        public System.Windows.Forms.MaskedTextBox tb_celular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtp_admisao;
        public System.Windows.Forms.MaskedTextBox tb_telefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tb_renumeracao;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tb_funcao;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox tb_ctps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox tb_cpf;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox tb_rg;
        public System.Windows.Forms.TextBox tb_sobrenome;
        public System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_id_funcionario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}