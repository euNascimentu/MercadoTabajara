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
            Supervisor supervisor = new Supervisor();
            supervisor.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.ShowDialog();
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