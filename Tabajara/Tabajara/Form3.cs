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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbCupomFiscal_Enter(object sender, EventArgs e)
        {
            txtCupomFiscal.Enabled = false;
            btnAbreCupom.Enabled = false;
        }

        private void ckbCupomFiscal_CheckedChanged(object sender, EventArgs e)
        {
            txtCupomFiscal.Enabled = true;
            btnAbreCupom.Enabled = true;
        }

        private void grbProdutoAtual_Enter(object sender, EventArgs e)
        {
            grbProdutoAtual.Enabled = false;
        }

        private void grbDetalhesCupom_Enter(object sender, EventArgs e)
        {
            grbDetalhesCupom.Enabled = false;
        }

        private void grbFormasPagamento_Enter(object sender, EventArgs e)
        {
            grbFormasPagamento.Enabled = false;
        }

        private void btnAbreCupom_Click(object sender, EventArgs e)
        {
            grbFormasPagamento.Enabled = true;
            grbDetalhesCupom.Enabled = true;
            grbProdutoAtual.Enabled = true;
        }
    }
}
