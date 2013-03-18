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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label motivoLabel;
            System.Windows.Forms.Label data_revisaoLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label máquinaLabel;
            System.Windows.Forms.Label safraLabel;
            this.motivoTextBox = new System.Windows.Forms.TextBox();
            this.data_revisaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.máquinaComboBox = new System.Windows.Forms.ComboBox();
            this.tblsafraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblsafraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dTItemRevisaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRevisao = new sistemaCA.Modulos.ControleMaquinas.dsRevisao();
            this.dTRevisaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTRevisaoTableAdapter = new sistemaCA.Modulos.ControleMaquinas.dsRevisaoTableAdapters.DTRevisaoTableAdapter();
            this.tableAdapterManager = new sistemaCA.Modulos.ControleMaquinas.dsRevisaoTableAdapters.TableAdapterManager();
            this.dTItemRevisaoTableAdapter = new sistemaCA.Modulos.ControleMaquinas.dsRevisaoTableAdapters.DTItemRevisaoTableAdapter();
            this.safraComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTItemRevisaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            motivoLabel = new System.Windows.Forms.Label();
            data_revisaoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            máquinaLabel = new System.Windows.Forms.Label();
            safraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblsafraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsafraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTItemRevisaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRevisao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRevisaoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTItemRevisaoDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // data_revisaoLabel
            // 
            data_revisaoLabel.AutoSize = true;
            data_revisaoLabel.Location = new System.Drawing.Point(319, 29);
            data_revisaoLabel.Name = "data_revisaoLabel";
            data_revisaoLabel.Size = new System.Drawing.Size(68, 13);
            data_revisaoLabel.TabIndex = 2;
            data_revisaoLabel.Text = "data revisao:";
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
            // motivoTextBox
            // 
            this.motivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTRevisaoBindingSource, "motivo", true));
            this.motivoTextBox.Location = new System.Drawing.Point(27, 45);
            this.motivoTextBox.Name = "motivoTextBox";
            this.motivoTextBox.Size = new System.Drawing.Size(235, 20);
            this.motivoTextBox.TabIndex = 2;
            // 
            // data_revisaoDateTimePicker
            // 
            this.data_revisaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dTRevisaoBindingSource, "data_revisao", true));
            this.data_revisaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_revisaoDateTimePicker.Location = new System.Drawing.Point(322, 45);
            this.data_revisaoDateTimePicker.Name = "data_revisaoDateTimePicker";
            this.data_revisaoDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.data_revisaoDateTimePicker.TabIndex = 3;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTRevisaoBindingSource, "status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Aberta",
            "Finalizada"});
            this.statusComboBox.Location = new System.Drawing.Point(27, 106);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(92, 21);
            this.statusComboBox.TabIndex = 5;
            // 
            // máquinaComboBox
            // 
            this.máquinaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTRevisaoBindingSource, "Máquina", true));
            this.máquinaComboBox.FormattingEnabled = true;
            this.máquinaComboBox.Location = new System.Drawing.Point(169, 106);
            this.máquinaComboBox.Name = "máquinaComboBox";
            this.máquinaComboBox.Size = new System.Drawing.Size(121, 21);
            this.máquinaComboBox.TabIndex = 7;
            // 
            // tblsafraBindingSource
            // 
            this.tblsafraBindingSource.DataSource = typeof(sistemaCA.tblsafra);
            // 
            // tblsafraBindingSource1
            // 
            this.tblsafraBindingSource1.DataSource = typeof(sistemaCA.tblsafra);
            // 
            // dTItemRevisaoBindingSource
            // 
            this.dTItemRevisaoBindingSource.DataMember = "DTItemRevisao";
            this.dTItemRevisaoBindingSource.DataSource = this.dsRevisao;
            // 
            // dsRevisao
            // 
            this.dsRevisao.DataSetName = "dsRevisao";
            this.dsRevisao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTRevisaoBindingSource
            // 
            this.dTRevisaoBindingSource.DataMember = "DTRevisao";
            this.dTRevisaoBindingSource.DataSource = this.dsRevisao;
            // 
            // dTRevisaoTableAdapter
            // 
            this.dTRevisaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblsafraTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaCA.Modulos.ControleMaquinas.dsRevisaoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dTItemRevisaoTableAdapter
            // 
            this.dTItemRevisaoTableAdapter.ClearBeforeFill = true;
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
            // safraComboBox
            // 
            this.safraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dTRevisaoBindingSource, "Safra", true));
            this.safraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsRevisao, "DTRevisao.Safra", true));
            this.safraComboBox.DataSource = this.dsRevisao;
            this.safraComboBox.DisplayMember = "tblsafra.descricao";
            this.safraComboBox.FormattingEnabled = true;
            this.safraComboBox.Location = new System.Drawing.Point(322, 106);
            this.safraComboBox.Name = "safraComboBox";
            this.safraComboBox.Size = new System.Drawing.Size(121, 21);
            this.safraComboBox.TabIndex = 12;
            this.safraComboBox.ValueMember = "tblsafra.descricao";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dTItemRevisaoDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(27, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 241);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dTItemRevisaoDataGridView
            // 
            this.dTItemRevisaoDataGridView.AllowUserToAddRows = false;
            this.dTItemRevisaoDataGridView.AutoGenerateColumns = false;
            this.dTItemRevisaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTItemRevisaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ID});
            this.dTItemRevisaoDataGridView.DataSource = this.dTItemRevisaoBindingSource;
            this.dTItemRevisaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTItemRevisaoDataGridView.Location = new System.Drawing.Point(3, 16);
            this.dTItemRevisaoDataGridView.Name = "dTItemRevisaoDataGridView";
            this.dTItemRevisaoDataGridView.Size = new System.Drawing.Size(529, 222);
            this.dTItemRevisaoDataGridView.TabIndex = 0;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Produtos";
            this.dataGridViewComboBoxColumn2.HeaderText = "Produtos";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn3.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
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
            // FormCadastroRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(safraLabel);
            this.Controls.Add(this.safraComboBox);
            this.Controls.Add(máquinaLabel);
            this.Controls.Add(this.máquinaComboBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(data_revisaoLabel);
            this.Controls.Add(this.data_revisaoDateTimePicker);
            this.Controls.Add(motivoLabel);
            this.Controls.Add(this.motivoTextBox);
            this.Name = "FormCadastroRevisao";
            this.Text = "FormCadastroRevisao";
            this.Load += new System.EventHandler(this.FormCadastroRevisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblsafraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsafraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTItemRevisaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRevisao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTRevisaoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dTItemRevisaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsRevisao dsRevisao;
        private System.Windows.Forms.BindingSource dTRevisaoBindingSource;
        private dsRevisaoTableAdapters.DTRevisaoTableAdapter dTRevisaoTableAdapter;
        private dsRevisaoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox motivoTextBox;
        private System.Windows.Forms.DateTimePicker data_revisaoDateTimePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox máquinaComboBox;
        private System.Windows.Forms.BindingSource dTItemRevisaoBindingSource;
        private dsRevisaoTableAdapters.DTItemRevisaoTableAdapter dTItemRevisaoTableAdapter;
        private System.Windows.Forms.BindingSource tblsafraBindingSource;
        private System.Windows.Forms.BindingSource tblsafraBindingSource1;
        private System.Windows.Forms.ComboBox safraComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dTItemRevisaoDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_visualizar;
    }
}