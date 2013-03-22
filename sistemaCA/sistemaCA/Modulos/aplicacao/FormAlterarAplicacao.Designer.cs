namespace sistemaCA.Modulos.aplicacao
{
    partial class FormAlterarAplicacao
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
            this.label6 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_talhao = new System.Windows.Forms.Button();
            this.tb_talhao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_maquina = new System.Windows.Forms.Button();
            this.tb_maquinas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_aplicacao = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_safra = new System.Windows.Forms.Button();
            this.tb_safra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_funcionario = new System.Windows.Forms.Button();
            this.tb_idFunc = new System.Windows.Forms.TextBox();
            this.tb_areaplicada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_cadastro = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgw_produto = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_tipoaplicacao = new System.Windows.Forms.ComboBox();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Descrição";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(92, 22);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(302, 20);
            this.tb_descricao.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Status";
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(31, 64);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(100, 20);
            this.tb_status.TabIndex = 56;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_talhao);
            this.groupBox6.Controls.Add(this.tb_talhao);
            this.groupBox6.Location = new System.Drawing.Point(34, 169);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(107, 47);
            this.groupBox6.TabIndex = 51;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Talhão";
            // 
            // btn_talhao
            // 
            this.btn_talhao.Enabled = false;
            this.btn_talhao.Location = new System.Drawing.Point(66, 16);
            this.btn_talhao.Name = "btn_talhao";
            this.btn_talhao.Size = new System.Drawing.Size(33, 23);
            this.btn_talhao.TabIndex = 3;
            this.btn_talhao.Text = "button6";
            this.btn_talhao.UseVisualStyleBackColor = true;
            this.btn_talhao.Click += new System.EventHandler(this.button6_Click);
            // 
            // tb_talhao
            // 
            this.tb_talhao.Location = new System.Drawing.Point(17, 19);
            this.tb_talhao.Name = "tb_talhao";
            this.tb_talhao.Size = new System.Drawing.Size(43, 20);
            this.tb_talhao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Observação";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(382, 155);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(220, 78);
            this.tb_obs.TabIndex = 54;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_maquina);
            this.groupBox4.Controls.Add(this.tb_maquinas);
            this.groupBox4.Location = new System.Drawing.Point(295, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(107, 47);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Máquina";
            // 
            // btn_maquina
            // 
            this.btn_maquina.Enabled = false;
            this.btn_maquina.Location = new System.Drawing.Point(66, 16);
            this.btn_maquina.Name = "btn_maquina";
            this.btn_maquina.Size = new System.Drawing.Size(33, 23);
            this.btn_maquina.TabIndex = 3;
            this.btn_maquina.Text = "button3";
            this.btn_maquina.UseVisualStyleBackColor = true;
            this.btn_maquina.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_maquinas
            // 
            this.tb_maquinas.Location = new System.Drawing.Point(17, 19);
            this.tb_maquinas.Name = "tb_maquinas";
            this.tb_maquinas.Size = new System.Drawing.Size(43, 20);
            this.tb_maquinas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Hectares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Data Aplicação";
            // 
            // dtp_aplicacao
            // 
            this.dtp_aplicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_aplicacao.Location = new System.Drawing.Point(31, 123);
            this.dtp_aplicacao.Name = "dtp_aplicacao";
            this.dtp_aplicacao.Size = new System.Drawing.Size(99, 20);
            this.dtp_aplicacao.TabIndex = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_safra);
            this.groupBox3.Controls.Add(this.tb_safra);
            this.groupBox3.Location = new System.Drawing.Point(165, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 47);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Safra";
            // 
            // btn_safra
            // 
            this.btn_safra.Enabled = false;
            this.btn_safra.Location = new System.Drawing.Point(66, 16);
            this.btn_safra.Name = "btn_safra";
            this.btn_safra.Size = new System.Drawing.Size(33, 23);
            this.btn_safra.TabIndex = 3;
            this.btn_safra.Text = "button2";
            this.btn_safra.UseVisualStyleBackColor = true;
            this.btn_safra.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_safra
            // 
            this.tb_safra.Location = new System.Drawing.Point(17, 19);
            this.tb_safra.Name = "tb_safra";
            this.tb_safra.Size = new System.Drawing.Size(43, 20);
            this.tb_safra.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_funcionario);
            this.groupBox2.Controls.Add(this.tb_idFunc);
            this.groupBox2.Location = new System.Drawing.Point(173, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 47);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionário";
            // 
            // btn_funcionario
            // 
            this.btn_funcionario.Enabled = false;
            this.btn_funcionario.Location = new System.Drawing.Point(66, 16);
            this.btn_funcionario.Name = "btn_funcionario";
            this.btn_funcionario.Size = new System.Drawing.Size(33, 23);
            this.btn_funcionario.TabIndex = 3;
            this.btn_funcionario.Text = "button1";
            this.btn_funcionario.UseVisualStyleBackColor = true;
            this.btn_funcionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_idFunc
            // 
            this.tb_idFunc.Location = new System.Drawing.Point(17, 19);
            this.tb_idFunc.Name = "tb_idFunc";
            this.tb_idFunc.Size = new System.Drawing.Size(43, 20);
            this.tb_idFunc.TabIndex = 2;
            // 
            // tb_areaplicada
            // 
            this.tb_areaplicada.Location = new System.Drawing.Point(151, 66);
            this.tb_areaplicada.Name = "tb_areaplicada";
            this.tb_areaplicada.Size = new System.Drawing.Size(75, 20);
            this.tb_areaplicada.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Área Aplicada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(31, 22);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(30, 20);
            this.tb_id.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Data Aplicação";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.Location = new System.Drawing.Point(424, 77);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Size = new System.Drawing.Size(63, 20);
            this.tb_cadastro.TabIndex = 65;
            this.tb_cadastro.TextChanged += new System.EventHandler(this.tb_cadastro_TextChanged);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alterar.Location = new System.Drawing.Point(410, 477);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(87, 33);
            this.btn_alterar.TabIndex = 68;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salvar.Location = new System.Drawing.Point(317, 477);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(87, 33);
            this.btn_salvar.TabIndex = 66;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Location = new System.Drawing.Point(507, 477);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 33);
            this.btn_cancelar.TabIndex = 67;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dgw_produto);
            this.groupBox5.Location = new System.Drawing.Point(9, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(593, 182);
            this.groupBox5.TabIndex = 69;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Produtos";
            // 
            // dgw_produto
            // 
            this.dgw_produto.AllowUserToDeleteRows = false;
            this.dgw_produto.AllowUserToOrderColumns = true;
            this.dgw_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_produto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_produto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgw_produto.Location = new System.Drawing.Point(3, 16);
            this.dgw_produto.Name = "dgw_produto";
            this.dgw_produto.ReadOnly = true;
            this.dgw_produto.Size = new System.Drawing.Size(587, 163);
            this.dgw_produto.TabIndex = 0;
            this.dgw_produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_produto_CellContentClick);
            this.dgw_produto.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgw_produto_DataError);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Tipo de Aplicação";
            // 
            // cb_tipoaplicacao
            // 
            this.cb_tipoaplicacao.FormattingEnabled = true;
            this.cb_tipoaplicacao.Items.AddRange(new object[] {
            "Plantio",
            "Adubação",
            "Puvirização"});
            this.cb_tipoaplicacao.Location = new System.Drawing.Point(424, 22);
            this.cb_tipoaplicacao.Name = "cb_tipoaplicacao";
            this.cb_tipoaplicacao.Size = new System.Drawing.Size(121, 21);
            this.cb_tipoaplicacao.TabIndex = 70;
            // 
            // FormAlterarAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 536);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_tipoaplicacao);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tb_cadastro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_aplicacao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_areaplicada);
            this.Controls.Add(this.label1);
            this.Name = "FormAlterarAplicacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Aplicação";
            this.Load += new System.EventHandler(this.FormAlterarAplicacao_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_talhao;
        private System.Windows.Forms.TextBox tb_talhao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_maquina;
        private System.Windows.Forms.TextBox tb_maquinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_aplicacao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_safra;
        private System.Windows.Forms.TextBox tb_safra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_funcionario;
        private System.Windows.Forms.TextBox tb_idFunc;
        private System.Windows.Forms.TextBox tb_areaplicada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_cadastro;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_tipoaplicacao;
        public System.Windows.Forms.DataGridView dgw_produto;
    }
}