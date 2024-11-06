namespace trabalho
{
    partial class cadastro_produto
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
            System.Windows.Forms.Label colaboradores_idLabel;
            System.Windows.Forms.Label data_inicioLabel;
            System.Windows.Forms.Label produto_modeloLabel;
            System.Windows.Forms.Label serial_numberLabel;
            System.Windows.Forms.Label qtd_produtoLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.Windows.Forms.Label observacao_produtoLabel;
            System.Windows.Forms.Label data_terminoLabel;
            System.Windows.Forms.Label projetoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_produto));
            this.cadastro_projetoDataSet = new trabalho.Cadastro_projetoDataSet();
            this.cadastro_producao_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_producao_produtoTableAdapter = new trabalho.Cadastro_projetoDataSetTableAdapters.cadastro_producao_produtoTableAdapter();
            this.tableAdapterManager = new trabalho.Cadastro_projetoDataSetTableAdapters.TableAdapterManager();
            this.colaboradores_idTextBox = new System.Windows.Forms.TextBox();
            this.data_inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.produto_modeloTextBox = new System.Windows.Forms.TextBox();
            this.serial_numberTextBox = new System.Windows.Forms.TextBox();
            this.qtd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.observacao_produtoTextBox = new System.Windows.Forms.TextBox();
            this.data_terminoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projetoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cadastro_producao_produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastro_producao_produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            colaboradores_idLabel = new System.Windows.Forms.Label();
            data_inicioLabel = new System.Windows.Forms.Label();
            produto_modeloLabel = new System.Windows.Forms.Label();
            serial_numberLabel = new System.Windows.Forms.Label();
            qtd_produtoLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            observacao_produtoLabel = new System.Windows.Forms.Label();
            data_terminoLabel = new System.Windows.Forms.Label();
            projetoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_producao_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_producao_produtoBindingNavigator)).BeginInit();
            this.cadastro_producao_produtoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // colaboradores_idLabel
            // 
            colaboradores_idLabel.AutoSize = true;
            colaboradores_idLabel.Location = new System.Drawing.Point(14, 101);
            colaboradores_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            colaboradores_idLabel.Name = "colaboradores_idLabel";
            colaboradores_idLabel.Size = new System.Drawing.Size(34, 13);
            colaboradores_idLabel.TabIndex = 1;
            colaboradores_idLabel.Text = "N/ID";
            // 
            // data_inicioLabel
            // 
            data_inicioLabel.AutoSize = true;
            data_inicioLabel.Location = new System.Drawing.Point(13, 43);
            data_inicioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_inicioLabel.Name = "data_inicioLabel";
            data_inicioLabel.Size = new System.Drawing.Size(87, 13);
            data_inicioLabel.TabIndex = 3;
            data_inicioLabel.Text = "DATA IINÍCIO";
            data_inicioLabel.Click += new System.EventHandler(this.data_inicioLabel_Click);
            // 
            // produto_modeloLabel
            // 
            produto_modeloLabel.AutoSize = true;
            produto_modeloLabel.Location = new System.Drawing.Point(435, 101);
            produto_modeloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            produto_modeloLabel.Name = "produto_modeloLabel";
            produto_modeloLabel.Size = new System.Drawing.Size(118, 13);
            produto_modeloLabel.TabIndex = 5;
            produto_modeloLabel.Text = "PRODUTO/MODELO";
            // 
            // serial_numberLabel
            // 
            serial_numberLabel.AutoSize = true;
            serial_numberLabel.Location = new System.Drawing.Point(435, 147);
            serial_numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            serial_numberLabel.Name = "serial_numberLabel";
            serial_numberLabel.Size = new System.Drawing.Size(28, 13);
            serial_numberLabel.TabIndex = 7;
            serial_numberLabel.Text = "S/N";
            // 
            // qtd_produtoLabel
            // 
            qtd_produtoLabel.AutoSize = true;
            qtd_produtoLabel.Location = new System.Drawing.Point(190, 147);
            qtd_produtoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qtd_produtoLabel.Name = "qtd_produtoLabel";
            qtd_produtoLabel.Size = new System.Drawing.Size(85, 13);
            qtd_produtoLabel.TabIndex = 11;
            qtd_produtoLabel.Text = "QUANTIDADE";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(13, 147);
            situacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(51, 13);
            situacaoLabel.TabIndex = 12;
            situacaoLabel.Text = "STATUS";
            // 
            // observacao_produtoLabel
            // 
            observacao_produtoLabel.AutoSize = true;
            observacao_produtoLabel.Location = new System.Drawing.Point(14, 215);
            observacao_produtoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacao_produtoLabel.Name = "observacao_produtoLabel";
            observacao_produtoLabel.Size = new System.Drawing.Size(134, 13);
            observacao_produtoLabel.TabIndex = 13;
            observacao_produtoLabel.Text = "RELATÓRIO PRODUTO";
            // 
            // data_terminoLabel
            // 
            data_terminoLabel.AutoSize = true;
            data_terminoLabel.Location = new System.Drawing.Point(180, 43);
            data_terminoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_terminoLabel.Name = "data_terminoLabel";
            data_terminoLabel.Size = new System.Drawing.Size(94, 13);
            data_terminoLabel.TabIndex = 15;
            data_terminoLabel.Text = "DATA TÉRMINO";
            // 
            // projetoLabel
            // 
            projetoLabel.AutoSize = true;
            projetoLabel.Location = new System.Drawing.Point(190, 101);
            projetoLabel.Name = "projetoLabel";
            projetoLabel.Size = new System.Drawing.Size(59, 13);
            projetoLabel.TabIndex = 17;
            projetoLabel.Text = "PROJETO";
            // 
            // cadastro_projetoDataSet
            // 
            this.cadastro_projetoDataSet.DataSetName = "Cadastro_projetoDataSet";
            this.cadastro_projetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastro_producao_produtoBindingSource
            // 
            this.cadastro_producao_produtoBindingSource.DataMember = "cadastro_producao_produto";
            this.cadastro_producao_produtoBindingSource.DataSource = this.cadastro_projetoDataSet;
            // 
            // cadastro_producao_produtoTableAdapter
            // 
            this.cadastro_producao_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastro_producao_produtoTableAdapter = this.cadastro_producao_produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = trabalho.Cadastro_projetoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colaboradores_idTextBox
            // 
            this.colaboradores_idTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.colaboradores_idTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.colaboradores_idTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.colaboradores_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_producao_produtoBindingSource, "Colaboradores_id", true));
            this.colaboradores_idTextBox.Location = new System.Drawing.Point(17, 117);
            this.colaboradores_idTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colaboradores_idTextBox.Name = "colaboradores_idTextBox";
            this.colaboradores_idTextBox.Size = new System.Drawing.Size(156, 21);
            this.colaboradores_idTextBox.TabIndex = 3;
            this.colaboradores_idTextBox.TextChanged += new System.EventHandler(this.colaboradores_idTextBox_TextChanged);
            // 
            // data_inicioDateTimePicker
            // 
            this.data_inicioDateTimePicker.AllowDrop = true;
            this.data_inicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastro_producao_produtoBindingSource, "data_inicio", true));
            this.data_inicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_inicioDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.data_inicioDateTimePicker.Location = new System.Drawing.Point(17, 59);
            this.data_inicioDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_inicioDateTimePicker.MaxDate = new System.DateTime(2040, 8, 31, 0, 0, 0, 0);
            this.data_inicioDateTimePicker.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.data_inicioDateTimePicker.Name = "data_inicioDateTimePicker";
            this.data_inicioDateTimePicker.Size = new System.Drawing.Size(111, 21);
            this.data_inicioDateTimePicker.TabIndex = 1;
            this.data_inicioDateTimePicker.Value = new System.DateTime(2024, 9, 3, 22, 2, 5, 0);
            this.data_inicioDateTimePicker.ValueChanged += new System.EventHandler(this.data_inicioDateTimePicker_ValueChanged);
            // 
            // produto_modeloTextBox
            // 
            this.produto_modeloTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.produto_modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_producao_produtoBindingSource, "Produto_modelo", true));
            this.produto_modeloTextBox.Location = new System.Drawing.Point(438, 117);
            this.produto_modeloTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.produto_modeloTextBox.Name = "produto_modeloTextBox";
            this.produto_modeloTextBox.Size = new System.Drawing.Size(156, 21);
            this.produto_modeloTextBox.TabIndex = 5;
            this.produto_modeloTextBox.TextChanged += new System.EventHandler(this.produto_modeloTextBox_TextChanged);
            // 
            // serial_numberTextBox
            // 
            this.serial_numberTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.serial_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_producao_produtoBindingSource, "Serial_number", true));
            this.serial_numberTextBox.Location = new System.Drawing.Point(438, 163);
            this.serial_numberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serial_numberTextBox.Name = "serial_numberTextBox";
            this.serial_numberTextBox.Size = new System.Drawing.Size(156, 21);
            this.serial_numberTextBox.TabIndex = 8;
            this.serial_numberTextBox.TextChanged += new System.EventHandler(this.serial_numberTextBox_TextChanged);
            // 
            // qtd_produtoTextBox
            // 
            this.qtd_produtoTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.qtd_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_producao_produtoBindingSource, "Qtd_produto", true));
            this.qtd_produtoTextBox.Location = new System.Drawing.Point(193, 163);
            this.qtd_produtoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qtd_produtoTextBox.Name = "qtd_produtoTextBox";
            this.qtd_produtoTextBox.Size = new System.Drawing.Size(95, 21);
            this.qtd_produtoTextBox.TabIndex = 7;
            this.qtd_produtoTextBox.TextChanged += new System.EventHandler(this.qtd_produtoTextBox_TextChanged);
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.situacaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.situacaoComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_producao_produtoBindingSource, "Situacao", true));
            this.situacaoComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "Garantia",
            "Manutenção",
            "R.M.A",
            "Descarte",
            "Ok"});
            this.situacaoComboBox.Location = new System.Drawing.Point(17, 163);
            this.situacaoComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(126, 21);
            this.situacaoComboBox.TabIndex = 6;
            // 
            // observacao_produtoTextBox
            // 
            this.observacao_produtoTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.observacao_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_producao_produtoBindingSource, "Observacao_produto", true));
            this.observacao_produtoTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.observacao_produtoTextBox.Location = new System.Drawing.Point(13, 231);
            this.observacao_produtoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.observacao_produtoTextBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.observacao_produtoTextBox.Multiline = true;
            this.observacao_produtoTextBox.Name = "observacao_produtoTextBox";
            this.observacao_produtoTextBox.Size = new System.Drawing.Size(419, 200);
            this.observacao_produtoTextBox.TabIndex = 9;
            // 
            // data_terminoDateTimePicker
            // 
            this.data_terminoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastro_producao_produtoBindingSource, "data_termino", true));
            this.data_terminoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_terminoDateTimePicker.Location = new System.Drawing.Point(183, 59);
            this.data_terminoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_terminoDateTimePicker.MaxDate = new System.DateTime(2040, 8, 31, 0, 0, 0, 0);
            this.data_terminoDateTimePicker.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.data_terminoDateTimePicker.Name = "data_terminoDateTimePicker";
            this.data_terminoDateTimePicker.Size = new System.Drawing.Size(105, 21);
            this.data_terminoDateTimePicker.TabIndex = 2;
            this.data_terminoDateTimePicker.Value = new System.DateTime(2024, 9, 3, 22, 2, 23, 0);
            this.data_terminoDateTimePicker.ValueChanged += new System.EventHandler(this.data_terminoDateTimePicker_ValueChanged);
            // 
            // projetoTextBox
            // 
            this.projetoTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.projetoTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.projetoTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.projetoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastro_producao_produtoBindingSource, "Projeto", true));
            this.projetoTextBox.Location = new System.Drawing.Point(193, 117);
            this.projetoTextBox.Name = "projetoTextBox";
            this.projetoTextBox.Size = new System.Drawing.Size(211, 21);
            this.projetoTextBox.TabIndex = 4;
            this.projetoTextBox.TextChanged += new System.EventHandler(this.projetoTextBox_TextChanged);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorAddNewItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(45, 30);
            this.bindingNavigatorAddNewItem.Text = "NOVO";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            this.bindingNavigatorAddNewItem.VisibleChanged += new System.EventHandler(this.Form2_Load);
            // 
            // cadastro_producao_produtoBindingNavigator
            // 
            this.cadastro_producao_produtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastro_producao_produtoBindingNavigator.AutoSize = false;
            this.cadastro_producao_produtoBindingNavigator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cadastro_producao_produtoBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cadastro_producao_produtoBindingNavigator.BindingSource = this.cadastro_producao_produtoBindingSource;
            this.cadastro_producao_produtoBindingNavigator.CountItem = null;
            this.cadastro_producao_produtoBindingNavigator.DeleteItem = null;
            this.cadastro_producao_produtoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.cadastro_producao_produtoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cadastro_producao_produtoBindingNavigator.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cadastro_producao_produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator2,
            this.cadastro_producao_produtoBindingNavigatorSaveItem});
            this.cadastro_producao_produtoBindingNavigator.Location = new System.Drawing.Point(1, 0);
            this.cadastro_producao_produtoBindingNavigator.MoveFirstItem = null;
            this.cadastro_producao_produtoBindingNavigator.MoveLastItem = null;
            this.cadastro_producao_produtoBindingNavigator.MoveNextItem = null;
            this.cadastro_producao_produtoBindingNavigator.MovePreviousItem = null;
            this.cadastro_producao_produtoBindingNavigator.Name = "cadastro_producao_produtoBindingNavigator";
            this.cadastro_producao_produtoBindingNavigator.PositionItem = null;
            this.cadastro_producao_produtoBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cadastro_producao_produtoBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cadastro_producao_produtoBindingNavigator.Size = new System.Drawing.Size(623, 33);
            this.cadastro_producao_produtoBindingNavigator.TabIndex = 0;
            this.cadastro_producao_produtoBindingNavigator.Text = "bindingNavigator1";
            this.cadastro_producao_produtoBindingNavigator.RefreshItems += new System.EventHandler(this.cadastro_producao_produtoBindingNavigator_RefreshItems);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // cadastro_producao_produtoBindingNavigatorSaveItem
            // 
            this.cadastro_producao_produtoBindingNavigatorSaveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_producao_produtoBindingNavigatorSaveItem.Name = "cadastro_producao_produtoBindingNavigatorSaveItem";
            this.cadastro_producao_produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(56, 30);
            this.cadastro_producao_produtoBindingNavigatorSaveItem.Text = "SALVAR";
            this.cadastro_producao_produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastro_producao_produtoBindingNavigatorSaveItem_Click);
            // 
            // cadastro_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(623, 462);
            this.Controls.Add(projetoLabel);
            this.Controls.Add(this.projetoTextBox);
            this.Controls.Add(data_terminoLabel);
            this.Controls.Add(this.data_terminoDateTimePicker);
            this.Controls.Add(observacao_produtoLabel);
            this.Controls.Add(this.observacao_produtoTextBox);
            this.Controls.Add(situacaoLabel);
            this.Controls.Add(this.situacaoComboBox);
            this.Controls.Add(qtd_produtoLabel);
            this.Controls.Add(this.qtd_produtoTextBox);
            this.Controls.Add(serial_numberLabel);
            this.Controls.Add(this.serial_numberTextBox);
            this.Controls.Add(produto_modeloLabel);
            this.Controls.Add(this.produto_modeloTextBox);
            this.Controls.Add(data_inicioLabel);
            this.Controls.Add(this.data_inicioDateTimePicker);
            this.Controls.Add(colaboradores_idLabel);
            this.Controls.Add(this.colaboradores_idTextBox);
            this.Controls.Add(this.cadastro_producao_produtoBindingNavigator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadastro_produto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    THE LED - CADASTRAR PRODUTOS";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_producao_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_producao_produtoBindingNavigator)).EndInit();
            this.cadastro_producao_produtoBindingNavigator.ResumeLayout(false);
            this.cadastro_producao_produtoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cadastro_projetoDataSet cadastro_projetoDataSet;
        private System.Windows.Forms.BindingSource cadastro_producao_produtoBindingSource;
        private Cadastro_projetoDataSetTableAdapters.cadastro_producao_produtoTableAdapter cadastro_producao_produtoTableAdapter;
        private Cadastro_projetoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox colaboradores_idTextBox;
        private System.Windows.Forms.DateTimePicker data_inicioDateTimePicker;
        private System.Windows.Forms.TextBox produto_modeloTextBox;
        private System.Windows.Forms.TextBox serial_numberTextBox;
        private System.Windows.Forms.TextBox qtd_produtoTextBox;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.TextBox observacao_produtoTextBox;
        private System.Windows.Forms.DateTimePicker data_terminoDateTimePicker;
        private System.Windows.Forms.TextBox projetoTextBox;
        private System.Windows.Forms.BindingNavigator cadastro_producao_produtoBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cadastro_producao_produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    }
}