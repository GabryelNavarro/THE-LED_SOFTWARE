using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace trabalho
{
    public partial class add_colaborador : Form
    {
        public add_colaborador()
        {
            InitializeComponent();
        }

        private void add_colaborador_Load(object sender, EventArgs e)
        {
            // Carrega os dados da tabela 'cadastro_projetoDataSet2.colaboradores'
            this.colaboradoresTableAdapter.Fill(this.cadastro_projetoDataSet2.colaboradores);

            // Inicia um novo registro
            this.colaboradoresBindingSource.AddNew();

            // Define a data atual como valor padrão para novos registros
            SetDefaultDates();

            data_admissaoDateTimePicker.Value = DateTime.Now;
        }

        private void colaboradoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar e atualizar os dados
                this.Validate();
                this.colaboradoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cadastro_projetoDataSet2);

              

                if (this.colaboradoresBindingSource.Current != null)
                {
                    var currentRow = (DataRowView)this.colaboradoresBindingSource.Current;
                    int colaboradorId = Convert.ToInt32(currentRow["id_colaborador"]); 

                    // Copiar o ID do colaborador para a área de transferência
                    Clipboard.SetText(colaboradorId.ToString());

                    // Exibir mensagem de sucesso com o ID do colaborador
                    MessageBox.Show($"Dados salvos com sucesso! ID do colaborador: {colaboradorId} (copiado para a área de transferência)",
                                    "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }








                // Iniciar um novo registro após salvar
                this.colaboradoresBindingSource.AddNew();
                SetDefaultDates();
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Não é permitido valores nulos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para garantir que as datas sejam válidas
        private void EnsureValidDates()
        {
            if (data_admissaoDateTimePicker.Value == DateTime.MinValue || data_admissaoDateTimePicker.Value == DateTime.MaxValue)
            {
                data_admissaoDateTimePicker.Value = DateTime.Now;
            }
            if (data_admissaoDateTimePicker.Value == DateTime.MinValue || data_admissaoDateTimePicker.Value == DateTime.MaxValue)
            {
                data_admissaoDateTimePicker.Value = DateTime.Now;
            }
        }

        // Método para definir as datas padrão
        private void SetDefaultDates()
        {
            if (data_admissaoDateTimePicker.Value == DateTime.MinValue)
            {
                data_admissaoDateTimePicker.Value = DateTime.Now;
            }
            if (data_admissaoDateTimePicker.Value == DateTime.MinValue)
            {
                data_admissaoDateTimePicker.Value = DateTime.Now;
            }

            // Atualizar o campo de data no BindingSource
            if (this.colaboradoresBindingSource.Current != null)
            {
                var currentRow = (DataRowView)this.colaboradoresBindingSource.Current;
                currentRow["Data_admissao"] = data_admissaoDateTimePicker.Value;
                
            }
        }

        private void data_inicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.colaboradoresBindingSource.Current != null)
            {
                var currentRow = (DataRowView)this.colaboradoresBindingSource.Current;
                currentRow["Data_admissao"] = data_admissaoDateTimePicker.Value;
            }
        }

        private void data_terminoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.colaboradoresBindingSource.Current != null)
            {
                var currentRow = (DataRowView)this.colaboradoresBindingSource.Current;
                currentRow["Data_admissao"] = data_admissaoDateTimePicker.Value;
            }
        }

        // Eventos adicionais, se necessário
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

        private void colaboradores_idTextBox_TextChanged(object sender, EventArgs e)
        {
            // Lógica para manipular mudanças no TextBox do ID do colaborador (se necessário)
        }

        private void data_admissaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data_admissaoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
