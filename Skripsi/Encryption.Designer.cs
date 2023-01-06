namespace Skripsi
{
    partial class Encryptform
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
            this.plaintext = new System.Windows.Forms.RichTextBox();
            this.ciphertext = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_d2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kpublik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browse_file = new System.Windows.Forms.Button();
            this.nama_file = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_generatekey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip2.Size = new System.Drawing.Size(1149, 24);
            this.menuStrip2.TabIndex = 16;
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
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plaintext);
            this.groupBox1.Controls.Add(this.ciphertext);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_d2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kpublik);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.browse_file);
            this.groupBox1.Controls.Add(this.nama_file);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 342);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // plaintext
            // 
            this.plaintext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plaintext.Location = new System.Drawing.Point(6, 112);
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(379, 160);
            this.plaintext.TabIndex = 16;
            this.plaintext.Text = "";
            // 
            // ciphertext
            // 
            this.ciphertext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ciphertext.Location = new System.Drawing.Point(714, 104);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(379, 168);
            this.ciphertext.TabIndex = 15;
            this.ciphertext.Text = "";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(947, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "Simpan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(433, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "d2 :";
            // 
            // label_d2
            // 
            this.label_d2.Location = new System.Drawing.Point(474, 32);
            this.label_d2.Name = "label_d2";
            this.label_d2.Size = new System.Drawing.Size(100, 31);
            this.label_d2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(714, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Encrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(474, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Load Public Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(714, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ciphertext  :";
            // 
            // kpublik
            // 
            this.kpublik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kpublik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kpublik.Location = new System.Drawing.Point(474, 112);
            this.kpublik.Name = "kpublik";
            this.kpublik.Size = new System.Drawing.Size(146, 160);
            this.kpublik.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(474, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Public Key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plaintext :";
            // 
            // browse_file
            // 
            this.browse_file.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browse_file.Location = new System.Drawing.Point(286, 30);
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
            this.nama_file.Location = new System.Drawing.Point(124, 34);
            this.nama_file.Name = "nama_file";
            this.nama_file.Size = new System.Drawing.Size(144, 27);
            this.nama_file.TabIndex = 1;
            this.nama_file.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File (*docx)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btn_generatekey);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1125, 231);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Digital Signature";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(525, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 31);
            this.button7.TabIndex = 32;
            this.button7.Text = "Generate r";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(366, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 19);
            this.label14.TabIndex = 31;
            this.label14.Text = "r =";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(401, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 30;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(525, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 31);
            this.button6.TabIndex = 29;
            this.button6.Text = "Generate S";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "v =";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(401, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 27);
            this.label13.TabIndex = 27;
            // 
            // btn_generatekey
            // 
            this.btn_generatekey.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_generatekey.Location = new System.Drawing.Point(525, 138);
            this.btn_generatekey.Name = "btn_generatekey";
            this.btn_generatekey.Size = new System.Drawing.Size(158, 32);
            this.btn_generatekey.TabIndex = 26;
            this.btn_generatekey.Text = "Generate Public Key";
            this.btn_generatekey.UseVisualStyleBackColor = true;
            this.btn_generatekey.Click += new System.EventHandler(this.btn_generatekey_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(366, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "s =";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(401, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 24;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(6, 194);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(116, 27);
            this.btn_reset.TabIndex = 23;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(149, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 27);
            this.button5.TabIndex = 22;
            this.button5.Text = "Generate a";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "a =";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(43, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 27);
            this.label12.TabIndex = 18;
            this.label12.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "q =";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(43, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 27);
            this.label10.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "p =";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(149, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 27);
            this.button4.TabIndex = 15;
            this.button4.Text = "Generate q";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Encryptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Encryptform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private Label label1;
        private Button browse_file;
        private Label nama_file;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label kpublik;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox label_d2;
        private Button button3;
        private GroupBox groupBox2;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label8;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private Label label12;
        private Button btn_reset;
        private Label label6;
        private TextBox textBox2;
        private Button button6;
        private Label label13;
        private Button btn_generatekey;
        private RichTextBox plaintext;
        private RichTextBox ciphertext;
        private Button button7;
        private Label label14;
        private TextBox textBox3;
    }
}