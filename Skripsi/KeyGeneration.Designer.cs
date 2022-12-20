namespace Skripsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prima1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prima2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.btn_cekprima = new System.Windows.Forms.Button();
            this.cek_bilangan1 = new System.Windows.Forms.Label();
            this.cek_bilangan2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kunci_private = new System.Windows.Forms.Button();
            this.kunci_publik = new System.Windows.Forms.Button();
            this.kprivat4 = new System.Windows.Forms.Label();
            this.kprivat3 = new System.Windows.Forms.Label();
            this.kprivat2 = new System.Windows.Forms.Label();
            this.kprivat1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generatekey = new System.Windows.Forms.Button();
            this.key_d1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.matriks_d4 = new System.Windows.Forms.TextBox();
            this.matriks_d3 = new System.Windows.Forms.TextBox();
            this.matriks_d2 = new System.Windows.Forms.TextBox();
            this.matriks_d1 = new System.Windows.Forms.TextBox();
            this.generateMatriks = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // prima1
            // 
            this.prima1.Location = new System.Drawing.Point(62, 80);
            this.prima1.Name = "prima1";
            this.prima1.Size = new System.Drawing.Size(89, 23);
            this.prima1.TabIndex = 0;
            this.prima1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "p = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "q =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // prima2
            // 
            this.prima2.Location = new System.Drawing.Point(62, 112);
            this.prima2.Name = "prima2";
            this.prima2.Size = new System.Drawing.Size(89, 23);
            this.prima2.TabIndex = 4;
            this.prima2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "N =";
            // 
            // label_n
            // 
            this.label_n.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_n.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_n.Location = new System.Drawing.Point(62, 146);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(89, 26);
            this.label_n.TabIndex = 7;
            this.label_n.Click += new System.EventHandler(this.label_n_Click);
            // 
            // btn_cekprima
            // 
            this.btn_cekprima.Location = new System.Drawing.Point(9, 178);
            this.btn_cekprima.Name = "btn_cekprima";
            this.btn_cekprima.Size = new System.Drawing.Size(352, 34);
            this.btn_cekprima.TabIndex = 8;
            this.btn_cekprima.Text = "Cek Bilangan Prima";
            this.btn_cekprima.UseVisualStyleBackColor = true;
            this.btn_cekprima.Click += new System.EventHandler(this.button1_Click);
            // 
            // cek_bilangan1
            // 
            this.cek_bilangan1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cek_bilangan1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cek_bilangan1.Location = new System.Drawing.Point(166, 39);
            this.cek_bilangan1.Name = "cek_bilangan1";
            this.cek_bilangan1.Size = new System.Drawing.Size(195, 23);
            this.cek_bilangan1.TabIndex = 11;
            // 
            // cek_bilangan2
            // 
            this.cek_bilangan2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cek_bilangan2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cek_bilangan2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cek_bilangan2.Location = new System.Drawing.Point(166, 70);
            this.cek_bilangan2.Name = "cek_bilangan2";
            this.cek_bilangan2.Size = new System.Drawing.Size(195, 64);
            this.cek_bilangan2.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cekprima);
            this.groupBox1.Controls.Add(this.cek_bilangan1);
            this.groupBox1.Controls.Add(this.cek_bilangan2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 234);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validasi Bilangan Prima";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.keyGenerationToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // keyGenerationToolStripMenuItem
            // 
            this.keyGenerationToolStripMenuItem.Name = "keyGenerationToolStripMenuItem";
            this.keyGenerationToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.keyGenerationToolStripMenuItem.Text = "Key Generation";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kunci_private);
            this.groupBox2.Controls.Add(this.kunci_publik);
            this.groupBox2.Controls.Add(this.kprivat4);
            this.groupBox2.Controls.Add(this.kprivat3);
            this.groupBox2.Controls.Add(this.kprivat2);
            this.groupBox2.Controls.Add(this.kprivat1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.generatekey);
            this.groupBox2.Controls.Add(this.key_d1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(782, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 234);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key Generation";
            // 
            // kunci_private
            // 
            this.kunci_private.Location = new System.Drawing.Point(271, 35);
            this.kunci_private.Name = "kunci_private";
            this.kunci_private.Size = new System.Drawing.Size(167, 34);
            this.kunci_private.TabIndex = 28;
            this.kunci_private.Text = "Simpan Kunci Private";
            this.kunci_private.UseVisualStyleBackColor = true;
            this.kunci_private.Click += new System.EventHandler(this.kunci_private_Click);
            // 
            // kunci_publik
            // 
            this.kunci_publik.Location = new System.Drawing.Point(271, 90);
            this.kunci_publik.Name = "kunci_publik";
            this.kunci_publik.Size = new System.Drawing.Size(167, 34);
            this.kunci_publik.TabIndex = 27;
            this.kunci_publik.Text = "Simpan Kunci Publik";
            this.kunci_publik.UseVisualStyleBackColor = true;
            this.kunci_publik.Click += new System.EventHandler(this.kunci_publik_Click);
            // 
            // kprivat4
            // 
            this.kprivat4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kprivat4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kprivat4.Location = new System.Drawing.Point(167, 127);
            this.kprivat4.Name = "kprivat4";
            this.kprivat4.Size = new System.Drawing.Size(63, 27);
            this.kprivat4.TabIndex = 21;
            // 
            // kprivat3
            // 
            this.kprivat3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kprivat3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kprivat3.Location = new System.Drawing.Point(85, 127);
            this.kprivat3.Name = "kprivat3";
            this.kprivat3.Size = new System.Drawing.Size(63, 27);
            this.kprivat3.TabIndex = 20;
            // 
            // kprivat2
            // 
            this.kprivat2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kprivat2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kprivat2.Location = new System.Drawing.Point(167, 86);
            this.kprivat2.Name = "kprivat2";
            this.kprivat2.Size = new System.Drawing.Size(63, 27);
            this.kprivat2.TabIndex = 19;
            // 
            // kprivat1
            // 
            this.kprivat1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kprivat1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kprivat1.Location = new System.Drawing.Point(85, 86);
            this.kprivat1.Name = "kprivat1";
            this.kprivat1.Size = new System.Drawing.Size(63, 27);
            this.kprivat1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Q1 =";
            // 
            // generatekey
            // 
            this.generatekey.Location = new System.Drawing.Point(64, 176);
            this.generatekey.Name = "generatekey";
            this.generatekey.Size = new System.Drawing.Size(166, 43);
            this.generatekey.TabIndex = 16;
            this.generatekey.Text = "Hitung";
            this.generatekey.UseVisualStyleBackColor = true;
            this.generatekey.Click += new System.EventHandler(this.generatekey_click);
            // 
            // key_d1
            // 
            this.key_d1.Location = new System.Drawing.Point(64, 35);
            this.key_d1.Name = "key_d1";
            this.key_d1.Size = new System.Drawing.Size(183, 29);
            this.key_d1.TabIndex = 16;
            this.key_d1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "d1 =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(35, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 125);
            this.label10.TabIndex = 26;
            this.label10.Text = "[";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(208, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 125);
            this.label11.TabIndex = 26;
            this.label11.Text = "]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.matriks_d4);
            this.groupBox3.Controls.Add(this.matriks_d3);
            this.groupBox3.Controls.Add(this.matriks_d2);
            this.groupBox3.Controls.Add(this.matriks_d1);
            this.groupBox3.Controls.Add(this.generateMatriks);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(418, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 234);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Matriks";
            // 
            // matriks_d4
            // 
            this.matriks_d4.Location = new System.Drawing.Point(158, 105);
            this.matriks_d4.Name = "matriks_d4";
            this.matriks_d4.Size = new System.Drawing.Size(63, 29);
            this.matriks_d4.TabIndex = 25;
            // 
            // matriks_d3
            // 
            this.matriks_d3.Location = new System.Drawing.Point(77, 105);
            this.matriks_d3.Name = "matriks_d3";
            this.matriks_d3.Size = new System.Drawing.Size(63, 29);
            this.matriks_d3.TabIndex = 24;
            // 
            // matriks_d2
            // 
            this.matriks_d2.Location = new System.Drawing.Point(158, 64);
            this.matriks_d2.Name = "matriks_d2";
            this.matriks_d2.Size = new System.Drawing.Size(63, 29);
            this.matriks_d2.TabIndex = 23;
            // 
            // matriks_d1
            // 
            this.matriks_d1.Location = new System.Drawing.Point(77, 64);
            this.matriks_d1.Name = "matriks_d1";
            this.matriks_d1.Size = new System.Drawing.Size(63, 29);
            this.matriks_d1.TabIndex = 16;
            // 
            // generateMatriks
            // 
            this.generateMatriks.Location = new System.Drawing.Point(43, 178);
            this.generateMatriks.Name = "generateMatriks";
            this.generateMatriks.Size = new System.Drawing.Size(222, 38);
            this.generateMatriks.TabIndex = 19;
            this.generateMatriks.Text = "Generate Matriks";
            this.generateMatriks.UseVisualStyleBackColor = true;
            this.generateMatriks.Click += new System.EventHandler(this.generateMatriks_click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(208, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 125);
            this.label12.TabIndex = 21;
            this.label12.Text = "]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(21, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 125);
            this.label13.TabIndex = 22;
            this.label13.Text = "[";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 290);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prima2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prima1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Generation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox prima1;
        private Label label2;
        private Label label3;
        private TextBox prima2;
        private Label label4;
        private Label label_n;
        private Button btn_cekprima;
        private Label cek_bilangan1;
        private Label cek_bilangan2;
        private GroupBox groupBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem homeToolStripMenuItem1;
        private ToolStripMenuItem keyGenerationToolStripMenuItem;
        private ToolStripMenuItem encryptToolStripMenuItem;
        private ToolStripMenuItem decryptToolStripMenuItem;
        private GroupBox groupBox2;
        private Label kprivat1;
        private Label label5;
        private Button generatekey;
        private TextBox key_d1;
        private Label label1;
        private GroupBox groupBox3;
        private Button generateMatriks;
        private Label label12;
        private Label label13;
        private TextBox matriks_d4;
        private TextBox matriks_d3;
        private TextBox matriks_d2;
        private TextBox matriks_d1;
        private Label kprivat4;
        private Label kprivat3;
        private Label kprivat2;
        private Label label10;
        private Label label11;
        private Button kunci_private;
        private Button kunci_publik;
    }
}