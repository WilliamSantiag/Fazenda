using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fazenda
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void cadastrarfunButton_Click(object sender, EventArgs e)
        {
            // Captura os dados do usuário e senha dos TextBoxes
            string usuario = usuariocaTextBox.Text;
            string senha = senhacaTextBox.Text;

            // Validação básica para garantir que os campos não estejam vazios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // String de conexão com o banco de dados
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Comando SQL para inserir o usuário na tabela Funcionario
                    string query = "INSERT INTO Funcionario (usuario, senha) VALUES (@usuario, @senha)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Parâmetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha); // Recomenda-se criptografar a senha antes de armazenar

                    // Executa o comando
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                        LimparCampos(); // Limpa os campos após o cadastro
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o usuário.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            usuariocaTextBox.Clear();
            senhacaTextBox.Clear();
        }


    }
}

