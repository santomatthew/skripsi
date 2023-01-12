using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using System.Security.Policy;

namespace Skripsi
{
    public partial class Decryption : Form
    {
        int[,] matriksB = { {0,0 },{ 0, 0 } };
        int[,] matriksK2= { { 0, 0 }, { 0, 0 } };
        int[,] matriksK2Temp = { { 0, 0 }, { 0, 0 } };
        BigInteger signatureE = 0;
        BigInteger signatureY = 0;
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
                    string[] lines = File.ReadAllLines(open.FileName);
                    ciphertext.Text = lines[0];
                    string[] baris0 = lines[0].Split(" ");

                    int[] teksCipher = new int[baris0.Length-5];
                    
                    for(int i = 0; i < teksCipher.Length; i++)
                    {
                        teksCipher[i] = int.Parse(baris0[i]);
                        //Console.WriteLine(teksCipher[i]);
                    }

                    //matriksK
                    int[] helperMatriksK2 = new int[4];
                    int counter = 0;
                    for (int i = baris0.Length - 5; i < baris0.Length - 1; i++) 
                    {
                        helperMatriksK2[counter] = int.Parse(baris0[i]);
                        counter++;
                    }
                    counter = 0;
                    int[,] notrealMatriksK2 = { { helperMatriksK2[0], helperMatriksK2[1] }, { helperMatriksK2[2], helperMatriksK2[3] } };
                    matriksK2Temp = notrealMatriksK2;

                    //range
                    range = int.Parse(lines[1]);

                    //y
                    label_y.Text = lines[lines.Length-1];
                    label_e.Text = lines[lines.Length-2];

                    //x
                    label_x.Text= baris0[baris0.Length-1];



