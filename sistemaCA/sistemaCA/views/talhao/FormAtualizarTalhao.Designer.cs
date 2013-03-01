namespace sistemaCA.views.talhao
{
    partial class FormAtualizarTalhao
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
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.cb_cultivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tamanho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(398, 319);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(77, 30);
            this.btn_deletar.TabIndex = 20;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(213, 319);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(77, 30);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Visible = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Observação";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(33, 187);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(222, 85);
            this.tb_obs.TabIndex = 5;
            // 
            // cb_cultivo
            // 
            this.cb_cultivo.FormattingEnabled = true;
            this.cb_cultivo.Location = new System.Drawing.Point(266, 126);
            this.cb_cultivo.Name = "cb_cultivo";
            this.cb_cultivo.Size = new System.Drawing.Size(121, 21);
            this.cb_cultivo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo Plantio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quantidade Hectares";
            // 
            // tb_tamanho
            // 
            this.tb_tamanho.Location = new System.Drawing.Point(265, 69);
            this.tb_tamanho.Name = "tb_tamanho";
            this.tb_tamanho.Size = new System.Drawing.Size(106, 20);
            this.tb_tamanho.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Localização";
            // 
            // tb_local
            // 
            this.tb_local.Location = new System.Drawing.Point(33, 128);
            this.tb_local.Name = "tb_local";
            this.tb_local.Size = new System.Drawing.Size(222, 20);
            this.tb_local.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descrição";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(33, 69);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(222, 20);
            this.tb_descricao.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(34, 30);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(31, 20);
            this.tb_id.TabIndex = 23;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(310, 319);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(77, 30);
            this.btn_alterar.TabIndex = 25;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAtualizarTalhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 374);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_salvar);
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
            this.Name = "FormAtualizarTalhao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAtualizarTalhao";
            this.Load += new System.EventHandler(this.FormAtualizarTalhao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.ComboBox cb_cultivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tamanho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_alterar;
    }
}