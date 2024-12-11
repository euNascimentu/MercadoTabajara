namespace ShowDaPobreza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FecharPrograma(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(9);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form2 showDaPobreza = new Form2();
                showDaPobreza.Show();
                this.Hide();
            }
        }
    }
}