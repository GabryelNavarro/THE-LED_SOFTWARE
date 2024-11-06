namespace trabalho
{
    partial class listar_colaborad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listar_colaborad));
            this.cadastro_projetoDataSet2 = new trabalho.Cadastro_projetoDataSet2();
            this.colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradoresTableAdapter = new trabalho.Cadastro_projetoDataSet2TableAdapters.colaboradoresTableAdapter();
            this.tableAdapterManager = new trabalho.Cadastro_projetoDataSet2TableAdapters.TableAdapterManager();
            this.colaboradoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_inicio_pic = new System.Windows.Forms.DateTimePicker();
            this.Data_fim_pic = new System.Windows.Forms.DateTimePicker();
            this.nome_colaboradorComboBox = new System.Windows.Forms.ComboBox();
            this.colaboradoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Button_limpar_filtro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Funcao_ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Id_colaborador = new System.Windows.Forms.ComboBox();
            this.button_voltar = new System.Windows.Forms.Button();
            this.qtd_colaborador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // colaboradoresDataGridView
            // 
            this.colaboradoresDataGridView.AllowUserToAddRows = false;
            this.colaboradoresDataGridView.AllowUserToDeleteRows = false;
            this.colaboradoresDataGridView.AllowUserToResizeColumns = false;
            this.colaboradoresDataGridView.AllowUserToResizeRows = false;
            this.colaboradoresDataGridView.AutoGenerateColumns = false;
            this.colaboradoresDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.colaboradoresDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.colaboradoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colaboradoresDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.colaboradoresDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.colaboradoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colaboradoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.colaboradoresDataGridView.DataSource = this.colaboradoresBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colaboradoresDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.colaboradoresDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.colaboradoresDataGridView.Location = new System.Drawing.Point(12, 107);
            this.colaboradoresDataGridView.Name = "colaboradoresDataGridView";
            this.colaboradoresDataGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colaboradoresDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.colaboradoresDataGridView.RowHeadersVisible = false;
            this.colaboradoresDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.colaboradoresDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.colaboradoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.colaboradoresDataGridView.Size = new System.Drawing.Size(796, 308);
            this.colaboradoresDataGridView.TabIndex = 0;
            this.colaboradoresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.colaboradoresDataGridView_CellContentClick_1);
            this.colaboradoresDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.colaboradoresDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_colaborador";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID COLABORADOR";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 155;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_colaborador";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME COLABORADOR";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 156;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_admissao";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATA DE CADASTRO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 155;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Funcao";
            this.dataGridViewTextBoxColumn4.HeaderText = "FUNÇÃO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 156;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Observacao_sobre_colaborador";
            this.dataGridViewTextBoxColumn6.HeaderText = "PONTOS FORTES COLABORADOR";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 155;
            // 
            // Data_inicio_pic
            // 
            this.Data_inicio_pic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data_inicio_pic.Location = new System.Drawing.Point(17, 71);
            this.Data_inicio_pic.Name = "Data_inicio_pic";
            this.Data_inicio_pic.Size = new System.Drawing.Size(126, 20);
            this.Data_inicio_pic.TabIndex = 1;
            this.Data_inicio_pic.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.Data_inicio_pic.ValueChanged += new System.EventHandler(this.Data_inicio_ValueChanged);
            // 
            // Data_fim_pic
            // 
            this.Data_fim_pic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data_fim_pic.Location = new System.Drawing.Point(177, 71);
            this.Data_fim_pic.Name = "Data_fim_pic";
            this.Data_fim_pic.Size = new System.Drawing.Size(130, 20);
            this.Data_fim_pic.TabIndex = 2;
            this.Data_fim_pic.ValueChanged += new System.EventHandler(this.Data_fim_ValueChanged);
            // 
            // nome_colaboradorComboBox
            // 
            this.nome_colaboradorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nome_colaboradorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nome_colaboradorComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nome_colaboradorComboBox.DataSource = this.colaboradoresBindingSource1;
            this.nome_colaboradorComboBox.DisplayMember = "Nome_colaborador";
            this.nome_colaboradorComboBox.FormattingEnabled = true;
            this.nome_colaboradorComboBox.Location = new System.Drawing.Point(497, 70);
            this.nome_colaboradorComboBox.Name = "nome_colaboradorComboBox";
            this.nome_colaboradorComboBox.Size = new System.Drawing.Size(150, 21);
            this.nome_colaboradorComboBox.TabIndex = 3;
            this.nome_colaboradorComboBox.ValueMember = "Nome_colaborador";
            this.nome_colaboradorComboBox.SelectedIndexChanged += new System.EventHandler(this.nome_colaboradorComboBox_SelectedIndexChanged);
            // 
            // colaboradoresBindingSource1
            // 
            this.colaboradoresBindingSource1.DataMember = "colaboradores";
            this.colaboradoresBindingSource1.DataSource = this.cadastro_projetoDataSet2;
            // 
            // Button_limpar_filtro
            // 
            this.Button_limpar_filtro.BackColor = System.Drawing.SystemColors.Control;
            this.Button_limpar_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_limpar_filtro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.Button_limpar_filtro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_limpar_filtro.Location = new System.Drawing.Point(358, 68);
            this.Button_limpar_filtro.Name = "Button_limpar_filtro";
            this.Button_limpar_filtro.Size = new System.Drawing.Size(75, 23);
            this.Button_limpar_filtro.TabIndex = 0;
            this.Button_limpar_filtro.Text = "Limpar Filtro";
            this.Button_limpar_filtro.UseVisualStyleBackColor = false;
            this.Button_limpar_filtro.Click += new System.EventHandler(this.Button_limpar_filtro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Colaborador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DATA INÍCIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA FIM";
            // 
            // Funcao_ComboBox
            // 
            this.Funcao_ComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Funcao_ComboBox.DataSource = this.colaboradoresBindingSource1;
            this.Funcao_ComboBox.DisplayMember = "Funcao";
            this.Funcao_ComboBox.FormattingEnabled = true;
            this.Funcao_ComboBox.Location = new System.Drawing.Point(497, 30);
            this.Funcao_ComboBox.Name = "Funcao_ComboBox";
            this.Funcao_ComboBox.Size = new System.Drawing.Size(150, 21);
            this.Funcao_ComboBox.TabIndex = 8;
            this.Funcao_ComboBox.ValueMember = "Funcao";
            this.Funcao_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Funcao_ComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Função Colaborador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID Colaborador";
            // 
            // comboBox_Id_colaborador
            // 
            this.comboBox_Id_colaborador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Id_colaborador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Id_colaborador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox_Id_colaborador.DataSource = this.colaboradoresBindingSource1;
            this.comboBox_Id_colaborador.DisplayMember = "Id_colaborador";
            this.comboBox_Id_colaborador.FormattingEnabled = true;
            this.comboBox_Id_colaborador.Location = new System.Drawing.Point(658, 70);
            this.comboBox_Id_colaborador.Name = "comboBox_Id_colaborador";
            this.comboBox_Id_colaborador.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Id_colaborador.TabIndex = 12;
            this.comboBox_Id_colaborador.ValueMember = "Id_colaborador";
            this.comboBox_Id_colaborador.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_voltar.BackgroundImage")));
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.button_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.button_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voltar.ForeColor = System.Drawing.Color.Transparent;
            this.button_voltar.Location = new System.Drawing.Point(2, 6);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(47, 36);
            this.button_voltar.TabIndex = 22;
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // qtd_colaborador
            // 
            this.qtd_colaborador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.qtd_colaborador.AutoEllipsis = true;
            this.qtd_colaborador.AutoSize = true;
            this.qtd_colaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qtd_colaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd_colaborador.Location = new System.Drawing.Point(14, 429);
            this.qtd_colaborador.Name = "qtd_colaborador";
            this.qtd_colaborador.Size = new System.Drawing.Size(198, 13);
            this.qtd_colaborador.TabIndex = 23;
            this.qtd_colaborador.Text = "QUANTIDADE DE COLABORADORES:";
            this.qtd_colaborador.Click += new System.EventHandler(this.qtd_colaborador_Click);
            // 
            // listar_colaborad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(836, 472);
            this.Controls.Add(this.qtd_colaborador);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Id_colaborador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Funcao_ComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_limpar_filtro);
            this.Controls.Add(this.nome_colaboradorComboBox);
            this.Controls.Add(this.Data_fim_pic);
            this.Controls.Add(this.Data_inicio_pic);
            this.Controls.Add(this.colaboradoresDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listar_colaborad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE LED - COLABORADORES";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cadastro_projetoDataSet2 cadastro_projetoDataSet2;
        private System.Windows.Forms.BindingSource colaboradoresBindingSource;
        private Cadastro_projetoDataSet2TableAdapters.colaboradoresTableAdapter colaboradoresTableAdapter;
        private Cadastro_projetoDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView colaboradoresDataGridView;
        private System.Windows.Forms.DateTimePicker Data_inicio_pic;
        private System.Windows.Forms.DateTimePicker Data_fim_pic;
        private System.Windows.Forms.ComboBox nome_colaboradorComboBox;
        private System.Windows.Forms.BindingSource colaboradoresBindingSource1;
        private System.Windows.Forms.Button Button_limpar_filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Funcao_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Id_colaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label qtd_colaborador;
    }
}