namespace Calculator_Windows
{
    partial class Form1
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
            this.Operasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.btnHasil = new System.Windows.Forms.Button();
            this.Hasil = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Operasi
            // 
            this.Operasi.FormattingEnabled = true;
            this.Operasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.Operasi.Location = new System.Drawing.Point(95, 28);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(152, 24);
            this.Operasi.TabIndex = 0;
            this.Operasi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(95, 68);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(152, 22);
            this.txtNilaiA.TabIndex = 5;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(95, 104);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(152, 22);
            this.txtNilaiB.TabIndex = 6;
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(171, 176);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(76, 29);
            this.btnHasil.TabIndex = 8;
            this.btnHasil.Text = "Hitung";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // Hasil
            // 
            this.Hasil.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Hasil.FormattingEnabled = true;
            this.Hasil.ItemHeight = 16;
            this.Hasil.Location = new System.Drawing.Point(95, 140);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(152, 20);
            this.Hasil.TabIndex = 9;
            this.Hasil.SelectedIndexChanged += new System.EventHandler(this.Hasil_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 393);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operasi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Operasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.ListBox Hasil;
    }
}

