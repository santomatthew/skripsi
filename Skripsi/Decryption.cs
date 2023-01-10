using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Skripsi
{
    public partial class Decryption : Form
    {
        int[,] matriksB = { {0,0 },{ 0, 0 } };
        int range = 0;
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
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Private Key (*.privatekey)|*.privatekey";
                open.FileName = "";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(open.FileName);
                    int linesTemp = 0;
                    for(int i = 0; i <= 1; i++)
                    {
                        for(int j = 0; j <= 1; j++)
                        {
                            matriksB[i, j] = int.Parse(lines[linesTemp]);
                            linesTemp++;
                        }
                    }

                    Console.WriteLine(matriksB[0, 0]);
                    Console.WriteLine(matriksB[0, 1]);
                    Console.WriteLine(matriksB[1, 0]);
                    Console.WriteLine(matriksB[1, 1]);

                    //matriksB = Array.ConvertAll(kunciline, int.Parse);
                    range = int.Parse(lines[lines.Length - 1]);
                    kprivate.Text = lines[lines.Length - 2];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if(kprivate.Text == "")
            {
                MessageBox.Show("Masukkan kunci private");
            }
            else if(ciphertext.Text == "")
            {
                MessageBox.Show("Masukkan ciphertext");
            }
            else
            {
                int[,] matriksK2 = { { 0, 0 }, { 0, 0 } };

                string[] cipherteks = ciphertext.Text.Split("");

                for(int i=0;i<cipherteks.Length; i++)
                {
                    Console.WriteLine(cipherteks[i]);
                }

                int pangkatMatriksK2 = int.Parse(kprivate.Text);
                for (int i = 1; i < pangkatMatriksK2; i++)
                {
                    if (i == 1)
                    {
                        for (int j = 0; j <= 3; j++)
                        {
                            if (j == 0)
                            {
                                matriksK2[0, 0] += ((matriksB[0, 0] * matriksB[0, 0]) + (matriksB[0, 1] * matriksB[1, 0]));
                            }
                            else if (j == 1)
                            {
                                matriksK2[0, 1] += ((matriksB[0, 1] * matriksB[0, 0]) + (matriksB[0, 1] * matriksB[1, 1]));
                            }
                            else if (j == 2)
                            {
                                matriksK2[1, 0] += ((matriksB[1, 0] * matriksB[0, 0]) + (matriksB[1, 1] * matriksB[1, 0]));
                            }
                            else if (j == 3)
                            {
                                matriksK2[1, 1] += ((matriksB[1, 0] * matriksB[0, 1]) + (matriksB[1, 1] * matriksB[1, 1]));
                            }
                        }

                    }
                    else
                    {
                        int[,] helperMatriksK2 =
                         {
                            { matriksK2[0, 0], matriksK2[0, 1] },
                            { matriksK2[1, 0], matriksK2[1, 1] }
                        };
                        for (int j = 0; j <= 3; j++)
                        {
                            if (j == 0)
                            {
                                matriksK2[0, 0] = ((helperMatriksK2[0, 0] * matriksB[0, 0]) + (helperMatriksK2[0, 1] * matriksB[1, 0])) % range;

                            }
                            else if (j == 1)
                            {
                                matriksK2[0, 1] = ((helperMatriksK2[0, 0] * matriksB[0, 1]) + (helperMatriksK2[0, 1] * matriksB[1, 1])) % range;
                            }
                            else if (j == 2)
                            {
                                matriksK2[1, 0] = ((helperMatriksK2[1, 0] * matriksB[0, 0]) + (helperMatriksK2[1, 1] * matriksB[1, 0])) % range;
                            }
                            else if (j == 3)
                            {
                                matriksK2[1, 1] = ((helperMatriksK2[1, 0] * matriksB[0, 1]) + (helperMatriksK2[1, 1] * matriksB[1, 1])) % range;
                            }
                        }
                    }

                }

                //string[] ciphertext = ciphertext.Text
                //for (int i = 0; i)
            }
        }
    }
}
