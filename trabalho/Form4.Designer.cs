namespace trabalho
{
    partial class Form_tela_admin
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
            System.Windows.Forms.Label senha_usuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_tela_admin));
            this.cadastro_projetoDataSet1 = new trabalho.Cadastro_projetoDataSet1();
            this.admBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admTableAdapter = new trabalho.Cadastro_projetoDataSet1TableAdapters.AdmTableAdapter();
            this.tableAdapterManager = new trabalho.Cadastro_projetoDataSet1TableAdapters.TableAdapterManager();
            this.senha_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.Button_logar = new System.Windows.Forms.Button();
            senha_usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // senha_usuarioLabel
            // 
            senha_usuarioLabel.AutoSize = true;
            senha_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            senha_usuarioLabel.Location = new System.Drawing.Point(9, 22);
            senha_usuarioLabel.Name = "senha_usuarioLabel";
            senha_usuarioLabel.Size = new System.Drawing.Size(48, 15);
            senha_usuarioLabel.TabIndex = 4;
            senha_usuarioLabel.Text = "SENHA";
            // 
            // cadastro_projetoDataSet1
            // 
            this.cadastro_projetoDataSet1.DataSetName = "Cadastro_projetoDataSet1";
            this.cadastro_projetoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admBindingSource
            // 
            this.admBindingSource.DataMember = "Adm";
            this.admBindingSource.DataSource = this.cadastro_projetoDataSet1;
            // 
            // admTableAdapter
            // 
            this.admTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdmTableAdapter = this.admTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = trabalho.Cadastro_projetoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // senha_usuarioTextBox
            // 
            this.senha_usuarioTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.senha_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admBindingSource, "senha_usuario", true));
            this.senha_usuarioTextBox.Location = new System.Drawing.Point(69, 20);
            this.senha_usuarioTextBox.Name = "senha_usuarioTextBox";
            this.senha_usuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.senha_usuarioTextBox.TabIndex = 5;
            this.senha_usuarioTextBox.UseSystemPasswordChar = true;
            this.senha_usuarioTextBox.TextChanged += new System.EventHandler(this.senha_usuarioTextBox_TextChanged);
            // 
            // Button_logar
            // 
            this.Button_logar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Button_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_logar.Location = new System.Drawing.Point(179, 19);
            this.Button_logar.Name = "Button_logar";
            this.Button_logar.Size = new System.Drawing.Size(51, 22);
            this.Button_logar.TabIndex = 6;
            this.Button_logar.Text = "OK";
            this.Button_logar.UseVisualStyleBackColor = false;
            this.Button_logar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_tela_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(268, 62);
            this.Controls.Add(this.Button_logar);
            this.Controls.Add(senha_usuarioLabel);
            this.Controls.Add(this.senha_usuarioTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_tela_admin";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso Restrito";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.tela_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_projetoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cadastro_projetoDataSet1 cadastro_projetoDataSet1;
        private System.Windows.Forms.BindingSource admBindingSource;
        private Cadastro_projetoDataSet1TableAdapters.AdmTableAdapter admTableAdapter;
        private Cadastro_projetoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox senha_usuarioTextBox;
        private System.Windows.Forms.Button Button_logar;
    }
}