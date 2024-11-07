using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Adicione essa referência
using System.Windows.Forms;

namespace trabalho
{
    public partial class cadastro_produto : Form
    {
        private string connectionString = "Data Source=10.1.0.112;" +
                                          "Initial Catalog=Cadastro_projeto;" +
                                          "Persist Security Info=True;" +
                                          "User ID=admin_cadastro;" +
                                          "Password=itel11TH_proTheled@2025;" +
                                          "Encrypt=False;";

        public cadastro_produto()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            // Configura MinDate e MaxDate se necessário
            data_inicioDateTimePicker.Value = DateTime.Now;
            data_terminoDateTimePicker.Value = DateTime.Now;

            // Inicia um novo registro
            this.cadastro_producao_produtoBindingSource.AddNew();

            // Define a data atual como valor padrão para novos registros
            SetDefaultDates();

            // Configura o AutoComplete 
            ConfigureAutoComplete();
        }

        private void ConfigureAutoComplete()
        {
            //NOVA CONFIGURAÇÃO DE AUTOCOMPLETE


            // Para Produto_modelo
            var autoCompleteModeloProdutos = new AutoCompleteStringCollection();
            LoadModeloProdutos(autoCompleteModeloProdutos);
            produto_modeloTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            produto_modeloTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            produto_modeloTextBox.AutoCompleteCustomSource = autoCompleteModeloProdutos;

            // Para ID do Colaborador
            var autoCompleteIdColaborador = new AutoCompleteStringCollection();
            LoadId_colaborador(autoCompleteIdColaborador);
            colaboradores_idTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            colaboradores_idTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            colaboradores_idTextBox.AutoCompleteCustomSource = autoCompleteIdColaborador;

            // Para Projeto
            var autoCompleteProjetos = new AutoCompleteStringCollection();
            LoadProjetos(autoCompleteProjetos);
            projetoTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            projetoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            projetoTextBox.AutoCompleteCustomSource = autoCompleteProjetos;

        }

