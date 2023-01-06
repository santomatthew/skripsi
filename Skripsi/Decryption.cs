using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Skripsi
{
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void keyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encryptform encryptform = new Encryptform();
            encryptform.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_ciphertext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void browse_file_Click(object sender, EventArgs e)
        {
            nama_file.Text = "";
            ciphertext.Text = "";
            try
            {

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Enrypted Files|*.enc";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    nama_file.Text = Path.GetFileName(open.FileName);
                    string nama = open.FileName.Substring(0, open.FileName.Length);
                    FileStream fstream = new FileStream(nama, FileMode.Open, FileAccess.ReadWrite);
                    StreamReader sreader = new StreamReader(fstream);
                    sreader.BaseStream.Seek(0, SeekOrigin.Begin);
                    ciphertext.Text = sreader.ReadToEnd();
                    sreader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
