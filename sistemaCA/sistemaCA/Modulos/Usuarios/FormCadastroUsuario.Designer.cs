namespace sistemaCA.Modulos.Usuarios
{
    partial class FormCadastroUsuario
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
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckl_revisao = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckl_aplicacao = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ck_aplicacao = new System.Windows.Forms.CheckBox();
            this.ck_revisao = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ckl_cadastro = new System.Windows.Forms.CheckedListBox();
            this.ck_cadastro = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ck_admin = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckl_admin = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(278, 335);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(87, 33);
            this.btn_visualizar.TabIndex = 41;
            this.btn_visualizar.Text = "Cadastrar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Usuário";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(192, 45);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 209);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acesso";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ck_revisao);
            this.groupBox4.Controls.Add(this.ckl_revisao);
            this.groupBox4.Location = new System.Drawing.Point(287, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 78);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // ckl_revisao
            // 
            this.ckl_revisao.BackColor = System.Drawing.SystemColors.Control;
            this.ckl_revisao.Enabled = false;
            this.ckl_revisao.FormattingEnabled = true;
            this.ckl_revisao.Items.AddRange(new object[] {
            "Cadastro",
            "Alterar",
            "Excluir"});
            this.ckl_revisao.Location = new System.Drawing.Point(6, 19);
            this.ckl_revisao.Name = "ckl_revisao";
            this.ckl_revisao.Size = new System.Drawing.Size(106, 49);
            this.ckl_revisao.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ck_aplicacao);
            this.groupBox3.Controls.Add(this.ckl_aplicacao);
            this.groupBox3.Location = new System.Drawing.Point(149, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 78);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // ckl_aplicacao
            // 
            this.ckl_aplicacao.BackColor = System.Drawing.SystemColors.Control;
            this.ckl_aplicacao.Enabled = false;
            this.ckl_aplicacao.FormattingEnabled = true;
            this.ckl_aplicacao.Items.AddRange(new object[] {
            "Cadastro",
            "Alterar",
            "Excluir"});
            this.ckl_aplicacao.Location = new System.Drawing.Point(6, 21);
            this.ckl_aplicacao.Name = "ckl_aplicacao";
            this.ckl_aplicacao.Size = new System.Drawing.Size(106, 49);
            this.ckl_aplicacao.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 84);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cadastro",
            "Alterar",
            "Excluir"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(110, 64);
            this.checkedListBox1.TabIndex = 0;
            // 
            // ck_aplicacao
            // 
            this.ck_aplicacao.AutoSize = true;
            this.ck_aplicacao.Location = new System.Drawing.Point(6, -1);
            this.ck_aplicacao.Name = "ck_aplicacao";
            this.ck_aplicacao.Size = new System.Drawing.Size(73, 17);
            this.ck_aplicacao.TabIndex = 2;
            this.ck_aplicacao.Text = "Aplicação";
            this.ck_aplicacao.UseVisualStyleBackColor = true;
            this.ck_aplicacao.CheckedChanged += new System.EventHandler(this.ck_aplicacao_CheckedChanged);
            // 
            // ck_revisao
            // 
            this.ck_revisao.AutoSize = true;
            this.ck_revisao.Location = new System.Drawing.Point(6, -1);
            this.ck_revisao.Name = "ck_revisao";
            this.ck_revisao.Size = new System.Drawing.Size(65, 17);
            this.ck_revisao.TabIndex = 3;
            this.ck_revisao.Text = "Revisão";
            this.ck_revisao.UseVisualStyleBackColor = true;
            this.ck_revisao.CheckedChanged += new System.EventHandler(this.ck_revisao_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ckl_cadastro);
            this.groupBox8.Location = new System.Drawing.Point(156, 62);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(118, 77);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // ckl_cadastro
            // 
            this.ckl_cadastro.BackColor = System.Drawing.SystemColors.Control;
            this.ckl_cadastro.Enabled = false;
            this.ckl_cadastro.FormattingEnabled = true;
            this.ckl_cadastro.Items.AddRange(new object[] {
            "Cadastro",
            "Alterar",
            "Excluir"});
            this.ckl_cadastro.Location = new System.Drawing.Point(6, 19);
            this.ckl_cadastro.Name = "ckl_cadastro";
            this.ckl_cadastro.Size = new System.Drawing.Size(106, 49);
            this.ckl_cadastro.TabIndex = 0;
            // 
            // ck_cadastro
            // 
            this.ck_cadastro.AutoSize = true;
            this.ck_cadastro.Location = new System.Drawing.Point(162, 57);
            this.ck_cadastro.Name = "ck_cadastro";
            this.ck_cadastro.Size = new System.Drawing.Size(68, 17);
            this.ck_cadastro.TabIndex = 1;
            this.ck_cadastro.Text = "Cadastro";
            this.ck_cadastro.UseVisualStyleBackColor = true;
            this.ck_cadastro.CheckedChanged += new System.EventHandler(this.ck_cadastro_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ck_cadastro);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Location = new System.Drawing.Point(-152, -57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(427, 198);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acesso";
            // 
            // ck_admin
            // 
            this.ck_admin.AutoSize = true;
            this.ck_admin.Location = new System.Drawing.Point(6, -1);
            this.ck_admin.Name = "ck_admin";
            this.ck_admin.Size = new System.Drawing.Size(89, 17);
            this.ck_admin.TabIndex = 3;
            this.ck_admin.Text = "Administrador";
            this.ck_admin.UseVisualStyleBackColor = true;
            this.ck_admin.CheckedChanged += new System.EventHandler(this.cb_admin_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ck_admin);
            this.groupBox6.Controls.Add(this.ckl_admin);
            this.groupBox6.Location = new System.Drawing.Point(12, 109);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(125, 94);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // ckl_admin
            // 
            this.ckl_admin.BackColor = System.Drawing.SystemColors.Control;
            this.ckl_admin.Enabled = false;
            this.ckl_admin.FormattingEnabled = true;
            this.ckl_admin.Items.AddRange(new object[] {
            "Cadastro",
            "Alterar",
            "Excluir",
            "Banco de Dados"});
            this.ckl_admin.Location = new System.Drawing.Point(6, 22);
            this.ckl_admin.Name = "ckl_admin";
            this.ckl_admin.Size = new System.Drawing.Size(106, 64);
            this.ckl_admin.TabIndex = 2;
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_visualizar);
            this.Name = "FormCadastroUsuario";
            this.Text = "Cadastro Usuário";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox ckl_revisao;
        private System.Windows.Forms.CheckedListBox ckl_aplicacao;
        private System.Windows.Forms.CheckBox ck_revisao;
        private System.Windows.Forms.CheckBox ck_aplicacao;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ck_cadastro;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckedListBox ckl_cadastro;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox ck_admin;
        private System.Windows.Forms.CheckedListBox ckl_admin;
    }
}