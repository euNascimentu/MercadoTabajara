﻿using System;
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
    public partial class TelaDeCarregamento : Form
    {
        public TelaDeCarregamento()
        {
            InitializeComponent();
        }

        private void TelaDeCarregamento_Load(object sender, EventArgs e)
        {


            //private void progressBar1_Click(object sender, EventArgs e)
            //{

            //}    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                TabajaraInicial telaCarregar = new TabajaraInicial();
                telaCarregar.Show();
                this.Hide();
            }
        }
    }
}
