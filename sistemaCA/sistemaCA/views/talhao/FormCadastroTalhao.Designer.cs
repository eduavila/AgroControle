namespace sistemaCA.views.talhao
{
    partial class FormCadastroTalhao
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
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tamanho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_cultivo = new System.Windows.Forms.ComboBox();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(30, 51);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(222, 20);
            this.tb_descricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localização";
            // 
            // tb_local
            // 
            this.tb_local.Location = new System.Drawing.Point(30, 110);
            this.tb_local.Name = "tb_local";
            this.tb_local.Size = new System.Drawing.Size(222, 20);
            this.tb_local.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade Hectares";
            // 
            // tb_tamanho
            // 
            this.tb_tamanho.Location = new System.Drawing.Point(262, 51);
            this.tb_tamanho.Name = "tb_tamanho";
            this.tb_tamanho.Size = new System.Drawing.Size(106, 20);
            this.tb_tamanho.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Plantio";
            // 
            // cb_cultivo
            // 
            this.cb_cultivo.FormattingEnabled = true;
            this.cb_cultivo.Items.AddRange(new object[] {
            "Direto",
            "Pivo"});
            this.cb_cultivo.Location = new System.Drawing.Point(263, 108);
            this.cb_cultivo.Name = "cb_cultivo";
            this.cb_cultivo.Size = new System.Drawing.Size(121, 21);
            this.cb_cultivo.TabIndex = 3;
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(30, 169);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(222, 85);
            this.tb_obs.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observação";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(278, 314);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(77, 30);
            this.btn_cadastrar.TabIndex = 5;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(385, 314);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(77, 30);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FormCadastroTalhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 356);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.cb_cultivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_local);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_descricao);
            this.Name = "FormCadastroTalhao";
            this.Text = "Cadastro Talhão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tamanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_cultivo;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}