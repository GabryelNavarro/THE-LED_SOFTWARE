using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho
{
    public partial class listar_colaborad : Form
    {
        public listar_colaborad()
        {
            InitializeComponent();
        }

        private void colaboradoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colaboradoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastro_projetoDataSet2);
        }

        private void colaboradoresDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // CONTA NUMERO DE LINHAS
            int rowCount = colaboradoresDataGridView.Rows.Count;

            // SE A LINHA DE NOVA ENTRADA ESTIVER VISÍVEL, SUBITRAI POR 1 DA CONTAGEM TOTAL
            if (colaboradoresDataGridView.AllowUserToAddRows)
            {
                rowCount -= 1;
            }

            // Atualiza o texto do Label com a contagem de linhas
            qtd_colaborador.Text = "QUANTIDADE DE COLABORADORES:  " + rowCount.ToString();
        }


    

        private void Form5_Load(object sender, EventArgs e)
        {
            // Esta linha de código carrega dados na tabela 'cadastro_projetoDataSet2.colaboradores'.
            try
            {
                this.colaboradoresTableAdapter.Fill(this.cadastro_projetoDataSet2.colaboradores);
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao ler dados do Servidor. Por favor, reinicie o programa!",
                "Erro no sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //---------------------------------------------------
            //COMBOX FUNÇÃO

            // Preencher a ComboBox com funções únicas, sem aplicar filtro inicial
            var funcoesDistintas = cadastro_projetoDataSet2.colaboradores
                .AsEnumerable()
                .Select(row => row.Field<string>("Funcao"))
                .Distinct()
                .ToList();

            // Adicionar um item vazio à ComboBox para que, inicialmente, nada seja filtrado
            funcoesDistintas.Insert(0, "TODOS OS REGISTROS");

            // Associar as funções únicas à ComboBox
            Funcao_ComboBox.DataSource = funcoesDistintas;

            //COMBOBOX FUNÇÃO
            //------------------------------------------------------

            //COMBOBOX NOME COLABORADOR
            var nome_Colaborador = cadastro_projetoDataSet2.colaboradores
                .AsEnumerable()
                .Select(row => row.Field<string>("Nome_colaborador"))
                .Distinct()
                .ToList();
            nome_Colaborador.Insert(0, "TODOS OS REGISTROS");
            
            nome_colaboradorComboBox.DataSource = nome_Colaborador;

            //COMBOX ID COLABORADOR
            var id_colaborador = cadastro_projetoDataSet2.colaboradores
                .AsEnumerable()
                .Select(row => row.Field<int>("Id_colaborador"))
                .Distinct()
                .Select(id => id.ToString())
                .ToList();
            id_colaborador.Insert(0, "TODOS OS REGISTROS");
            comboBox_Id_colaborador.DataSource = id_colaborador;
           
            colaboradoresDataGridView.ClearSelection();
           





        }
       
        private void Data_inicio_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
           
        }

        private void Data_fim_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
            
        }

        private void AplicarFiltro()
        {
            DateTime Data_inicio = Data_inicio_pic.Value.Date;
            DateTime Data_fim = Data_fim_pic.Value.Date;

            // Ajusta o filtro para a data, se Data_fim não for especificada
            if (!Data_fim_pic.Checked)
            {
                Data_fim = DateTime.Now.Date;
            }

            Data_fim = Data_fim.AddDays(1);
           
            // Cria o filtro com base nas datas
            string filtro = $"Data_admissao >= '{Data_inicio:yyyy-MM-dd}' AND Data_admissao < '{Data_fim:yyyy-MM-dd}'";

            if(nome_colaboradorComboBox.SelectedValue != null && nome_colaboradorComboBox.SelectedIndex != 0)
            {
                string nome_colaborador = nome_colaboradorComboBox.SelectedValue.ToString();
                filtro += $"AND Nome_colaborador = '{nome_colaborador}'";
            }

            if(comboBox_Id_colaborador.SelectedValue != null && comboBox_Id_colaborador.SelectedIndex != 0)
            {
                int id_colaborador_selected = Convert.ToInt32(comboBox_Id_colaborador.SelectedValue);
                filtro += $"AND Id_colaborador = '{id_colaborador_selected}'";
            }

            if(Funcao_ComboBox.SelectedValue != null && Funcao_ComboBox.SelectedIndex != 0)
            {
                string funcao_colaborador = Funcao_ComboBox.SelectedValue.ToString();
                filtro += $"AND Funcao = '{funcao_colaborador}'";
            }

         

           
            // Aplica o filtro ao BindingSource
            colaboradoresBindingSource.Filter = filtro;
            
           

        }

        private void nome_colaboradorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
            

        }

        private void Button_limpar_filtro_Click(object sender, EventArgs e)
        {
            //REMOVE FILTROS
           colaboradoresBindingSource.RemoveFilter();
            //

            //SELEÇÃO INDICE 0 (TODOS OS DADOS)
           nome_colaboradorComboBox.SelectedIndex = 0;
           Funcao_ComboBox.SelectedIndex = 0;
           comboBox_Id_colaborador.SelectedIndex = 0;



            //LIMPA SELECAO NA TABELA
            colaboradoresDataGridView.ClearSelection();
            //

            //REDEFINIR DATAS
            Data_fim_pic.Value = DateTime.Now;
            Data_inicio_pic.Value = new DateTime(2023, 1, 1);
            //
           
        }

        private void Funcao_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
            

        }

        private void colaboradoresDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            colaboradoresDataGridView.ClearSelection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void qtd_colaborador_Click(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
