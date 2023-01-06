using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Skripsi
{
    public partial class Encryptform : Form
    {


        int[,] matriksB = { { 0, 0 }, { 0, 0 } };//variabel matriks B

        int[,] kuncipub = { { 0, 0 }, { 0, 0 } };// variabel matriks Q1
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
            int[,] reset = { { 0, 0 }, { 0, 0 } };
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

                    for (int j2 = 0; j2 <= 1; j2++)
                    {
                        for (int j3 = 0; j3 <= 1; j3++)
                        {
                            kuncipub[j2, j3] = Convert.ToInt32(lines[helper2]);
                            helper2++;
                            //Console.WriteLine("kuncipub[" + j2 + ',' + j3 + "]= " + kuncipub[j2, j3]);
                        }
                    }
                    helper2 = 4;

                    range = Convert.ToInt32(lines[lines.Length - 1]);
                    //Console.WriteLine("Range = " + range +"\n");

                }

                string[] result = { "", "", "", "" };
                //looping untuk menampilkan public key
                for (int i = 0; i < 4; i++)
                {
                    string temp = "";
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
                        temp = kuncipub[1, 0].ToString();
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
            else if (int.Parse(label_d2.Text) < 2 || int.Parse(label_d2.Text) > range - 1)
            {
                MessageBox.Show("d2 tidak sesuai");
            }
            else
            {
                ciphertext.Text = "";
                string spasi = " ";
                string getPlaintext = plaintext.Text;

                char[] teks = getPlaintext.ToCharArray();
                char[] teks2 = new char[teks.Length - 1];
                char[] spasi2 = spasi.ToCharArray();

                //Proses merubah Q1 menjadi K1
                int[,] matriksK1 = { { 0, 0 }, { 0, 0 } };

                int pangkatMatriksK1 = int.Parse(label_d2.Text);


                for (int i = 1; i < pangkatMatriksK1; i++)
                {
                    if (i == 1)
                    {
                        for (int j = 0; j <= 3; j++)
                        {
                            if (j == 0)
                            {
                                matriksK1[0, 0] += ((kuncipub[0, 0] * kuncipub[0, 0]) + (kuncipub[0, 1] * kuncipub[1, 0]));
                            }
                            else if (j == 1)
                            {
                                matriksK1[0, 1] += ((kuncipub[0, 1] * kuncipub[0, 0]) + (kuncipub[0, 1] * kuncipub[1, 1]));
                            }
                            else if (j == 2)
                            {
                                matriksK1[1, 0] += ((kuncipub[1, 0] * kuncipub[0, 0]) + (kuncipub[1, 1] * kuncipub[1, 0]));
                            }
                            else if (j == 3)
                            {
                                matriksK1[1, 1] += ((kuncipub[1, 0] * kuncipub[0, 1]) + (kuncipub[1, 1] * kuncipub[1, 1]));
                            }
                        }

                    }
                    else
                    {
                        int[,] helperMatriksK1 =
                         {
                            { matriksK1[0, 0], matriksK1[0, 1] },
                            { matriksK1[1, 0], matriksK1[1, 1] }
                        };
                        for (int j = 0; j <= 3; j++)
                        {
                            if (j == 0)
                            {
                                matriksK1[0, 0] = ((helperMatriksK1[0, 0] * kuncipub[0, 0]) + (helperMatriksK1[0, 1] * kuncipub[1, 0])) % range;

                            }
                            else if (j == 1)
                            {
                                matriksK1[0, 1] = ((helperMatriksK1[0, 0] * kuncipub[0, 1]) + (helperMatriksK1[0, 1] * kuncipub[1, 1])) % range;
                            }
                            else if (j == 2)
                            {
                                matriksK1[1, 0] = ((helperMatriksK1[1, 0] * kuncipub[0, 0]) + (helperMatriksK1[1, 1] * kuncipub[1, 0])) % range;
                            }
                            else if (j == 3)
                            {
                                matriksK1[1, 1] = ((helperMatriksK1[1, 0] * kuncipub[0, 1]) + (helperMatriksK1[1, 1] * kuncipub[1, 1])) % range;
                            }
                        }
                    }

                }

                for (int i = 0; i < teks2.Length; i++)
                {
                    teks2[i] = teks[i];
                }



                int tambahanPanjang = 4 - (teks2.Length % 4);

                if (tambahanPanjang == 4)
                {
                    tambahanPanjang = 0;
                }

                char[] helper = new char[teks2.Length + tambahanPanjang];
                Console.WriteLine("length nya helper = " + helper.Length);

                for (int i = 0; i < helper.Length; i++)
                {
                    if (i < teks2.Length)
                    {
                        helper[i] = teks2[i];
                    }
                    else
                    {
                        helper[i] = spasi2[0];
                    }
                }

                string fixPlaintext = new string(helper);
                int tampilanTemp = 0;
                int matriksTemp = 0;
                byte[] plaintextArray = Encoding.ASCII.GetBytes(fixPlaintext);
                string[] tampilan = new string[plaintextArray.Length / 4];
                int[,] temp = { { 0, 0 }, { 0, 0 } };

                for (int i = 0; i < plaintextArray.Length; i += 4)
                {
                    Console.WriteLine("tampilan.length = " + tampilan.Length);
                    Console.WriteLine("matriksTemp = " + matriksTemp);
                    int[,] matriksPlaintext = new int[2, 2];
                    for (int j = matriksTemp; j < matriksTemp + 4; j++)
                    {
                        Console.WriteLine("Iterasi ke " + j);
                        //Console.WriteLine(plaintextArray[j]);
                        if (j % 4 == 0)
                        {
                            matriksPlaintext[0, 0] = plaintextArray[j];
                            Console.WriteLine("matriksPlaintext[0, 0]" + matriksPlaintext[0, 0]);
                        }
                        if (j % 4 == 1)
                        {
                            matriksPlaintext[0, 1] = plaintextArray[j];
                            Console.WriteLine("matriksPlaintext[0, 1]" + matriksPlaintext[0, 1]);
                        }
                        if (j % 4 == 2)
                        {
                            matriksPlaintext[1, 0] = plaintextArray[j];
                            Console.WriteLine("matriksPlaintext[1, 0]" + matriksPlaintext[1, 0]);
                        }
                        if (j % 4 == 3)
                        {
                            matriksPlaintext[1, 1] = plaintextArray[j];
                            Console.WriteLine("matriksPlaintext[1, 1]" + matriksPlaintext[1, 1]);
                        }
                    }
                    matriksTemp += 4;
                    //Console.WriteLine("matriksTemp = " + matriksTemp);
                    Console.WriteLine("============");

                    //Console.WriteLine(matriksB[0, 0]);
                    //Console.WriteLine(matriksB[0, 1]);
                    //Console.WriteLine(matriksB[1, 0]);
                    //Console.WriteLine(matriksB[1, 1]);

                    int[,] matriksCipherText = new int[2, 2];

                    for (int k = 0; k < 1; k++)
                    {
                        for (int k2 = 0; k2 <= 3; k2++)
                        {
                            if (k2 == 0)
                            {

                                matriksCipherText[0, 0] = ((matriksPlaintext[0, 0] * matriksK1[0, 0]) + (matriksPlaintext[0, 1] * matriksK1[1, 0])) % range;
                                //Console.WriteLine(matriksPlaintext[0, 0] + " * " + matriksB[0, 0] + " + " + matriksPlaintext[0, 1] + " * " + matriksB[1, 0] + " / " + range + " = "+ matriksCipherText[0, 0]);
                            }
                            else if (k2 == 1)
                            {
                                matriksCipherText[0, 1] = ((matriksPlaintext[0, 0] * matriksK1[0, 1]) + (matriksPlaintext[0, 1] * matriksK1[1, 1])) % range;
                                //Console.WriteLine(matriksCipherText[0, 1]); 
                            }
                            else if (k2 == 2)
                            {
                                matriksCipherText[1, 0] = ((matriksPlaintext[1, 0] * matriksK1[0, 0]) + (matriksPlaintext[1, 1] * matriksK1[1, 0])) % range;
                                //Console.WriteLine(matriksCipherText[1, 0]);
                            }
                            else if (k2 == 3)
                            {
                                matriksCipherText[1, 1] = ((matriksPlaintext[1, 0] * matriksK1[0, 1]) + (matriksPlaintext[1, 1] * matriksK1[1, 1])) % range;
                                //Console.WriteLine(matriksCipherText[1, 1]);
                            }
                        }
                    }
                    temp[0, 0] = matriksCipherText[0, 0];
                    temp[0, 1] = matriksCipherText[0, 1];
                    temp[1, 0] = matriksCipherText[1, 0];
                    temp[1, 1] = matriksCipherText[1, 1];


                    //untuk menampilkan di program
                    tampilan[tampilanTemp] = temp[0, 0].ToString() + " " + temp[0, 1].ToString() + " " + temp[1, 0].ToString() + " " + temp[1, 1].ToString();
                    //Console.WriteLine(tampilan[tampilanTemp]);    
                    tampilanTemp += 1;
                    temp[0, 0] = 0;
                    temp[0, 1] = 0;
                    temp[1, 0] = 0;
                    temp[1, 1] = 0;
                }

                //looping untuk K

                int pangkatMatriksK = pangkatMatriksK1;
                int[,] matriksK = { { 0, 0 }, { 0, 0 } };

                for (int i = 1; i < pangkatMatriksK; i++)
                {
                    if (i == 1)
                    {
                        for (int j = 0; j <= 3; j++)
                        {
                            if (j == 0)
                            {
                                matriksK[0, 0] += ((matriksB[0, 0] * matriksB[0, 0]) + (matriksB[0, 1] * matriksB[1, 0]));
                            }
                            else if (j == 1)
                            {
                                matriksK[0, 1] += ((matriksB[0, 1] * matriksB[0, 0]) + (matriksB[0, 1] * matriksB[1, 1]));
                            }
                            else if (j == 2)
                            {
                                matriksK[1, 0] += ((matriksB[1, 0] * matriksB[0, 0]) + (matriksB[1, 1] * matriksB[1, 0]));
                            }
                            else if (j == 3)
                            {
                                matriksK[1, 1] += ((matriksB[1, 0] * matriksB[0, 1]) + (matriksB[1, 1] * matriksB[1, 1]));
                            }
                        }

                    }
                    else
                    {
                        int[,] helperMatriksK =
                         {
                            { matriksK1[0, 0], matriksK1[0, 1] },
                            { matriksK1[1, 0], matriksK1[1, 1] }
                        };
                        for (int j = 0; j <= 3; j++)
                        {
                            if (j == 0)
                            {
                                matriksK1[0, 0] = ((helperMatriksK[0, 0] * matriksB[0, 0]) + (helperMatriksK[0, 1] * matriksB[1, 0])) % range;

                            }
                            else if (j == 1)
                            {
                                matriksK1[0, 1] = ((helperMatriksK[0, 0] * matriksB[0, 1]) + (helperMatriksK[0, 1] * matriksB[1, 1])) % range;
                            }
                            else if (j == 2)
                            {
                                matriksK1[1, 0] = ((helperMatriksK[1, 0] * matriksB[0, 0]) + (helperMatriksK[1, 1] * matriksB[1, 0])) % range;
                            }
                            else if (j == 3)
                            {
                                matriksK1[1, 1] = ((helperMatriksK[1, 0] * matriksB[0, 1]) + (helperMatriksK[1, 1] * matriksB[1, 1])) % range;
                            }
                        }
                    }

                    string hasil = String.Join(", ", tampilan);
                    ciphertext.Text = hasil;

                }

            }
        }
            private void button3_Click(object sender, EventArgs e)
            {
                if (ciphertext.Text != "")
                {

                    //string[] cipherteks = ciphertext.Text.Split(',');

                    SaveFileDialog simpan = new SaveFileDialog();
                    simpan.Filter = "Enrypted Files|*.enc";
                    simpan.FileName = "*.enc";
                    if (simpan.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fstream = new FileStream(simpan.FileName, FileMode.OpenOrCreate);
                        StreamWriter sw = new StreamWriter(fstream);
                        SeekOrigin seekorigin = new SeekOrigin();
                        sw.BaseStream.Seek(0, seekorigin);
                        //for (int i = 0; i < cipherteks.Length; i++)
                        //{
                        //    //Console.WriteLine("cipherteks[i] = " + cipherteks[i]);
                        //    sw.Write(cipherteks[i]);
                        //}
                        //sw.Write(ciphertext.Text);
                        sw.Write(ciphertext.Text);
                        sw.Flush();
                        sw.Close();
                        MessageBox.Show("File Berhasil Disimpan");
                    }
                }
                else
                {
                    MessageBox.Show("CIphertext blum ada");
                }
            }

            private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Decryption decryption = new Decryption();
                decryption.Show();
                this.Hide();
            }


            private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Isi p terlebih dahulu");
                }
                else
                {
                    int angka = int.Parse(textBox1.Text);
                    if (cekPrimaFermat(angka) == "Bukan Bilangan Prima")
                    {
                        MessageBox.Show("p harus bilangan prima");
                    }
                    else
                    {
                        label10.Text = "";
                        //q = p-1
                        int faktorisasiPrima = faktorisasi(angka -= 1);
                        label10.Text = faktorisasiPrima.ToString();
                    }
                }
            }

            private BigInteger findNumberFora()
            {
                int maximum = int.Parse(textBox1.Text);
                int pangkat = int.Parse(label10.Text);
                BigInteger hasil = 0;
                for (int i = 2; i < maximum; i++)
                {
                    BigInteger angka = perpangkatan(i, pangkat);
                    Console.WriteLine(angka);

                    Console.WriteLine(angka % maximum);
                    if (angka % maximum == 1)
                    {
                        hasil = i;
                        break;
                    }
                }
                return hasil;
            }

            private BigInteger perpangkatan(int angka, int pangkat)
            {
                //BigInteger hasil = 0;
                BigInteger angka2 = angka;
                for (int i = 2; i <= pangkat; i++)
                {
                    angka2 *= angka;
                }
                Console.WriteLine(angka + " pangkat " + pangkat + " = " + angka2);
                return angka2;
            }

            private int faktorisasi(int input)
            {
                int hasil = 0;
                for (int b = 2; input > 1; b++)
                    if (input % b == 0)
                    {
                        int x = 0;
                        while (input % b == 0)
                        {
                            input /= b;
                            x++;
                        }
                        hasil = b;
                        //Console.WriteLine($"{b} adalah faktorisasi {x} kali!");
                    }
                return hasil;

            }

            private string cekPrimaFermat(int x)
            {
                string hasil = "";

                BigInteger perhitungan = 0;

                for (int i = 2; i < x; i++)
                {
                    perhitungan = i;

                    for (int j = 2; j <= x - 1; j++)
                    {
                        perhitungan *= i;
                        //Console.WriteLine("ini perpangkatan " + i + " pangkat " + j + " yaitu = " + perhitungan);
                    }


                    //Console.WriteLine("Hasil mod = " + perhitungan % x);

                    if (perhitungan % x == 1)
                    {
                        hasil = "Bilangan Prima";

                    }
                    else
                    {
                        hasil = "Bukan Bilangan Prima";
                        return hasil;

                    }

                    //Console.WriteLine("===========");
                    //Console.WriteLine("Ini adalah cek bilangan = " + x + " yaitu : " + perhitungan);
                }

                return hasil;

            }

            private void button5_Click(object sender, EventArgs e)
            {
                if (label10.Text == "")
                {
                    MessageBox.Show("Generate q terlebih dahulu");
                }
                else
                {
                    label12.Text = "";
                    BigInteger a = findNumberFora();
                    label12.Text = a.ToString();
                }
            }

            private void btn_reset_Click(object sender, EventArgs e)
            {
                textBox1.Text = "";
                label10.Text = "";
                label12.Text = "";
            }

            private void button6_Click(object sender, EventArgs e)
            {
                textBox2.Text = "";
                Random random = new Random();
                int maximum = int.Parse(label10.Text);
                int generateRandom = random.Next(2, maximum);
                textBox2.Text = generateRandom.ToString();
            }

            private void btn_generatekey_Click(object sender, EventArgs e)
            {
                if (textBox2.Text == "" || textBox3.Text == "" || label12.Text == "" || textBox1.Text == "" || label10.Text == "")
                {
                    MessageBox.Show("Inputan tidak lengkap");
                }
                else
                {
                    int r = int.Parse(textBox3.Text);
                    int p = int.Parse(textBox1.Text);
                    int a = int.Parse(label12.Text);

                    BigInteger x = perpangkatan(a, r) % p;
                    //Console.WriteLine(x);

                }
            }
        }
    }

