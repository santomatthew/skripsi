namespace Skripsi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void keyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encryptform encryptform = new Encryptform();
            encryptform.Show();
            this.Hide();
        }
    }
}
