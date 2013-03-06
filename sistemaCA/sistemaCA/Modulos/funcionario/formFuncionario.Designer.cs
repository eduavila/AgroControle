namespace sistemaCA.views
{
    partial class formFuncionario
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
            this.dgw_funcionario = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.cb_seleciona = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_pesquisar = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_funcionario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_funcionario);
            this.groupBox1.Location = new System.Drawing.Point(3, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 406);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            // 
            // dgw_funcionario
            // 
            this.dgw_funcionario.AllowUserToAddRows = false;
            this.dgw_funcionario.AllowUserToDeleteRows = false;
            this.dgw_funcionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgw_funcionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgw_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_funcionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_funcionario.Location = new System.Drawing.Point(3, 16);
            this.dgw_funcionario.Name = "dgw_funcionario";
            this.dgw_funcionario.ReadOnly = true;
            this.dgw_funcionario.Size = new System.Drawing.Size(839, 387);
            this.dgw_funcionario.TabIndex = 0;
            this.dgw_funcionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_funcionario_CellContentClick);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(13, 20);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(87, 33);
            this.btn_cadastrar.TabIndex = 34;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 491);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(860, 22);
            this.statusStrip2.TabIndex = 37;
            this.statusStrip2.Text = "statusStrip2";
            this.statusStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip2_ItemClicked);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(114, 20);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(87, 33);
            this.btn_visualizar.TabIndex = 39;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // cb_seleciona
            // 
            this.cb_seleciona.FormattingEnabled = true;
            this.cb_seleciona.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "CPF"});
            this.cb_seleciona.Location = new System.Drawing.Point(12, 19);
            this.cb_seleciona.Name = "cb_seleciona";
            this.cb_seleciona.Size = new System.Drawing.Size(70, 21);
            this.cb_seleciona.TabIndex = 42;
            this.cb_seleciona.SelectedIndexChanged += new System.EventHandler(this.cb_seleciona_SelectedIndexChanged);
            this.cb_seleciona.TextChanged += new System.EventHandler(this.cb_seleciona_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cadastrar);
            this.groupBox2.Controls.Add(this.btn_visualizar);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 64);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_pesquisar);
            this.groupBox3.Controls.Add(this.cb_seleciona);
            this.groupBox3.Location = new System.Drawing.Point(597, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 52);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // tb_pesquisar
            // 
            this.tb_pesquisar.Location = new System.Drawing.Point(89, 19);
            this.tb_pesquisar.Name = "tb_pesquisar";
            this.tb_pesquisar.Size = new System.Drawing.Size(152, 20);
            this.tb_pesquisar.TabIndex = 43;
            this.tb_pesquisar.TextChanged += new System.EventHandler(this.tb_pesquisar_TextChanged);
            // 
            // formFuncionario
            // 
            this.ClientSize = new System.Drawing.Size(860, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.formFuncionario_Load);
            this.Shown += new System.EventHandler(this.formFuncionario_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_funcionario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_funcionario;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.ComboBox cb_seleciona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox tb_pesquisar;
    }
}