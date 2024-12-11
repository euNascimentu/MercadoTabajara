using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashScreen app = new SplashScreen();

            // Exibir a SplashScreen
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();

            // Simular tempo de carregamento (exemplo: 3 segundos)
            Thread.Sleep(3000);

            // Fechar a SplashScreen
            splashScreen.Close();

            // Iniciar o formulário principal
            Form1 mainWindow = new Form1();
            mainWindow.Show();

            // Rodar a aplicação
            app.Run(mainWindow);
        }
    }
}
