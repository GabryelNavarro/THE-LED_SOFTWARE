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
    public partial class form_principal : Form

    {

        public form_principal()
        {
            InitializeComponent();
           
    }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastro_producao_produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastro_producao_produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastro_projetoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastro_projetoDataSet.cadastro_producao_produto'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void cadastro_producao_produtoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }




            private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void adicionarColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_tela_admin cadastro_usuario = new Form_tela_admin();
            cadastro_usuario.ShowDialog();
        }

        private void listarColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listar_colaborad listar_colaborador = new listar_colaborad();
            listar_colaborador.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cadastro_produto cadastro_produtos = new cadastro_produto();
                this.Hide(); // Esconde o Form1
                cadastro_produtos.ShowDialog(); // Abre o Form2 de forma modal
                this.Show(); // Mostra o Form1 novamente quando o Form2 for fechado
            }

            catch (NoNullAllowedException)
            {
                MessageBox.Show("Não é possível criar um novo cadastro sem finalizar o atual!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);






            }

            finally
            {
                this.Show();
            }


        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                cadastro_produto cadastro_produtos = new cadastro_produto();
               
                cadastro_produtos.ShowDialog(); // Abre o Form2 de forma modal
                this.Show(); // Mostra o Form1 novamente quando o Form2 for fechado
            }

            catch (NoNullAllowedException)
            {
                MessageBox.Show("Não é possível criar um novo cadastro sem finalizar o atual!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);






            }

            finally
            {
                this.Show();
            }


        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_tela_admin cadastro_usuario = new Form_tela_admin();
            cadastro_usuario.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listagem_producao listar = new listagem_producao();
            listar.ShowDialog();
        }

        private void colaboradoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listar_colaborad listar_colaborador = new listar_colaborad();
            listar_colaborador.ShowDialog();
        }

        private void teste_Click(object sender, EventArgs e)
        {
            listagem_producao listar_pod = new listagem_producao();
            listar_pod.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Para encerrar o aplicativo de forma brusca
            e.Cancel = true; // Cancela o fechamento do formulário

            // Utiliza o método Environment.Exit(0) para fechar o aplicativo
            Environment.Exit(0);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}


