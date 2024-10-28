namespace Tabajara
{
    public partial class TabajaraInicial : Form
    {
        public TabajaraInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            /* Habilita as LBL's e as TXT's para o supervisor acessar */
            lblCPFLogin.Visible = true;
            lblLoginNome.Visible = true;
            txtCPFLogin.Visible = true;
            txtNomeLogin.Visible = true;
            /* Desabilita as LBL's e as TXT's do caixa */
            lblCodUnico.Visible = false;
            lblSenhaCaixa.Visible = false;
            txtCodUnico.Visible = false;
            txtSenhaCaixa.Visible = false;
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            /* Habilita as LBL's e as TXT's para o caixa acessar */
            lblCodUnico.Visible = true;
            lblSenhaCaixa.Visible = true;
            txtCodUnico.Visible = true;
            txtSenhaCaixa.Visible = true;
            /* Desabilita as LBL's e as TXT's do supervisor */
            lblCPFLogin.Visible = false;
            lblLoginNome.Visible = false;
            txtCPFLogin.Visible = false;
            txtNomeLogin.Visible = false;
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SobreTabajara sobre = new SobreTabajara();
            sobre.ShowDialog();
        }
    }
}