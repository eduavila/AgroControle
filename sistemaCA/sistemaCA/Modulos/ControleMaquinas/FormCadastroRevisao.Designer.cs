namespace sistemaCA.Modulos.ControleMaquinas
{
    partial class FormCadastroRevisao
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
            System.Windows.Forms.Label motivoLabel;
            System.Windows.Forms.Label data_revisaoLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label máquinaLabel;
            System.Windows.Forms.Label safraLabel;
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.Dtp_datarevisao = new System.Windows.Forms.DateTimePicker();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.dgw_produtos = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_maquina = new System.Windows.Forms.TextBox();
            this.tb_safra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            motivoLabel = new System.Windows.Forms.Label();
            data_revisaoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            máquinaLabel = new System.Windows.Forms.Label();
            safraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_produtos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(27, 45);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(235, 20);
            this.tb_descricao.TabIndex = 2;
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Location = new System.Drawing.Point(28, 29);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new System.Drawing.Size(55, 13);
            motivoLabel.TabIndex = 1;
            motivoLabel.Text = "Descrição";
            motivoLabel.Click += new System.EventHandler(this.motivoLabel_Click);
            // 
            // Dtp_datarevisao
            // 
            this.Dtp_datarevisao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_datarevisao.Location = new System.Drawing.Point(322, 45);
            this.Dtp_datarevisao.Name = "Dtp_datarevisao";
            this.Dtp_datarevisao.Size = new System.Drawing.Size(98, 20);
            this.Dtp_datarevisao.TabIndex = 3;
            // 
            // data_revisaoLabel
            // 
            data_revisaoLabel.AutoSize = true;
            data_revisaoLabel.Location = new System.Drawing.Point(319, 29);
            data_revisaoLabel.Name = "data_revisaoLabel";
            data_revisaoLabel.Size = new System.Drawing.Size(68, 13);
            data_revisaoLabel.TabIndex = 2;
            data_revisaoLabel.Text = "data revisao:";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Aberta",
            "Finalizada"});
            this.cb_status.Location = new System.Drawing.Point(27, 106);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(92, 21);
            this.cb_status.TabIndex = 5;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(28, 90);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status:";
            // 
            // máquinaLabel
            // 
            máquinaLabel.AutoSize = true;
            máquinaLabel.Location = new System.Drawing.Point(166, 90);
            máquinaLabel.Name = "máquinaLabel";
            máquinaLabel.Size = new System.Drawing.Size(51, 13);
            máquinaLabel.TabIndex = 6;
            máquinaLabel.Text = "Máquina:";
            // 
            // safraLabel
            // 
            safraLabel.AutoSize = true;
            safraLabel.Location = new System.Drawing.Point(319, 90);
            safraLabel.Name = "safraLabel";
            safraLabel.Size = new System.Drawing.Size(35, 13);
            safraLabel.TabIndex = 11;
            safraLabel.Text = "Safra:";
            // 
            // dgw_produtos
            // 
            this.dgw_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.valor});
            this.dgw_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_produtos.Location = new System.Drawing.Point(3, 16);
            this.dgw_produtos.Name = "dgw_produtos";
            this.dgw_produtos.Size = new System.Drawing.Size(529, 222);
            this.dgw_produtos.TabIndex = 0;
            this.dgw_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dTItemRevisaoDataGridView_CellContentClick);
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgw_produtos);
            this.groupBox1.Location = new System.Drawing.Point(27, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 241);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // tb_maquina
            // 
            this.tb_maquina.Location = new System.Drawing.Point(169, 106);
            this.tb_maquina.Name = "tb_maquina";
            this.tb_maquina.Size = new System.Drawing.Size(48, 20);
            this.tb_maquina.TabIndex = 43;
            // 
            // tb_safra
            // 
            this.tb_safra.AcceptsReturn = true;
            this.tb_safra.Location = new System.Drawing.Point(322, 107);
            this.tb_safra.Name = "tb_safra";
            this.tb_safra.Size = new System.Drawing.Size(45, 20);
            this.tb_safra.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_visualizar.Location = new System.Drawing.Point(370, 460);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(87, 33);
            this.btn_visualizar.TabIndex = 41;
            this.btn_visualizar.Text = "Cadastrar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(472, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCadastroRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 518);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_safra);
            this.Controls.Add(this.tb_maquina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(safraLabel);
            this.Controls.Add(máquinaLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(data_revisaoLabel);
            this.Controls.Add(this.Dtp_datarevisao);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.tb_descricao);
            this.Name = "FormCadastroRevisao";
            this.Text = "FormCadastroRevisao";
            this.Load += new System.EventHandler(this.FormCadastroRevisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_produtos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.DateTimePicker Dtp_datarevisao;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.DataGridView dgw_produtos;
        private System.Windows.Forms.DataGridViewComboBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_maquina;
        private System.Windows.Forms.TextBox tb_safra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button button1;
    }
}