                    //nama_file.Text = Path.GetFileName(open.FileName);
                    //string nama = open.FileName.Substring(0, open.FileName.Length);
                    //FileStream fstream = new FileStream(nama, FileMode.Open, FileAccess.ReadWrite);
                    //StreamReader sreader = new StreamReader(fstream);
                    //sreader.BaseStream.Seek(0, SeekOrigin.Begin);
                    //ciphertext.Text = sreader.ReadToEnd();
                    //sreader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (kprivate.Text == "")
            {
                MessageBox.Show("Masukkan kunci private");
            }
            else if (ciphertext.Text == "")
            {
                MessageBox.Show("Masukkan ciphertext");
            }
            else
            {
                //int[,] matriksK2 = { { 0, 0 }, { 0, 0 } };

                string[] signedCipherteks = ciphertext.Text.Split(" ");
                int[] cipherteks = new int[signedCipherteks.Length - 5];
                for (int i = 0; i < signedCipherteks.Length - 5; i++)
                {
                    cipherteks[i] = int.Parse(signedCipherteks[i]);
                    Console.WriteLine("cipherteksi = " + cipherteks[i]);
                }

                //for (int i = 0; i <= 1; i++)
                //{
                //    for (int j = 0; j <= 1; j++)
                //    {
                //        //Console.WriteLine("matriksk2[i,j] = " + matriksK2[i,j]);
                //    }
                //}


                int pangkatMatriksK2 = int.Parse(kprivate.Text);
                for (int i = 1; i < pangkatMatriksK2; i++)
                {
                    if (i == 1)
                    {
                        for (int j = 0; j <= 3; j++)
                        {
                            if (j == 0)
                            {
                                matriksK2[0, 0] += ((matriksK2Temp[0, 0] * matriksK2Temp[0, 0]) + (matriksK2Temp[0, 1] * matriksK2Temp[1, 0]));
                            }
                            else if (j == 1)
                            {
                                matriksK2[0, 1] += ((matriksK2Temp[0, 1] * matriksK2Temp[0, 0]) + (matriksK2Temp[0, 1] * matriksK2Temp[1, 1]));
                            }
                            else if (j == 2)
                            {
                                matriksK2[1, 0] += ((matriksK2Temp[1, 0] * matriksK2Temp[0, 0]) + (matriksK2Temp[1, 1] * matriksK2Temp[1, 0]));
                            }
                            else if (j == 3)
                            {
                                matriksK2[1, 1] += ((matriksK2Temp[1, 0] * matriksK2Temp[0, 1]) + (matriksK2Temp[1, 1] * matriksK2Temp[1, 1]));
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
                                matriksK2[0, 0] = ((helperMatriksK2[0, 0] * matriksK2Temp[0, 0]) + (helperMatriksK2[0, 1] * matriksK2Temp[1, 0])) % range;

                            }
                            else if (j == 1)
                            {
                                matriksK2[0, 1] = ((helperMatriksK2[0, 0] * matriksK2Temp[0, 1]) + (helperMatriksK2[0, 1] * matriksK2Temp[1, 1])) % range;
                            }
                            else if (j == 2)
                            {
                                matriksK2[1, 0] = ((helperMatriksK2[1, 0] * matriksK2Temp[0, 0]) + (helperMatriksK2[1, 1] * matriksK2Temp[1, 0])) % range;
                            }
                            else if (j == 3)
                            {
                                matriksK2[1, 1] = ((helperMatriksK2[1, 0] * matriksK2Temp[0, 1]) + (helperMatriksK2[1, 1] * matriksK2Temp[1, 1])) % range;
                            }
                        }
                    }
                   
                }
                Console.WriteLine("matriksK2 = " + matriksK2[0, 0]);
                Console.WriteLine("matriksK2 = " + matriksK2[0, 1]);
                Console.WriteLine("matriksK2 = " + matriksK2[1, 0]);
                Console.WriteLine("matriksK2 = " + matriksK2[1, 1]);

                //========================== LOOPING DEKRIPSI
                


                ///============ INVERS MODULO MATRIKS K2
                int[,] matriksK2ModInverse = new int[matriksK2.GetLength(0), matriksK2.GetLength(1)];


                int determinan = (matriksK2[0, 0] * matriksK2[1, 1]) - (matriksK2[0, 1] * matriksK2[1, 0]);
                Console.WriteLine("determinan = " + determinan);
                int[,] adjoinMatriks = { { matriksK2[1, 1], -matriksK2[0, 1] }, { -matriksK2[1, 0], matriksK2[0, 0] } };

                int pengkali = modInverse(determinan, range);
                Console.WriteLine("pengkali = " + pengkali);
                for (int i = 0; i < adjoinMatriks.GetLength(0); i++)
                {
                    for (int j = 0; j < adjoinMatriks.GetLength(1); j++)
                    {
                        if(adjoinMatriks[i, j] < 0)
                        {
                            if(range> -adjoinMatriks[i, j] * pengkali)
                            {
                                matriksK2ModInverse[i, j] = range - ( -adjoinMatriks[i, j] * pengkali);
                                Console.WriteLine("matriksK2ModInverse[i,j] = " + adjoinMatriks[i, j] + " * " + pengkali + " % " + range + " = " + matriksK2ModInverse[i, j]);
                            }
                            else
                            {
                                int pembatas = range;

                                while(pembatas< -adjoinMatriks[i, j] * pengkali)
                                {
                                    pembatas += range;
                                }

                                matriksK2ModInverse[i, j] = pembatas - (-adjoinMatriks[i, j] * pengkali);
                                Console.WriteLine("matriksK2ModInverse[i,j] = " + pembatas + " - " + -adjoinMatriks[i, j] + " * " + pengkali + " = " + matriksK2ModInverse[i, j]);
                            }

                            
                        }
                        else
                        {
                            matriksK2ModInverse[i, j] = (adjoinMatriks[i, j] * pengkali) % range;
                            Console.WriteLine("matriksK2ModInverse[i,j] = " + adjoinMatriks[i, j]+" * "+ pengkali+" % " +range + " = "+ matriksK2ModInverse[i, j]);
                        }
                    }
                }
                Console.WriteLine("matriksK2ModInverse = " + matriksK2ModInverse[0, 0]);
                Console.WriteLine("matriksK2ModInverse = " + matriksK2ModInverse[0, 1]);
                Console.WriteLine("matriksK2ModInverse = " + matriksK2ModInverse[1, 0]);
                Console.WriteLine("matriksK2ModInverse = " + matriksK2ModInverse[1, 1]);

                int[] penampung = new int[cipherteks.Length];
                int penghitung = 0;
                int penghitung2 = 0;
                //Console.WriteLine("pengkali = " + pengkali);
                for(int i = 0; i < penampung.Length / 4; i++)
                {
                    for (int h = 0; h <= 3; h++)
                    {
                        int[,] plaintext = { { cipherteks[penghitung], cipherteks[penghitung + 1] }, { cipherteks[penghitung + 2], cipherteks[penghitung + 3] } };
                        Console.WriteLine("plaintext[0, 0]"+ plaintext[0,0]);
                        Console.WriteLine("plaintext[0, 1]" + plaintext[0, 1]);
                        Console.WriteLine("plaintext[1, 0]" + plaintext[1, 0]);
                        Console.WriteLine("plaintext[1, 1]" + plaintext[1, 1]);
                        if (h == 0)
                        {
                            penampung[penghitung2]= ((plaintext[0, 0] * matriksK2ModInverse[0, 0]) + (plaintext[0, 1] * matriksK2ModInverse[1, 0])) % range;
                            penghitung2++;
                        }
                        else if (h == 1)
                        {
                            penampung[penghitung2] = ((plaintext[0, 0] * matriksK2ModInverse[0, 1]) + (plaintext[0, 1] * matriksK2ModInverse[1, 1])) % range;
                            penghitung2++;
                        }
                        else if (h == 2)
                        {
                            penampung[penghitung2] = ((plaintext[1, 0] * matriksK2ModInverse[0, 0]) + (plaintext[1, 1] * matriksK2ModInverse[1, 0])) % range;
                            penghitung2++;
                        }
                        else if (h == 3)
                        {
                            penampung[penghitung2] = ((plaintext[1, 0] * matriksK2ModInverse[0, 1]) + (plaintext[1, 1] * matriksK2ModInverse[1, 1])) % range;
                            penghitung2++;
                        }

                    }
                    penghitung += 4;
                }
                

                for(int i = 0; i < penampung.Length; i++)
                {
                    Console.WriteLine(penampung[i]);
                }

                char[] decryptedString = new char[penampung.Length];

                for (int i = 0; i < penampung.Length; i++)
                {
                    decryptedString[i] = Convert.ToChar(penampung[i]);
                    Console.WriteLine(decryptedString[i]);
                }

                plaintext_board.Text = String.Join("", decryptedString);


            }
        }

