namespace sistemaCA.views.fornecedor
{
    partial class FormVisualizarFornecedor
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
            this.btn_alterar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtb_email = new System.Windows.Forms.MaskedTextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_ie = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_razaosocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeFantasia = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_idfornecedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 58;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(402, 429);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(87, 33);
            this.btn_alterar.TabIndex = 57;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Observação";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(53, 322);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(274, 87);
            this.tb_obs.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "E-Mail";
            // 
            // mtb_email
            // 
            this.mtb_email.Location = new System.Drawing.Point(378, 239);
            this.mtb_email.Name = "mtb_email";
            this.mtb_email.Size = new System.Drawing.Size(234, 20);
            this.mtb_email.TabIndex = 53;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(388, 160);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 52;
            this.Telefone.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(391, 176);
            this.mtb_telefone.Mask = "(99) 0000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(81, 20);
            this.mtb_telefone.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Cidade";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(56, 239);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(274, 20);
            this.tb_cidade.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Endereço";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(56, 176);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(274, 20);
            this.tb_endereco.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Inscrição Estadual";
            // 
            // mtb_ie
            // 
            this.mtb_ie.Location = new System.Drawing.Point(424, 112);
            this.mtb_ie.Name = "mtb_ie";
            this.mtb_ie.Size = new System.Drawing.Size(163, 20);
            this.mtb_ie.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "CNPJ";
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Location = new System.Drawing.Point(220, 112);
            this.mtb_cnpj.Mask = "000.000.000-00";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(163, 20);
            this.mtb_cnpj.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "CPF";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(56, 112);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(158, 20);
            this.mtb_cpf.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Razão Social";
            // 
            // tb_razaosocial
            // 
            this.tb_razaosocial.Location = new System.Drawing.Point(361, 67);
            this.tb_razaosocial.Name = "tb_razaosocial";
            this.tb_razaosocial.Size = new System.Drawing.Size(251, 20);
            this.tb_razaosocial.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome Fantasia";
            // 
            // tb_nomeFantasia
            // 
            this.tb_nomeFantasia.Location = new System.Drawing.Point(56, 67);
            this.tb_nomeFantasia.Name = "tb_nomeFantasia";
            this.tb_nomeFantasia.Size = new System.Drawing.Size(274, 20);
            this.tb_nomeFantasia.TabIndex = 37;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(280, 429);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(87, 33);
            this.btn_salvar.TabIndex = 59;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "ID";
            // 
            // tb_idfornecedor
            // 
            this.tb_idfornecedor.Location = new System.Drawing.Point(53, 25);
            this.tb_idfornecedor.Name = "tb_idfornecedor";
            this.tb_idfornecedor.Size = new System.Drawing.Size(30, 20);
            this.tb_idfornecedor.TabIndex = 60;
            // 
            // FormVisualizarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 490);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_idfornecedor);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtb_email);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtb_ie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtb_cnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_razaosocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nomeFantasia);
            this.Name = "FormVisualizarFornecedor";
            this.Text = "FormVisualizarFornecedor";
            this.Load += new System.EventHandler(this.FormVisualizarFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtb_email;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_ie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_razaosocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeFantasia;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_idfornecedor;
    }
}