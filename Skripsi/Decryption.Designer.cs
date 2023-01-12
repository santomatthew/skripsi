namespace Skripsi
{
    partial class Decryption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ciphertext = new System.Windows.Forms.RichTextBox();
            this.plaintext_board = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_loadkprivate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kprivate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browse_file = new System.Windows.Forms.Button();
            this.nama_file = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_validasi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.label_xaksen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_p = new System.Windows.Forms.Label();
            this.label_random = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.keyGenerationToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1226, 24);
            this.menuStrip2.TabIndex = 17;
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
            this.keyGenerationToolStripMenuItem.Click += new System.EventHandler(this.keyGenerationToolStripMenuItem_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ciphertext);
            this.groupBox1.Controls.Add(this.plaintext_board);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_decrypt);
            this.groupBox1.Controls.Add(this.btn_loadkprivate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kprivate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.browse_file);
            this.groupBox1.Controls.Add(this.nama_file);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1202, 342);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decrypt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ciphertext
            // 
            this.ciphertext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ciphertext.Location = new System.Drawing.Point(6, 112);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(379, 160);
            this.ciphertext.TabIndex = 18;
            this.ciphertext.Text = "";
            // 
            // plaintext_board
            // 
            this.plaintext_board.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plaintext_board.Location = new System.Drawing.Point(800, 104);
            this.plaintext_board.Name = "plaintext_board";
            this.plaintext_board.Size = new System.Drawing.Size(379, 168);
            this.plaintext_board.TabIndex = 17;
            this.plaintext_board.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(1033, 293);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(146, 32);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_decrypt.Location = new System.Drawing.Point(795, 293);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(146, 32);
            this.btn_decrypt.TabIndex = 10;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_loadkprivate
            // 
            this.btn_loadkprivate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_loadkprivate.Location = new System.Drawing.Point(520, 293);
            this.btn_loadkprivate.Name = "btn_loadkprivate";
            this.btn_loadkprivate.Size = new System.Drawing.Size(146, 32);
            this.btn_loadkprivate.TabIndex = 9;
            this.btn_loadkprivate.Text = "Load Private Key";
            this.btn_loadkprivate.UseVisualStyleBackColor = true;
            this.btn_loadkprivate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(800, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Plaintext :";
            // 
            // kprivate
            // 
            this.kprivate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kprivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kprivate.Location = new System.Drawing.Point(520, 112);
            this.kprivate.Name = "kprivate";
            this.kprivate.Size = new System.Drawing.Size(146, 160);
            this.kprivate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(520, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Private Key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciphertext :";
            // 
            // browse_file
            // 
            this.browse_file.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browse_file.Location = new System.Drawing.Point(303, 35);
            this.browse_file.Name = "browse_file";
            this.browse_file.Size = new System.Drawing.Size(82, 32);
            this.browse_file.TabIndex = 2;
            this.browse_file.Text = "Browse";
            this.browse_file.UseVisualStyleBackColor = true;
            this.browse_file.Click += new System.EventHandler(this.browse_file_Click);
            // 
            // nama_file
            // 
            this.nama_file.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nama_file.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nama_file.Location = new System.Drawing.Point(85, 35);
            this.nama_file.Name = "nama_file";
            this.nama_file.Size = new System.Drawing.Size(188, 27);
            this.nama_file.TabIndex = 1;
            this.nama_file.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_validasi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_x);
            this.groupBox2.Controls.Add(this.labe);
            this.groupBox2.Controls.Add(this.label_xaksen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label_p);
            this.groupBox2.Controls.Add(this.label_random);
            this.groupBox2.Controls.Add(this.label_e);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label_y);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1202, 243);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verification";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label_validasi
            // 
            this.label_validasi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_validasi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_validasi.Location = new System.Drawing.Point(438, 148);
            this.label_validasi.Name = "label_validasi";
            this.label_validasi.Size = new System.Drawing.Size(176, 27);
            this.label_validasi.TabIndex = 43;
            this.label_validasi.Click += new System.EventHandler(this.label_validasi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(197, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "x =";
            // 
            // label_x
            // 
            this.label_x.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_x.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_x.Location = new System.Drawing.Point(233, 207);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(100, 27);
            this.label_x.TabIndex = 41;
            this.label_x.Click += new System.EventHandler(this.label_x_Click);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labe.Location = new System.Drawing.Point(18, 208);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(32, 19);
            this.labe.TabIndex = 40;
            this.labe.Text = "x\' =";
            // 
            // label_xaksen
            // 
            this.label_xaksen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_xaksen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_xaksen.Location = new System.Drawing.Point(54, 207);
            this.label_xaksen.Name = "label_xaksen";
            this.label_xaksen.Size = new System.Drawing.Size(100, 27);
            this.label_xaksen.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "p =";
            // 
            // label_p
            // 
            this.label_p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_p.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_p.Location = new System.Drawing.Point(54, 149);
            this.label_p.Name = "label_p";
            this.label_p.Size = new System.Drawing.Size(100, 27);
            this.label_p.TabIndex = 37;
            this.label_p.Text = " ";
            // 
            // label_random
            // 
            this.label_random.AutoSize = true;
            this.label_random.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_random.Location = new System.Drawing.Point(402, 88);
            this.label_random.Name = "label_random";
            this.label_random.Size = new System.Drawing.Size(30, 19);
            this.label_random.TabIndex = 35;
            this.label_random.Text = "e =";
            // 
            // label_e
            // 
            this.label_e.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_e.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_e.Location = new System.Drawing.Point(438, 82);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(330, 27);
            this.label_e.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(402, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "y =";
            // 
            // label_y
            // 
            this.label_y.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_y.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_y.Location = new System.Drawing.Point(438, 32);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(100, 27);
            this.label_y.TabIndex = 32;
            this.label_y.Text = " ";
            this.label_y.Click += new System.EventHandler(this.label_y_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(847, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 120);
            this.button2.TabIndex = 31;
            this.button2.Text = "Verif";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(206, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Load Kunci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "v =";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(54, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 27);
            this.label13.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "a =";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(54, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 27);
            this.label12.TabIndex = 20;
            this.label12.Text = " ";
            // 
            // Decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Decryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decryption";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem homeToolStripMenuItem1;
        private ToolStripMenuItem keyGenerationToolStripMenuItem;
        private ToolStripMenuItem encryptToolStripMenuItem;
        private ToolStripMenuItem decryptToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btn_save;
        private Button btn_decrypt;
        private Button btn_loadkprivate;
        private Label label7;
        private Label kprivate;
        private Label label4;
        private Label label2;
        private Button browse_file;
        private Label nama_file;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox ciphertext;
        private RichTextBox plaintext_board;
        private Label label11;
        private Label label12;
        private Button button1;
        private Label label3;
        private Label label13;
        private Label label_random;
        private Label label_e;
        private Label label8;
        private Label label_y;
        private Button button2;
        private Label label5;
        private Label label_p;
        private Label labe;
        private Label label_xaksen;
        private Label label_validasi;
        private Label label6;
        private Label label_x;
    }
}