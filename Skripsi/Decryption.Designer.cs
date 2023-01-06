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
            this.plaintext = new System.Windows.Forms.RichTextBox();
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
            this.groupBox1.Controls.Add(this.plaintext);
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
            // plaintext
            // 
            this.plaintext.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plaintext.Location = new System.Drawing.Point(800, 104);
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(379, 168);
            this.plaintext.TabIndex = 17;
            this.plaintext.Text = "";
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
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1202, 290);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verification";
            // 
            // Decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 704);
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
        private RichTextBox plaintext;
    }
}