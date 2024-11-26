namespace trabalho
{
    partial class form_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_principal));
            this.cadastro_producao_produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.cadastro_producao_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_projetoDataSet = new trabalho.Cadastro_projetoDataSet();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.colaboradoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_producao_produtoTableAdapter = new trabalho.Cadastro_projetoDataSetTableAdapters.cadastro_producao_produtoTableAdapter();
            this.tableAdapterManager = new trabalho.Cadastro_projetoDataSetTableAdapters.TableAdapterManager();
            this.cadastroproducaoprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_producao_produtoBindingNavigator)).BeginInit();
            this.cadastro_producao_produtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_producao_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroproducaoprodutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastro_producao_produtoBindingNavigator
            // 
            this.cadastro_producao_produtoBindingNavigator.AddNewItem = null;
            this.cadastro_producao_produtoBindingNavigator.AutoSize = false;
            this.cadastro_producao_produtoBindingNavigator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cadastro_producao_produtoBindingNavigator.BindingSource = this.cadastro_producao_produtoBindingSource;
            this.cadastro_producao_produtoBindingNavigator.CountItem = null;
            this.cadastro_producao_produtoBindingNavigator.DeleteItem = null;
            this.cadastro_producao_produtoBindingNavigator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cadastro_producao_produtoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cadastro_producao_produtoBindingNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cadastro_producao_produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripButton2});
            this.cadastro_producao_produtoBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.cadastro_producao_produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastro_producao_produtoBindingNavigator.MoveFirstItem = null;
            this.cadastro_producao_produtoBindingNavigator.MoveLastItem = null;
            this.cadastro_producao_produtoBindingNavigator.MoveNextItem = null;
            this.cadastro_producao_produtoBindingNavigator.MovePreviousItem = null;
            this.cadastro_producao_produtoBindingNavigator.Name = "cadastro_producao_produtoBindingNavigator";
            this.cadastro_producao_produtoBindingNavigator.PositionItem = null;
            this.cadastro_producao_produtoBindingNavigator.Size = new System.Drawing.Size(1011, 33);
            this.cadastro_producao_produtoBindingNavigator.Stretch = true;
            this.cadastro_producao_produtoBindingNavigator.TabIndex = 0;
            this.cadastro_producao_produtoBindingNavigator.TabStop = true;
            this.cadastro_producao_produtoBindingNavigator.Text = "bindingNavigator1";
            this.cadastro_producao_produtoBindingNavigator.RefreshItems += new System.EventHandler(this.cadastro_producao_produtoBindingNavigator_RefreshItems);
            // 
            // cadastro_producao_produtoBindingSource
            // 
            this.cadastro_producao_produtoBindingSource.DataMember = "cadastro_producao_produto";
            this.cadastro_producao_produtoBindingSource.DataSource = this.cadastro_projetoDataSet;
            // 
            // cadastro_projetoDataSet
            // 
            this.cadastro_projetoDataSet.DataSetName = "Cadastro_projetoDataSet";
            this.cadastro_projetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.toolStripSeparator4,
            this.colaboradoresToolStripMenuItem});
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 30);
            this.toolStripButton1.Text = "CADASTRO";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.produtosToolStripMenuItem.Text = "INCLUIR PRODUTOS";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(294, 6);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.colaboradoresToolStripMenuItem.Text = "CADASTRAR COLABORADOR";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.toolStripSeparator3,
            this.colaboradoresToolStripMenuItem1});
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(81, 30);
            this.toolStripButton2.Text = "SISTEMA";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(316, 26);
            this.produtosToolStripMenuItem1.Text = "PRODUTOS NO SISTEMA";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(313, 6);
            // 
            // colaboradoresToolStripMenuItem1
            // 
            this.colaboradoresToolStripMenuItem1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaboradoresToolStripMenuItem1.Name = "colaboradoresToolStripMenuItem1";
            this.colaboradoresToolStripMenuItem1.Size = new System.Drawing.Size(316, 26);
            this.colaboradoresToolStripMenuItem1.Text = "COLABORADORES NO SISTEMA";
            this.colaboradoresToolStripMenuItem1.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem1_Click);
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
            // cadastroproducaoprodutoBindingSource
            // 
            this.cadastroproducaoprodutoBindingSource.DataMember = "cadastro_producao_produto";
            this.cadastroproducaoprodutoBindingSource.DataSource = this.cadastro_projetoDataSet;
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1011, 554);
            this.Controls.Add(this.cadastro_producao_produtoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  THE LED - GERAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.form_principal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_producao_produtoBindingNavigator)).EndInit();
            this.cadastro_producao_produtoBindingNavigator.ResumeLayout(false);
            this.cadastro_producao_produtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_producao_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroproducaoprodutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cadastro_projetoDataSet cadastro_projetoDataSet;
        private System.Windows.Forms.BindingSource cadastro_producao_produtoBindingSource;
        private Cadastro_projetoDataSetTableAdapters.cadastro_producao_produtoTableAdapter cadastro_producao_produtoTableAdapter;
        private Cadastro_projetoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.BindingNavigator cadastro_producao_produtoBindingNavigator;
        private System.Windows.Forms.BindingSource cadastroproducaoprodutoBindingSource;
    }
}

