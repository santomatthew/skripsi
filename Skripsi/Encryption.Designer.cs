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
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_d2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ciphertext = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kpublik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plaintext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browse_file = new System.Windows.Forms.Button();
            this.nama_file = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_d2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ciphertext);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kpublik);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.plaintext);
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
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // ciphertext
            // 
            this.ciphertext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ciphertext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ciphertext.Location = new System.Drawing.Point(714, 112);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(379, 160);
            this.ciphertext.TabIndex = 8;
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
            // plaintext
            // 
            this.plaintext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plaintext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plaintext.Location = new System.Drawing.Point(6, 112);
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(362, 160);
            this.plaintext.TabIndex = 4;
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
            // Encryptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 580);
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
        private Label ciphertext;
        private Label label7;
        private Label kpublik;
        private Label label4;
        private Label plaintext;
        private Label label3;
        private Label label5;
        private TextBox label_d2;
        private Button button3;
    }
}