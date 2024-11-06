    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    namespace trabalho
    {
        public partial class listagem_producao : Form
        {
            public listagem_producao()
            {
                InitializeComponent();

            }

            private void AplicarFiltro()
            {
                DateTime data_inicio = date_pic_inicio.Value.Date;
                DateTime data_final = date_pic_final.Value.Date;

                // Se a data final não estiver marcada, usa a data atual
                if (!date_pic_final.Checked)
                {
                    data_final = DateTime.Now.Date;
                }

                // Adiciona 1 dia para incluir o final do dia
                data_final = data_final.AddDays(1);

                // Inicializa o filtro com base nas datas
                string filtro = $"data_inicio >= '{data_inicio:yyyy-MM-dd}' AND data_inicio < '{data_final:yyyy-MM-dd}'";



                // Verifica se um nome específico está selecionado
                if (ComboBox_nome.SelectedValue != null && ComboBox_nome.SelectedIndex != 0)
                {
                    string nome_selecionado = ComboBox_nome.SelectedValue.ToString();
                    filtro += $" AND Nome_colaborador = '{nome_selecionado}'";
                }

                // Verifica se um produto específico está selecionado
                if (comboBox2.SelectedValue != null && comboBox2.SelectedIndex != 0)
                {
                    string produto_selecionado = comboBox2.SelectedValue.ToString();
                    filtro += $" AND Produto_modelo = '{produto_selecionado}'";
                }

                // Verifica se um projeto específico está selecionado
                if (comboBox4.SelectedValue != null && comboBox4.SelectedIndex != 0)
                {
                    string projeto_selecionado = comboBox4.SelectedValue.ToString();
                    filtro += $" AND Projeto = '{projeto_selecionado}'";
                }

                // Verifica se uma situação específica está selecionada
                if (comboBox3.SelectedValue != null && comboBox3.SelectedIndex != 0)
                {
                    string situacao_selecionada = comboBox3.SelectedValue.ToString();
                    filtro += $" AND Situacao = '{situacao_selecionada}'";
                }

                if (comboBox6.SelectedValue != null && comboBox6.SelectedIndex != 0)
                {
                    int identicacao_colaborador_selecionado = Convert.ToInt32(comboBox6.SelectedValue);
                    filtro += $"AND Colaboradores_id = '{identicacao_colaborador_selecionado}'";
                }


                if (comboBox5.SelectedValue != null && comboBox5.SelectedIndex != 0)
                {
                    string serial_selecionado = comboBox5.Text;
                    filtro += $"AND Serial_number = '{serial_selecionado}'";
                }



                // Aplica o filtro no BindingSource
                cadastro_producao_produtoBindingSource3.Filter = filtro;
                AtualizarLabelTotal();
            }

            private void AtualizarLabelTotal()
            {
                // Atualiza o total de linhas
                int totalLinhas = cadastro_producao_produtoDataGridView2.Rows.Count;
                labelTotalP.Text = $"LINHAS: {totalLinhas}";


                float totalQtdProduto = 0;

                // Percorre todas as linhas do DataGridView e soma a quantidade de produtos na coluna "Qtd_produto"
                foreach (DataGridViewRow row in cadastro_producao_produtoDataGridView2.Rows)
                {
                    // Ignora a última linha vazia que é adicionada automaticamente
                    if (!row.IsNewRow && row.Cells["dataGridViewTextBoxColumn29"].Value != null)
                    {
                        // Tenta converter o valor da célula para um número e acumula no total
                        if (float.TryParse(row.Cells["dataGridViewTextBoxColumn29"].Value.ToString(), out float valor))
                        {
                            totalQtdProduto += valor;
                        }
                    }
                }

                // Atualiza a Label com a soma total de produtos
                total_produtos.Text = $"TOTAL DE PRODUTOS: {totalQtdProduto}";
            





            }

        private void listagem_Load(object sender, EventArgs e)
        {
            try {


                this.cadastro_producao_produtoTableAdapter3.Fill(this.cadastro_projetoDataSet3.cadastro_producao_produto);
                    }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler dados do Servidor. Por favor, reinicie o programa!",
                "Erro no sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Preencher a ComboBox com nomes de colaboradores únicos
            var nomesDistintos = cadastro_projetoDataSet3.cadastro_producao_produto
                    .AsEnumerable()
                    .Select(row => row.Field<string>("Nome_colaborador"))
                    .Distinct()
                    .ToList();

                // Adicionar o valor "TODOS OS REGISTROS" para exibir todos os registros
                nomesDistintos.Insert(0, "TODOS OS REGISTROS");

                // Definir a lista como a fonte de dados da ComboBox
                ComboBox_nome.DataSource = nomesDistintos;

                // Define a data inicial
                date_pic_inicio.Value = new DateTime(2023, 1, 1);
                date_pic_final.Value = DateTime.Now; // Define como a data atual

                // Preencher a ComboBox de Produto_modelo
                var produto_modelo = cadastro_projetoDataSet3.cadastro_producao_produto
                     .AsEnumerable()
                    .Select(row => row.Field<string>("Produto_modelo"))
                    .Distinct()
                    .ToList();
                produto_modelo.Insert(0, "TODOS PRODUTOS");
                comboBox2.DataSource = produto_modelo;

                // Preencher a ComboBox de Projetos
                var nome_projeto = cadastro_projetoDataSet3.cadastro_producao_produto
                    .AsEnumerable()
                    .Select(row => row.Field<string>("Projeto"))
                    .Distinct()
                    .ToList();
                nome_projeto.Insert(0, "TODOS PROJETOS");
                comboBox4.DataSource = nome_projeto;

                // Preencher a ComboBox de Situação
                var situacao = cadastro_projetoDataSet3.cadastro_producao_produto
                    .AsEnumerable()
                    .Select(row => row.Field<string>("Situacao"))
                    .Distinct()
                    .ToList();
                situacao.Insert(0, "TODAS SITUAÇÕES");
                comboBox3.DataSource = situacao;

                var identificador_colaborador = cadastro_projetoDataSet3.cadastro_producao_produto
                    .AsEnumerable()
                    .Select(row => row.Field<int>("Colaboradores_id"))
                    .Distinct()
                    .Select(id => id.ToString())
                    .ToList();
                identificador_colaborador.Insert(0, "TODOS COLABORADORES");
                comboBox6.DataSource = identificador_colaborador;
            


                var identificador_serial = cadastro_projetoDataSet3.cadastro_producao_produto
                   .AsEnumerable()
                   .Select(row => row.Field<string>("Serial_number"))
                   .Distinct()
                   .ToList();
                identificador_serial.Insert(0, "TODOS");
                comboBox5.DataSource = identificador_serial;

                cadastro_producao_produtoDataGridView2.ClearSelection();



            }

            private void ComboBox_nome_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Chama o método de aplicar filtro quando a seleção mudar
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void date_pic_final_ValueChanged(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void date_pic_inicio_ValueChanged(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void button_limpar_filtro_Click(object sender, EventArgs e)
            {
                // Remove o filtro e redefine todas as ComboBoxes e DateTimePickers para valores padrão
                cadastro_producao_produtoBindingSource3.RemoveFilter();
                ComboBox_nome.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                comboBox6.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;
                cadastro_producao_produtoDataGridView2.ClearSelection();

                // Redefinir os DateTimePickers
                date_pic_inicio.Value = new DateTime(2023, 1, 1);
                date_pic_final.Value = DateTime.Now;
                AtualizarLabelTotal();
            }

            // Métodos para os eventos das ComboBoxes específicas
            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void date_pic_inicio_ValueChanged_1(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void date_pic_final_ValueChanged_1(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void cadastro_producao_produtoDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                cadastro_producao_produtoDataGridView2.ClearSelection();
            }

            private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
            {
                AplicarFiltro();
                AtualizarLabelTotal();
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
            
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click_1(object sender, EventArgs e)
            {
                this.Close();
           
            }

            private void total_produtos_Click(object sender, EventArgs e)
            {

            }
        }

    }


