namespace sistemaCA.Modulos.ControleMaquinas
{
    partial class FormAlterarRevisao
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
            System.Windows.Forms.Label safraLabel;
            System.Windows.Forms.Label máquinaLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label data_revisaoLabel;
            System.Windows.Forms.Label motivoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.btnsafra = new System.Windows.Forms.Button();
            this.btnMaquina = new System.Windows.Forms.Button();
            this.tb_safra = new System.Windows.Forms.TextBox();
            this.tb_maquina = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_produtos = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.Dtp_datarevisao = new System.Windows.Forms.DateTimePicker();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.dtp_data_cadastro = new System.Windows.Forms.DateTimePicker();
            safraLabel = new System.Windows.Forms.Label();
            máquinaLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            data_revisaoLabel = new System.Windows.Forms.Label();
            motivoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // safraLabel
            // 
            safraLabel.AutoSize = true;
            safraLabel.Location = new System.Drawing.Point(318, 112);
            safraLabel.Name = "safraLabel";
            safraLabel.Size = new System.Drawing.Size(35, 13);
            safraLabel.TabIndex = 54;
            safraLabel.Text = "Safra:";
            // 
            // máquinaLabel
            // 
            máquinaLabel.AutoSize = true;
            máquinaLabel.Location = new System.Drawing.Point(165, 112);
            máquinaLabel.Name = "máquinaLabel";
            máquinaLabel.Size = new System.Drawing.Size(51, 13);
            máquinaLabel.TabIndex = 53;
            máquinaLabel.Text = "Máquina:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(27, 112);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 51;
            statusLabel.Text = "Status:";
            // 
            // data_revisaoLabel
            // 
            data_revisaoLabel.AutoSize = true;
            data_revisaoLabel.Location = new System.Drawing.Point(318, 51);
            data_revisaoLabel.Name = "data_revisaoLabel";
            data_revisaoLabel.Size = new System.Drawing.Size(68, 13);
            data_revisaoLabel.TabIndex = 48;
            data_revisaoLabel.Text = "data revisao:";
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(27, 51);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(55, 13);
            motivoLabel.TabIndex = 47;
            motivoLabel.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 13);
            label1.TabIndex = 62;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(124, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 13);
            label2.TabIndex = 66;
            label2.Text = "Data Cadastro";
            // 
            // btnsafra
            // 
            this.btnsafra.Enabled = false;
            this.btnsafra.Location = new System.Drawing.Point(371, 128);
            this.btnsafra.Name = "btnsafra";
            this.btnsafra.Size = new System.Drawing.Size(25, 23);
            this.btnsafra.TabIndex = 59;
            this.btnsafra.Text = "button3";
            this.btnsafra.UseVisualStyleBackColor = true;
            // 
            // btnMaquina
            // 
            this.btnMaquina.Enabled = false;
            this.btnMaquina.Location = new System.Drawing.Point(223, 128);
            this.btnMaquina.Name = "btnMaquina";
            this.btnMaquina.Size = new System.Drawing.Size(25, 23);
            this.btnMaquina.TabIndex = 58;
            this.btnMaquina.Text = "button2";
            this.btnMaquina.UseVisualStyleBackColor = true;
            // 
            // tb_safra
            // 
            this.tb_safra.AcceptsReturn = true;
            this.tb_safra.Enabled = false;
            this.tb_safra.Location = new System.Drawing.Point(321, 129);
            this.tb_safra.Name = "tb_safra";
            this.tb_safra.Size = new System.Drawing.Size(45, 20);
            this.tb_safra.TabIndex = 57;
            // 
            // tb_maquina
            // 
            this.tb_maquina.Enabled = false;
            this.tb_maquina.Location = new System.Drawing.Point(168, 128);
            this.tb_maquina.Name = "tb_maquina";
            this.tb_maquina.Size = new System.Drawing.Size(48, 20);
            this.tb_maquina.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgw_produtos);
            this.groupBox1.Location = new System.Drawing.Point(26, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 241);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // dgw_produtos
            // 
            this.dgw_produtos.AllowDrop = true;
            this.dgw_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.valor});
            this.dgw_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_produtos.Enabled = false;
            this.dgw_produtos.Location = new System.Drawing.Point(3, 16);
            this.dgw_produtos.Name = "dgw_produtos";
            this.dgw_produtos.Size = new System.Drawing.Size(529, 222);
            this.dgw_produtos.TabIndex = 0;
            this.dgw_produtos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgw_produtos_DataError);
            this.dgw_produtos.Click += new System.EventHandler(this.dgw_produtos_Click);
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.produto.DataPropertyName = "produto";
            this.produto.HeaderText = "Produtos";
            this.produto.Name = "produto";
            this.produto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Aberta",
            "Finalizada"});
            this.cb_status.Location = new System.Drawing.Point(26, 128);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(92, 21);
            this.cb_status.TabIndex = 52;
            // 
            // Dtp_datarevisao
            // 
            this.Dtp_datarevisao.Enabled = false;
            this.Dtp_datarevisao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_datarevisao.Location = new System.Drawing.Point(321, 67);
            this.Dtp_datarevisao.Name = "Dtp_datarevisao";
            this.Dtp_datarevisao.Size = new System.Drawing.Size(98, 20);
            this.Dtp_datarevisao.TabIndex = 50;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Enabled = false;
            this.tb_descricao.Location = new System.Drawing.Point(26, 67);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(235, 20);
            this.tb_descricao.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(473, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 61;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_visualizar.Location = new System.Drawing.Point(371, 458);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(87, 33);
            this.btn_visualizar.TabIndex = 60;
            this.btn_visualizar.Tag = "";
            this.btn_visualizar.Text = "Alterar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(25, 22);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(30, 20);
            this.tb_id.TabIndex = 63;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salvar.Location = new System.Drawing.Point(266, 458);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(87, 33);
            this.btn_salvar.TabIndex = 64;
            this.btn_salvar.Tag = "";
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Visible = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // dtp_data_cadastro
            // 
            this.dtp_data_cadastro.Enabled = false;
            this.dtp_data_cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_cadastro.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtp_data_cadastro.Location = new System.Drawing.Point(127, 22);
            this.dtp_data_cadastro.Name = "dtp_data_cadastro";
            this.dtp_data_cadastro.Size = new System.Drawing.Size(89, 20);
            this.dtp_data_cadastro.TabIndex = 65;
            // 
            // FormAlterarRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 518);
            this.Controls.Add(label2);
            this.Controls.Add(this.dtp_data_cadastro);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(label1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btnsafra);
            this.Controls.Add(this.btnMaquina);
            this.Controls.Add(this.tb_safra);
            this.Controls.Add(this.tb_maquina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(safraLabel);
            this.Controls.Add(máquinaLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(data_revisaoLabel);
            this.Controls.Add(this.Dtp_datarevisao);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.tb_descricao);
            this.Name = "FormAlterarRevisao";
            this.Text = "Visualizar Revisão";
            this.Load += new System.EventHandler(this.FormAlterarRevisao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsafra;
        private System.Windows.Forms.Button btnMaquina;
        private System.Windows.Forms.TextBox tb_safra;
        private System.Windows.Forms.TextBox tb_maquina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.DateTimePicker Dtp_datarevisao;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DateTimePicker dtp_data_cadastro;
        private System.Windows.Forms.DataGridView dgw_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}