        private static int modInverse(int a, int m)
        {
            for (int x = 1; x < m; x++)
            {
                if (((a % m) * (x % m)) % m == 1)
                {
                    return x;
                }
            }
            return 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "SCHNORR Key (*.SCHNORR)|*.SCHNORR";
                open.FileName = "";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(open.FileName);
                    label12.Text = lines[0];
                    label13.Text = lines[1];
                    label_p.Text = lines[2];
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label_y_Click(object sender, EventArgs e)
        {

        }
        static BigInteger Power(int x, BigInteger y, int p)
        {
            int res = 1; // Initialize result

            x = x % p; // Update x if it is more than or
                       // equal to p

            if (x == 0)
                return 0; // In case x is divisible by p;

            while (y > 0)
            {

                // If y is odd, multiply x with result
                if ((y & 1) != 0)
                    res = (res * x) % p;

                // y must be even now
                y = y >> 1; // y = y/2
                x = (x * x) % p;
            }
            return res;
        }
        private BigInteger perpangkatan(int angka, BigInteger pangkat)
        {
            //BigInteger hasil = 0;
            BigInteger angka2 = angka;
            for (int i = 2; i <= pangkat; i++)
            {
                angka2 *= angka;
            }
            //Console.WriteLine(angka + " pangkat " + pangkat + " = " + angka2);
            return angka2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BigInteger a = int.Parse(label12.Text);
            BigInteger v = int.Parse(label13.Text);
            BigInteger keyE = BigInteger.Parse(label_e.Text);
            BigInteger p = int.Parse(label_p.Text);
            BigInteger keyY = int.Parse(label_y.Text);


            BigInteger v1 = BigInteger.ModPow(v, keyE, p);
            Console.WriteLine("v1 = " + v1);
            
            BigInteger aPangkatYmodP = BigInteger.ModPow(a, keyY,p);
            BigInteger xAksen = (aPangkatYmodP * v1)%p;
            label_xaksen.Text = xAksen.ToString();

         
            if(BigInteger.Parse(label_xaksen.Text) == BigInteger.Parse(label_x.Text))
            {
                label_validasi.Text = "Valid";
            }
            else
            {
                label_validasi.Text = "Tidak Valid";
            }


        }

        private void label_x_Click(object sender, EventArgs e)
        {

        }

        private void label_validasi_Click(object sender, EventArgs e)
        {

        }
    }
}
