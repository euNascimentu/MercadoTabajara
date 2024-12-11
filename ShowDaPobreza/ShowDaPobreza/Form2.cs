using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowDaPobreza
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void FecharPrograma(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            TituloPergunta.Visible = true;
            rdbAlternativaA.Visible = true;
            rdbAlternativaA.Checked = false;
            rdbAlternativaB.Visible = true;
            rdbAlternativaC.Visible = true;
            rdbAlternativaD.Visible = true;
            btnIniciar.Visible = false;
            btnParar.Visible = true;
            btnConfirmar.Visible = true;
            lblBoasVindas.Visible = false;
        }
    }
}
