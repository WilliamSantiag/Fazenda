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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void cadastrarprodutoButton_Click(object sender, EventArgs e)
        {
            // Dados do produto capturados dos TextBoxes
            string nome = nomeprodutoTextBox.Text;
            string tipo = tipoTextBox.Text;
            int quantidade;

            // Verifica se a quantidade é um número válido
            if (!int.TryParse(quantidadeTextBox.Text, out quantidade))
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para a quantidade.");
                return;
            }

            // String de conexão com o banco de dados
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Comando SQL para inserir o produto
                    string query = "INSERT INTO produto (nome, tipo, quantidade) VALUES (@nome, @tipo, @quantidade)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Parâmetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);

                    // Executa o comando
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!");
                        LimparCampos(); // Limpa os campos após o cadastro
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o produto.");
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
            nomeprodutoTextBox.Clear();
            tipoTextBox.Clear();
            quantidadeTextBox.Clear();
        }
    }
    }

