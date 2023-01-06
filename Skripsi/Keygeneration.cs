using System.Numerics;
using System.Text;

namespace Skripsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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



        private void generateMatrix(int maximum)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.prima1.Text == "" || this.prima2.Text == "")
            {
                MessageBox.Show("Tidak boleh ada angka yang kosong");
            }
            else
            {
                int primaPertama = int.Parse(this.prima1.Text);
                int primaKedua = int.Parse(this.prima2.Text);
                int kalkulasiPrima = primaPertama * primaKedua;

                this.cek_bilangan1.Text = cekPrimaFermat(primaPertama);
                this.cek_bilangan2.Text = cekPrimaFermat(primaKedua);

                this.label_n.Text = kalkulasiPrima.ToString();

            }
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void generateMatriks_click(object sender, EventArgs e)
        {
            if (this.label_n.Text == "")
            {
                MessageBox.Show("Isi terlebih dahulu bilangan prima nya");
            }
            else
            {
                int range = int.Parse(this.label_n.Text);
                Random random = new Random();
                int matriksd1 = random.Next(2, range);
                int matriksd2 = random.Next(2, range);
                int matriksd3 = random.Next(2, range);
                int matriksd4 = random.Next(2, range);

                this.matriks_d1.Text = matriksd1.ToString();
                this.matriks_d2.Text = matriksd2.ToString();
                this.matriks_d3.Text = matriksd3.ToString();
                this.matriks_d4.Text = matriksd4.ToString();

                //string s = "Santo";
                //byte[] arrayASCII = Encoding.ASCII.GetBytes(s);
                
                //foreach(byte b in arrayASCII)
                //{

                //Console.WriteLine(b);
                //}
            }
        }

        private void label_n_Click(object sender, EventArgs e)
        {

        }


        private void perpangkatanMatriks()
        {
            /*
             * polinomial = 3x^2 + 5x + 9
             
             */

            //kalkulasi matriks
            int d1 = int.Parse(this.matriks_d1.Text);
            int d2 = int.Parse(this.matriks_d2.Text);
            int d3 = int.Parse(this.matriks_d3.Text);
            int d4 = int.Parse(this.matriks_d4.Text);
            int range = int.Parse(this.label_n.Text);

            int[,] matriks = new int[,] {
                    { d1,d2 } ,
                    { d3,d4}
                };


            int pangkat = 2;
            int[,] first = new int[,] { {0, 0 },{ 0,0 } };


            int[,] second = matriks;
            int[,] third = new int[,] { { 9, 0 }, { 0, 9 } };

            //looping matriks^2

            for (int i = 1; i < pangkat; i++)
            {
                if (i == 1)
                {
                    for(int j = 0; j <= 3; j++)
                    {
                        if (j == 0) 
                        {
                            first[0, 0] += ((matriks[0, 0] * matriks[0, 0]) + (matriks[0, 1] * matriks[1, 0]));
                        }
                        else if (j == 1)
                        {
                            first[0, 1] += ((matriks[0, 1] * matriks[0, 0]) + (matriks[0, 1] * matriks[1, 1]));
                        }
                        else if(j == 2)
                        {
                            first[1, 0] += ((matriks[1, 0] * matriks[0, 0]) + (matriks[1, 1] * matriks[1, 0]));
                        }
                        else if(j == 3)
                        {
                            first[1, 1] += ((matriks[1, 0] * matriks[0, 1]) + (matriks[1, 1] * matriks[1, 1]));
                        }
                    }
                }
                else
                {
                    int[,] helper = 
                     { 
                        { first[0, 0], first[0, 1] }, 
                        { first[1, 0], first[1, 1] } 
                    }; 
                    for (int j = 0; j <= 3; j++)
                    {
                        if (j == 0)
                        {
                            first[0, 0] = ((helper[0, 0] * matriks[0, 0]) + (helper[0, 1] * matriks[1, 0]));
                        }
                        else if (j == 1)
                        {
                            first[0, 1] = ((helper[0, 0] * matriks[0, 1]) + (helper[0, 1] * matriks[1, 1])); 
                        }
                        else if (j == 2)
                        {
                            first[1, 0] = ((helper[1, 0] * matriks[0, 0]) + (helper[1, 1] * matriks[1, 0]));
                        }
                        else if (j == 3)
                        {
                            first[1, 1] = ((helper[1, 0] * matriks[0, 1]) + (helper[1, 1] * matriks[1, 1]));
                        }
                    }
                    

                }
                    
            }


            //looping matriks * 3
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    first[i, j] = first[i, j] * 3;
                }
            }



            //looping matriks * 5

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    second[i, j] = second[i, j] * 5;
                }
            }

            ////looping Kalkulasi total matriks nya 
            int[,] matriksB = new int[2, 2];
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    matriksB[i, j] = ((first[i, j] + second[i, j] + third[i, j]) % range);
                }
            }



            int privateKey = int.Parse(this.key_d1.Text);
            int[,] matriksQ1 = new int[,] { { 0, 0 }, { 0, 0 } };

            ////looping untuk kunci private
            for (int i = 1; i < privateKey; i++)
            {
                if (i == 1)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        if (j == 0)
                        {
                            matriksQ1[0, 0] += ((matriksB[0, 0] * matriksB[0, 0]) + (matriksB[0, 1] * matriksB[1, 0]));
                        }
                        else if (j == 1)
                        {
                            matriksQ1[0, 1] += ((matriksB[0, 1] * matriksB[0, 0]) + (matriksB[0, 1] * matriksB[1, 1]));
                        }
                        else if (j == 2)
                        {
                            matriksQ1[1, 0] += ((matriksB[1, 0] * matriksB[0, 0]) + (matriksB[1, 1] * matriksB[1, 0]));
                        }
                        else if (j == 3)
                        {
                            matriksQ1[1, 1] += ((matriksB[1, 0] * matriksB[0, 1]) + (matriksB[1, 1] * matriksB[1, 1]));
                        }
                    }
                   
                }
                else
                {
                    int[,] helper =
                     {
                            { matriksQ1[0, 0], matriksQ1[0, 1] },
                            { matriksQ1[1, 0], matriksQ1[1, 1] }
                        };
                    for (int j = 0; j <= 3; j++)
                    {
                        if (j == 0)
                        {
                            matriksQ1[0, 0] = ((helper[0, 0] * matriksB[0, 0]) + (helper[0, 1] * matriksB[1, 0])) % range;
       
                        }
                        else if (j == 1)
                        {
                            matriksQ1[0, 1] = ((helper[0, 0] * matriksB[0, 1]) + (helper[0, 1] * matriksB[1, 1])) % range;
                        }
                        else if (j == 2)
                        {
                            matriksQ1[1, 0] = ((helper[1, 0] * matriksB[0, 0]) + (helper[1, 1] * matriksB[1, 0])) % range;
                        }
                        else if (j == 3)
                        {
                            matriksQ1[1, 1] = ((helper[1, 0] * matriksB[0, 1]) + (helper[1, 1] * matriksB[1, 1]))% range ;
                        }
                    }
                }
                
            }
            this.kprivat1.Text = matriksQ1[0, 0].ToString();
            this.kprivat2.Text = matriksQ1[0, 1].ToString();
            this.kprivat3.Text = matriksQ1[1, 0].ToString();
            this.kprivat4.Text = matriksQ1[1, 1].ToString();

        }


        private void generatekey_click(object sender, EventArgs e)
        {

            if (this.key_d1.Text == "")
            {
                MessageBox.Show("Isi d1 terlebih dahulu");
            }
            //else if (int.Parse(this.key_d1.Text) < 2 || int.Parse(this.key_d1.Text) > int.Parse(this.label_n.Text))
            //{
            //    MessageBox.Show("Range tidak memenuhi syarat");
            //}
            else
            {
                perpangkatanMatriks();

            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

         void kunci_publik_Click(object sender, EventArgs e)
        {

            SaveFileDialog simpan = new SaveFileDialog();
            simpan.Filter = "Public Key (*.publickey)|*.publickey";
            simpan.FileName = "*.publickey";
            if (simpan.ShowDialog() == DialogResult.OK)
            {
                FileStream fstream = new FileStream(simpan.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fstream);
                SeekOrigin seekorigin = new SeekOrigin();
                sw.BaseStream.Seek(0, seekorigin);
                sw.WriteLine(int.Parse(matriks_d1.Text));
                sw.WriteLine(int.Parse(matriks_d2.Text));
                sw.WriteLine(int.Parse(matriks_d3.Text));
                sw.WriteLine(int.Parse(matriks_d4.Text));
                sw.WriteLine(int.Parse(kprivat1.Text));
                sw.WriteLine(int.Parse(kprivat2.Text));
                sw.WriteLine(int.Parse(kprivat3.Text));
                sw.WriteLine(int.Parse(kprivat4.Text));
                sw.WriteLine(int.Parse(label_n.Text));
                sw.Flush();
                sw.Close();
                MessageBox.Show("Kunci Publik Disimpan");
            }
        }

        private void kunci_private_Click(object sender, EventArgs e)
        {
            if (key_d1.Text==null)
            {
                MessageBox.Show("Isi terlebih dahulu");
            }
            else
            {
                SaveFileDialog simpan = new SaveFileDialog();
                simpan = new SaveFileDialog();
                simpan.Filter = "Private Key (*.privatekey)|*.privatekey";
                simpan.FileName = "*.privatekey";
                if (simpan.ShowDialog() == DialogResult.OK)
                {
                    FileStream fstream = new FileStream(simpan.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fstream);
                    SeekOrigin seekorigin = new SeekOrigin();
                    sw.BaseStream.Seek(0, seekorigin);
                    sw.WriteLine(int.Parse(key_d1.Text));
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Kunci Private Disimpan");
                }
            }

            
            
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encryptform encryptform = new Encryptform();
            encryptform.Show();
            this.Hide();
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decryption decryption = new Decryption();
            decryption.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label_n.Text = "";
            prima1.Text = "";
            prima2.Text = "";
            cek_bilangan1.Text = "";
            cek_bilangan2.Text = "";
        }
    }
}