        private void LoadProjetos(AutoCompleteStringCollection autoCompleteCollection)
        {
            try
            {
                string query = "SELECT DISTINCT Projeto FROM cadastro_producao_produto";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adiciona os modelos à coleção de autocompletar
                            autoCompleteCollection.Add(reader["Projeto"].ToString());
                        }
                    }
                }
            }

            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Por favor, verifique sua conexão com a internet e tente novamente", "Erro de rede ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form_principal carregar = new form_principal();
                carregar.ShowDialog();
                

            }
        }





        private void LoadModeloProdutos(AutoCompleteStringCollection autoCompleteCollection)
        {
            try
            {
                string query = "SELECT DISTINCT Produto_modelo FROM cadastro_producao_produto";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adiciona os modelos à coleção de autocompletar
                            autoCompleteCollection.Add(reader["Produto_modelo"].ToString());
                        }
                    }
                }



            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Por favor, verifique sua conexão com a internet e tente novamente", "Sem Aceeso á Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form_principal carregar = new form_principal();
                carregar.ShowDialog();
               


            }

            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Por favor, verifique sua conexão com a internet e tente novamente", "Sem Aceeso á Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form_principal carregar = new form_principal();
                carregar.ShowDialog();
                
            }
        } 

        private void LoadId_colaborador(AutoCompleteStringCollection autoCompleteCollection)
        {
            try
            {
                string query = "SELECT DISTINCT Colaboradores_id FROM cadastro_producao_produto";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adiciona os modelos à coleção de autocompletar
                            autoCompleteCollection.Add(reader["Colaboradores_id"].ToString());
                        }
                    }
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Por favor, verifique sua conexão com a internet e tente novamente", "Sem Aceeso a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form_principal carregar = new form_principal();
                carregar.ShowDialog();

            }
        }

        private void cadastro_producao_produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Garantir que a data de início e término não sejam inválidas
                EnsureValidDates();

                // Atualizar o campo Serial_number para nulo se estiver vazio
                if (this.cadastro_producao_produtoBindingSource.Current != null)
                {
                    var currentRow = (DataRowView)this.cadastro_producao_produtoBindingSource.Current;

                    // Verifica se o Serial_number está vazio ou apenas espaços
                    if (string.IsNullOrWhiteSpace(currentRow["Serial_number"].ToString()))
                    {
                        currentRow["Serial_number"] = DBNull.Value; // Define como nulo
                    }
                }

                // Validar e atualizar os dados
                this.Validate();
                this.cadastro_producao_produtoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastro_projetoDataSet);

                // Exibir mensagem de sucesso
                MessageBox.Show("Dados salvos com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Iniciar um novo registro após salvar
                this.cadastro_producao_produtoBindingSource.AddNew();
                SetDefaultDates();
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Não é permitido valores nulos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ConfigureAutoComplete();


        }

        private void EnsureValidDates()
        {
            if (data_inicioDateTimePicker.Value == DateTime.MinValue || data_inicioDateTimePicker.Value == DateTime.MaxValue)
            {
                data_inicioDateTimePicker.Value = DateTime.Now;
            }
            if (data_terminoDateTimePicker.Value == DateTime.MinValue || data_terminoDateTimePicker.Value == DateTime.MaxValue)
            {
                data_terminoDateTimePicker.Value = DateTime.Now;
            }
        }

        private void SetDefaultDates()
        {
            // Define a data atual como valor padrão para novos registros
            if (data_inicioDateTimePicker.Value == DateTime.MinValue)
            {
                data_inicioDateTimePicker.Value = DateTime.Now;
            }
            if (data_terminoDateTimePicker.Value == DateTime.MinValue)
            {
                data_terminoDateTimePicker.Value = DateTime.Now;
            }

            // Atualiza o campo de data de início e término no BindingSource
            if (this.cadastro_producao_produtoBindingSource.Current != null)
            {
                var currentRow = (DataRowView)this.cadastro_producao_produtoBindingSource.Current;
                currentRow["data_inicio"] = data_inicioDateTimePicker.Value;
                currentRow["data_termino"] = data_terminoDateTimePicker.Value;
            }
        }

        private void data_inicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Atualiza o campo de data de início no BindingSource
            if (this.cadastro_producao_produtoBindingSource.Current != null)
            {
                var currentRow = (DataRowView)this.cadastro_producao_produtoBindingSource.Current;
                currentRow["data_inicio"] = data_inicioDateTimePicker.Value;
            }
        }

        private void data_terminoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Atualiza o campo de data de término no BindingSource
            if (this.cadastro_producao_produtoBindingSource.Current != null)
            {
                var currentRow = (DataRowView)this.cadastro_producao_produtoBindingSource.Current;
                currentRow["data_termino"] = data_terminoDateTimePicker.Value;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // Lógica para deletar itens (se houver)
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar novos itens (se houver)
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void projetoTextBox_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = projetoTextBox.SelectionStart;

            // Transforma o texto em maiúsculas
            projetoTextBox.Text = projetoTextBox.Text.ToUpper();

            // Restaura o cursor à posição correta
            projetoTextBox.SelectionStart = cursorPosition;

            








        }

        private void cadastro_producao_produtoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para manipular cliques nas células do DataGridView (se necessário)
        }

        private void serial_numberTextBox_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = serial_numberTextBox.SelectionStart;

            // Transforma o texto em maiúsculas
            serial_numberTextBox.Text = serial_numberTextBox.Text.ToUpper();

            // Restaura o cursor à posição correta
            serial_numberTextBox.SelectionStart = cursorPosition;
        }

        private void cadastro_producao_produtoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            // Lógica para atualizar itens no BindingNavigator (se necessário)
        }

        private void data_inicioLabel_Click(object sender, EventArgs e)
        {
            // Lógica para manipular cliques no Label da data de início (se necessário)
        }

        private void colaboradores_idTextBox_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o texto não está vazio
            if (!string.IsNullOrEmpty(colaboradores_idTextBox.Text))
            {
                // Tenta converter o texto para um número
                if (!int.TryParse(colaboradores_idTextBox.Text, out _))
                {
                    // Exibe uma MessageBox informando que apenas números são permitidos
                    MessageBox.Show("Por favor, insira apenas números.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Limpa o TextBox
                    colaboradores_idTextBox.Text = string.Empty;
                }
            }
        }

        private void produto_modeloTextBox_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = produto_modeloTextBox.SelectionStart;

            // Transforma o texto em maiúsculas
            produto_modeloTextBox.Text = produto_modeloTextBox.Text.ToUpper();

            // Restaura o cursor à posição correta
            produto_modeloTextBox.SelectionStart = cursorPosition;
        }

        private void qtd_produtoTextBox_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = qtd_produtoTextBox.SelectionStart;

            // Transforma o texto em maiúsculas
            qtd_produtoTextBox.Text = qtd_produtoTextBox.Text.ToUpper();


            // Restaura o cursor à posição correta
            qtd_produtoTextBox.SelectionStart = cursorPosition;
        }

        private void observacao_produtoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
