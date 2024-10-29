using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabajara
{
    public partial class Supervisor : Form
    {
        public Supervisor()
        {
            InitializeComponent();
        }

        private void btnVoltarIncio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbCaixa_CheckedChanged(object sender, EventArgs e)
        {
            panelCaixa.BringToFront();
            panelCaixa.Visible = true;
        }
        private void rdbProduto_CheckedChanged(object sender, EventArgs e)
        {
            panelProduto.BringToFront();
            panelProduto.Visible = true;
        }
    }
}
