using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Skripsi
{
    public partial class Encryptform : Form
    {

        int[,] matriksB = { { 0, 0 },{ 0, 0 } };
        int[,] kuncipub = { { 0, 0 }, { 0, 0 } };
        int range;
        public Encryptform()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void keyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void browse_file_Click(object sender, EventArgs e)
        {
            nama_file.Text = null;
            plaintext.Text = null;
            DocX dokumen;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Docx Files|*.docx";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    dokumen = DocX.Load(open.FileName);
                    String teks_tampilan = "";
                    int banyak_paragraph = dokumen.Paragraphs.Count;
                    for (int i = 0; i < banyak_paragraph; i++)
                    {
                        teks_tampilan += dokumen.Paragraphs[i].Text;
                        teks_tampilan += "\n";
                    }
                    plaintext.Text = teks_tampilan;
                    nama_file.Text = Path.GetFileName(open.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kpublik.Text = null;
            int[,] reset =  { { 0, 0 }, { 0, 0 } };
            matriksB = reset;
            kuncipub = reset;

            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Public Key (*.publickey)|*.publickey";
                open.FileName = "";
              

                if (open.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(open.FileName);
                    int helper = 0;
                    int helper2 = 4;
                    for (int i2 = 0; i2 <= 1; i2++)
                    {
                        for (int i3 = 0; i3 <= 1; i3++)
                        {
                            matriksB[i2, i3] = Convert.ToInt32(lines[helper]);
                            helper++;
                            //Console.WriteLine("matriksb["+i2+','+i3+"]= " + matriksB[i2, i3]);
                        }
                    }
                    helper = 0;
                   
                    for(int j2 = 0; j2 <= 1; j2++)
                    {
                        for(int j3 = 0; j3 <= 1; j3++)
                        {
                            kuncipub[j2,j3] = Convert.ToInt32(lines[helper2]);
                            helper2++;
                            //Console.WriteLine("kuncipub[" + j2 + ',' + j3 + "]= " + kuncipub[j2, j3]);
                        }
                    }
                    helper2 = 4;

                    range = Convert.ToInt32(lines[lines.Length-1]);
                    //Console.WriteLine("Range = " + range +"\n");

                }

                string[] result = {"","","",""};
                //looping untuk menampilkan public key
                for(int i = 0; i < 4; i++)
                {
                    string temp="";
                    if (i == 0)
                    {
                        temp = kuncipub[0, 0].ToString();
                        result[0] = temp;
                        temp = "";
                    }
                    else if (i == 1)
                    {
                        temp = kuncipub[0, 1].ToString();
                        result[1] = temp;
                        temp = "";
                    }
                    else if (i == 2)
                    {
                        temp =  kuncipub[1, 0].ToString();
                        result[2] = temp;
                        temp = "";
                      
                    }
                    else if (i == 3)
                    {
                        temp = kuncipub[1, 1].ToString();
                        result[3] = temp;
                        temp = "";
                    }
                }

                kpublik.Text = string.Join("\n", result);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label_d2.Text == null)
            {
                MessageBox.Show("Masukkan d2 terlebih dahulu");
            }
            else if (nama_file.Text == null)
            {
                MessageBox.Show("Masukkan Plaintext terlebih dahulu");
            }
            else if (kpublik.Text == null)
            {
                MessageBox.Show("Masukkan Kunci publik terlebih dahulu");
            }
            else if (int.Parse(label_d2.Text)<2 || int.Parse(label_d2.Text)>range-1)
            {
                MessageBox.Show("d2 tidak sesuai");
            }
            else
            {
                ciphertext.Text = "";

                char[] teks = this.plaintext.Text.ToCharArray();
                char[] plaintext = new char[teks.Length-1];
                
                //looping untuk memindahkan ke variabel baru agar length nya tidak kelebihan 1
                for(int i = 0; i < teks.Length - 1; i++)
                {
                    plaintext[i] = teks[i]; 
                }

                string[] tampilan = new string[plaintext.Length];

                for (int i = 0; i < plaintext.Length; i++)
                {
                    Random random = new Random();
                    int[,] angkaRandom = { { 0, 0 }, { 0, 0 } };
                    //looping untuk generate angka random per karakter
                    for (int j = 0; j <= 1; j++)
                    {
                        if (j == 0)
                        {
                            Console.WriteLine("Huruf " + plaintext[i] + " sebelum di enkripsi");
                        }
                       

                        for (int j2 = 0; j2 <= 1; j2++)
                        {
                            angkaRandom[j, j2] += random.Next(0, range);
                            Console.WriteLine("ini adalah matriks"+plaintext[i]+"[" + j+","+j2+"]= " + angkaRandom[j, j2]);
                        }

                        if (j == 1)
                        {
                            Console.WriteLine("------");
                        }
                    }

                    Console.WriteLine("================ ENCRYPTION =================");

                    //looping untuk generate ciphertext tiap karakter
                    int[,] matriksCiphertext = { { 0, 0 }, { 0, 0 } };
                    for(int k = 0; k < 1; k++)
                    {
                        for(int k2 = 0; k2 <= 3; k2++)
                        {
                            if (k2 == 0)
                            {
                                matriksCiphertext[0, 0] = ((angkaRandom[0, 0] * matriksB[0, 0]) + (angkaRandom[0, 1] * matriksB[1, 0])) % range;
                            }
                            else if (k2 == 1)
                            {
                                matriksCiphertext[0, 1] = ((angkaRandom[0, 0] * matriksB[0, 1]) + (angkaRandom[0, 1] * matriksB[1, 1])) % range;
                            }
                            else if (k2 == 2)
                            {
                                matriksCiphertext[1, 0] = ((angkaRandom[1, 0] * matriksB[0, 0]) + (angkaRandom[1, 1] * matriksB[1, 0])) % range;
                            }
                            else if (k2 == 3)
                            {
                                matriksCiphertext[1, 1] = ((angkaRandom[1, 0] * matriksB[0, 1]) + (angkaRandom[1, 1] * matriksB[1, 1])) % range;
                            }
                        }
                    }


                    Console.WriteLine("Huruf " + plaintext[i] + " setelah di enkripsi");
                    

                    for (int x = 0; x <= 1; x++)
                    {
                        for (int y = 0; y <= 1; y++)
                        { 
                            Console.WriteLine("ini adalah matriks" + plaintext[i] + "[" + x + "," + y + "]= " + matriksCiphertext[x, y]);
                        }
                    }
                    

                    //for (int index = 0; index < plaintext.Length; index++)
                    //{
                    tampilan[i] = matriksCiphertext[0, 0].ToString()+" "+ matriksCiphertext[0, 1].ToString() + " " + matriksCiphertext[1, 0].ToString() + " " + matriksCiphertext[1, 1].ToString();
                    //}

                    //tampilan[i] = tambahanKata;
                    Console.WriteLine("FINISH \n");
                }

                ciphertext.Text = String.Join("\n", tampilan);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
