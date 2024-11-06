namespace trabalho
{
    partial class add_colaborador
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
            System.Windows.Forms.Label nome_colaboradorLabel;
            System.Windows.Forms.Label data_admissaoLabel;
            System.Windows.Forms.Label funcaoLabel;
            System.Windows.Forms.Label observacao_sobre_colaboradorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_colaborador));
            this.cadastro_projetoDataSet2 = new trabalho.Cadastro_projetoDataSet2();
            this.colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradoresTableAdapter = new trabalho.Cadastro_projetoDataSet2TableAdapters.colaboradoresTableAdapter();
            this.tableAdapterManager = new trabalho.Cadastro_projetoDataSet2TableAdapters.TableAdapterManager();
            this.colaboradoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.colaboradoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nome_colaboradorTextBox = new System.Windows.Forms.TextBox();
            this.data_admissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacao_sobre_colaboradorTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            nome_colaboradorLabel = new System.Windows.Forms.Label();
            data_admissaoLabel = new System.Windows.Forms.Label();
            funcaoLabel = new System.Windows.Forms.Label();
            observacao_sobre_colaboradorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingNavigator)).BeginInit();
            this.colaboradoresBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_colaboradorLabel
            // 
            nome_colaboradorLabel.AutoSize = true;
            nome_colaboradorLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_colaboradorLabel.Location = new System.Drawing.Point(28, 56);
            nome_colaboradorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nome_colaboradorLabel.Name = "nome_colaboradorLabel";
            nome_colaboradorLabel.Size = new System.Drawing.Size(107, 13);
            nome_colaboradorLabel.TabIndex = 3;
            nome_colaboradorLabel.Text = "NOME COMPLETO";
            // 
            // data_admissaoLabel
            // 
            data_admissaoLabel.AutoSize = true;
            data_admissaoLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_admissaoLabel.Location = new System.Drawing.Point(28, 83);
            data_admissaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_admissaoLabel.Name = "data_admissaoLabel";
            data_admissaoLabel.Size = new System.Drawing.Size(37, 13);
            data_admissaoLabel.TabIndex = 5;
            data_admissaoLabel.Text = "DATA";
            data_admissaoLabel.Click += new System.EventHandler(this.data_admissaoLabel_Click);
            // 
            // funcaoLabel
            // 
            funcaoLabel.AutoSize = true;
            funcaoLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            funcaoLabel.Location = new System.Drawing.Point(28, 108);
            funcaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            funcaoLabel.Name = "funcaoLabel";
            funcaoLabel.Size = new System.Drawing.Size(55, 13);
            funcaoLabel.TabIndex = 7;
            funcaoLabel.Text = "FUNÇÃO";
            // 
            // observacao_sobre_colaboradorLabel
            // 
            observacao_sobre_colaboradorLabel.AutoSize = true;
            observacao_sobre_colaboradorLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacao_sobre_colaboradorLabel.Location = new System.Drawing.Point(28, 167);
            observacao_sobre_colaboradorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacao_sobre_colaboradorLabel.Name = "observacao_sobre_colaboradorLabel";
            observacao_sobre_colaboradorLabel.Size = new System.Drawing.Size(172, 13);
            observacao_sobre_colaboradorLabel.TabIndex = 11;
            observacao_sobre_colaboradorLabel.Text = "INFORMAÇÕES RELAVANTES";
            // 
            // cadastro_projetoDataSet2
            // 
            this.cadastro_projetoDataSet2.DataSetName = "Cadastro_projetoDataSet2";
            this.cadastro_projetoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradoresBindingSource
            // 
            this.colaboradoresBindingSource.DataMember = "colaboradores";
            this.colaboradoresBindingSource.DataSource = this.cadastro_projetoDataSet2;
            // 
            // colaboradoresTableAdapter
            // 
            this.colaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.colaboradoresTableAdapter = this.colaboradoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = trabalho.Cadastro_projetoDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colaboradoresBindingNavigator
            // 
            this.colaboradoresBindingNavigator.AddNewItem = null;
            this.colaboradoresBindingNavigator.AutoSize = false;
            this.colaboradoresBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.colaboradoresBindingNavigator.BindingSource = this.colaboradoresBindingSource;
            this.colaboradoresBindingNavigator.CountItem = null;
            this.colaboradoresBindingNavigator.DeleteItem = null;
            this.colaboradoresBindingNavigator.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaboradoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.bindingNavigatorSeparator,
            this.colaboradoresBindingNavigatorSaveItem});
            this.colaboradoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.colaboradoresBindingNavigator.MoveFirstItem = null;
            this.colaboradoresBindingNavigator.MoveLastItem = null;
            this.colaboradoresBindingNavigator.MoveNextItem = null;
            this.colaboradoresBindingNavigator.MovePreviousItem = null;
            this.colaboradoresBindingNavigator.Name = "colaboradoresBindingNavigator";
            this.colaboradoresBindingNavigator.PositionItem = null;
            this.colaboradoresBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.colaboradoresBindingNavigator.Size = new System.Drawing.Size(530, 25);
            this.colaboradoresBindingNavigator.TabIndex = 0;
            this.colaboradoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(50, 30);
            this.toolStripButton1.Text = "VOLTAR";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // colaboradoresBindingNavigatorSaveItem
            // 
            this.colaboradoresBindingNavigatorSaveItem.AutoSize = false;
            this.colaboradoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colaboradoresBindingNavigatorSaveItem.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaboradoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("colaboradoresBindingNavigatorSaveItem.Image")));
            this.colaboradoresBindingNavigatorSaveItem.Name = "colaboradoresBindingNavigatorSaveItem";
            this.colaboradoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 30);
            this.colaboradoresBindingNavigatorSaveItem.Text = "SALVAR";
            this.colaboradoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.colaboradoresBindingNavigatorSaveItem_Click);
            // 
            // nome_colaboradorTextBox
            // 
            this.nome_colaboradorTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nome_colaboradorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradoresBindingSource, "Nome_colaborador", true));
            this.nome_colaboradorTextBox.Location = new System.Drawing.Point(174, 53);
            this.nome_colaboradorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nome_colaboradorTextBox.Name = "nome_colaboradorTextBox";
            this.nome_colaboradorTextBox.Size = new System.Drawing.Size(233, 21);
            this.nome_colaboradorTextBox.TabIndex = 4;
            // 
            // data_admissaoDateTimePicker
            // 
            this.data_admissaoDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.data_admissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.colaboradoresBindingSource, "Data_admissao", true));
            this.data_admissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_admissaoDateTimePicker.Location = new System.Drawing.Point(174, 79);
            this.data_admissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_admissaoDateTimePicker.Name = "data_admissaoDateTimePicker";
            this.data_admissaoDateTimePicker.Size = new System.Drawing.Size(121, 21);
            this.data_admissaoDateTimePicker.TabIndex = 6;
            // 
            // observacao_sobre_colaboradorTextBox
            // 
            this.observacao_sobre_colaboradorTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.observacao_sobre_colaboradorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradoresBindingSource, "Observacao_sobre_colaborador", true));
            this.observacao_sobre_colaboradorTextBox.Location = new System.Drawing.Point(31, 183);
            this.observacao_sobre_colaboradorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.observacao_sobre_colaboradorTextBox.Multiline = true;
            this.observacao_sobre_colaboradorTextBox.Name = "observacao_sobre_colaboradorTextBox";
            this.observacao_sobre_colaboradorTextBox.Size = new System.Drawing.Size(418, 144);
            this.observacao_sobre_colaboradorTextBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradoresBindingSource, "Funcao", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Supervisor",
            "Auxiliar Técnico",
            "Técnico",
            "Analista",
            "Asistente"});
            this.comboBox1.Location = new System.Drawing.Point(174, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // add_colaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(530, 353);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(nome_colaboradorLabel);
            this.Controls.Add(this.nome_colaboradorTextBox);
            this.Controls.Add(data_admissaoLabel);
            this.Controls.Add(this.data_admissaoDateTimePicker);
            this.Controls.Add(funcaoLabel);
            this.Controls.Add(observacao_sobre_colaboradorLabel);
            this.Controls.Add(this.observacao_sobre_colaboradorTextBox);
            this.Controls.Add(this.colaboradoresBindingNavigator);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_colaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de colaboradores";
            this.Load += new System.EventHandler(this.add_colaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingNavigator)).EndInit();
            this.colaboradoresBindingNavigator.ResumeLayout(false);
            this.colaboradoresBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cadastro_projetoDataSet2 cadastro_projetoDataSet2;
        private System.Windows.Forms.BindingSource colaboradoresBindingSource;
        private Cadastro_projetoDataSet2TableAdapters.colaboradoresTableAdapter colaboradoresTableAdapter;
        private Cadastro_projetoDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator colaboradoresBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton colaboradoresBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nome_colaboradorTextBox;
        private System.Windows.Forms.DateTimePicker data_admissaoDateTimePicker;
        private System.Windows.Forms.TextBox observacao_sobre_colaboradorTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}