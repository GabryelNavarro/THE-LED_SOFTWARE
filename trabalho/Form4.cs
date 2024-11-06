using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace trabalho
{
    public partial class Form_tela_admin : Form
    {
        // String de conexão ao SQL Server
        string connectionString = @"Data Source=10.1.0.112;Initial Catalog=Cadastro_projeto;
            Persist Security Info=True;User ID=admin_cadastro;Password=itel11TH_proTheled@2025;Encrypt=False";

        public Form_tela_admin()
        {
            InitializeComponent();
        }

        private void tela_admin_Load(object sender, EventArgs e)
        {
            // Código a ser executado quando o formulário carregar (se necessário)
        }

        // Evento para o botão de login
        private void button1_Click(object sender, EventArgs e)
        {
           
            string senha = senha_usuarioTextBox.Text;

            // Validar o usuário e senha
            if (ValidarUsuario(senha))
            {
                MessageBox.Show("Acesso autorizado","Acesso Restrito",MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    add_colaborador cadastro_colaborador = new add_colaborador();
                    this.Hide();
                    cadastro_colaborador.ShowDialog();
                    this.Show();
                    Close();
                }

                catch (NoNullAllowedException) {
                    MessageBox.Show("Valores nulos não são permitidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }






            }
            else
            {


                MessageBox.Show("Senha Incorreta!", "Erro de acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);


               
            }
        }

        // Método para validar o usuário
        private bool ValidarUsuario(string senha)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Query SQL para validar o usuário
                    string query = "SELECT COUNT(1) FROM Adm WHERE senha_usuario=@Senha";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    // Executar a query e verificar o resultado
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
                catch (Exception ex)
                {


                    
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);

                  

                    return false;
                }
            }
        }

        // Event handlers vazios podem ser removidos se não forem usados
        private void nome_usuario_admTextBox_TextChanged(object sender, EventArgs e)
        {
            // Pode ser removido se não precisar
        }

        private void senha_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            // Pode ser removido se não precisar
        }
    }
}
