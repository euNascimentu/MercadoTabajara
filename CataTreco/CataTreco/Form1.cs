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
                // Tentando abrir a conex�o com o banco de dados
                conn.Open();
                MessageBox.Show("Conex�o estabelecida com sucesso!");

                // Aqui voc� pode fazer opera��es no banco de dados, como consultas ou inser��es.

            }
            catch (Exception ex)
            {
                // Se ocorrer um erro, ele ser� exibido
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }
    }
}