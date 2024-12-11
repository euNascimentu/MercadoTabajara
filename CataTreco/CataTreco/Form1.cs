using MySql.Data.MySqlClient;
using System;

namespace CataTreco
{
    public partial class CataTreco : Form
    {
        public CataTreco()
        {
            InitializeComponent();
        }

        private void CataTreco_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=CataTreco;User ID=root;Password='';";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                // Tentando abrir a conexão com o banco de dados
                conn.Open();
                MessageBox.Show("Conexão estabelecida com sucesso!");

                // Aqui você pode fazer operações no banco de dados, como consultas ou inserções.

            }
            catch (Exception ex)
            {
                // Se ocorrer um erro, ele será exibido
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }
    }
}