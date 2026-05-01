namespace KalkulatorKu
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
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblEkspresi = new System.Windows.Forms.Label();
            this.buttonpersen = new System.Windows.Forms.Button();
            this.buttonce = new System.Windows.Forms.Button();
            this.buttonhapus = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonbagi = new System.Windows.Forms.Button();
            this.buttonakarkuadrat = new System.Windows.Forms.Button();
            this.buttonkuadrat = new System.Windows.Forms.Button();
            this.buttonreciprocal = new System.Windows.Forms.Button();
            this.buttonkurang = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonkali = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonsamadengan = new System.Windows.Forms.Button();
            this.buttonkoma = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonplusminus = new System.Windows.Forms.Button();
            this.buttontambah = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.lblHasil);
            this.pnlBorder.Controls.Add(this.lblEkspresi);
            this.pnlBorder.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.pnlBorder.Location = new System.Drawing.Point(20, 31);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBorder.Size = new System.Drawing.Size(532, 100);
            this.pnlBorder.TabIndex = 0;
            // 
            // lblHasil
            // 
            this.lblHasil.BackColor = System.Drawing.Color.White;
            this.lblHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblHasil.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblHasil.Location = new System.Drawing.Point(5, 30);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(520, 63);
            this.lblHasil.TabIndex = 0;
            this.lblHasil.Text = "0";
            this.lblHasil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEkspresi
            // 
            this.lblEkspresi.BackColor = System.Drawing.Color.White;
            this.lblEkspresi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEkspresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEkspresi.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblEkspresi.Location = new System.Drawing.Point(5, 5);
            this.lblEkspresi.Name = "lblEkspresi";
            this.lblEkspresi.Size = new System.Drawing.Size(520, 25);
            this.lblEkspresi.TabIndex = 1;
            this.lblEkspresi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonpersen
            // 
            this.buttonpersen.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonpersen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonpersen.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonpersen.Location = new System.Drawing.Point(20, 167);
            this.buttonpersen.Name = "buttonpersen";
            this.buttonpersen.Size = new System.Drawing.Size(106, 47);
            this.buttonpersen.TabIndex = 1;
            this.buttonpersen.Text = "%";
            this.buttonpersen.UseVisualStyleBackColor = false;
            this.buttonpersen.Click += new System.EventHandler(this.buttonpersen_Click);
            // 
            // buttonce
            // 
            this.buttonce.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonce.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonce.Location = new System.Drawing.Point(162, 167);
            this.buttonce.Name = "buttonce";
            this.buttonce.Size = new System.Drawing.Size(106, 47);
            this.buttonce.TabIndex = 2;
            this.buttonce.Text = "CE";
            this.buttonce.UseVisualStyleBackColor = false;
            this.buttonce.Click += new System.EventHandler(this.buttonce_Click);
            // 
            // buttonhapus
            // 
            this.buttonhapus.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonhapus.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonhapus.Location = new System.Drawing.Point(446, 167);
            this.buttonhapus.Name = "buttonhapus";
            this.buttonhapus.Size = new System.Drawing.Size(106, 47);
            this.buttonhapus.TabIndex = 4;
            this.buttonhapus.Text = "⌫";
            this.buttonhapus.UseVisualStyleBackColor = false;
            this.buttonhapus.Click += new System.EventHandler(this.buttonhapus_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonclear.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonclear.Location = new System.Drawing.Point(304, 167);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(106, 47);
            this.buttonclear.TabIndex = 3;
            this.buttonclear.Text = "C";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonbagi
            // 
            this.buttonbagi.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonbagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonbagi.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonbagi.Location = new System.Drawing.Point(446, 225);
            this.buttonbagi.Name = "buttonbagi";
            this.buttonbagi.Size = new System.Drawing.Size(106, 47);
            this.buttonbagi.TabIndex = 8;
            this.buttonbagi.Text = "÷";
            this.buttonbagi.UseVisualStyleBackColor = false;
            this.buttonbagi.Click += new System.EventHandler(this.buttonbagi_Click);
            // 
            // buttonakarkuadrat
            // 
            this.buttonakarkuadrat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonakarkuadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonakarkuadrat.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonakarkuadrat.Location = new System.Drawing.Point(304, 225);
            this.buttonakarkuadrat.Name = "buttonakarkuadrat";
            this.buttonakarkuadrat.Size = new System.Drawing.Size(106, 47);
            this.buttonakarkuadrat.TabIndex = 7;
            this.buttonakarkuadrat.Text = "√x";
            this.buttonakarkuadrat.UseVisualStyleBackColor = false;
            this.buttonakarkuadrat.Click += new System.EventHandler(this.buttonakarkuadrat_Click);
            // 
            // buttonkuadrat
            // 
            this.buttonkuadrat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonkuadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonkuadrat.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonkuadrat.Location = new System.Drawing.Point(162, 225);
            this.buttonkuadrat.Name = "buttonkuadrat";
            this.buttonkuadrat.Size = new System.Drawing.Size(106, 47);
            this.buttonkuadrat.TabIndex = 6;
            this.buttonkuadrat.Text = "x²";
            this.buttonkuadrat.UseVisualStyleBackColor = false;
            this.buttonkuadrat.Click += new System.EventHandler(this.buttonkuadrat_Click);
            // 
            // buttonreciprocal
            // 
            this.buttonreciprocal.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonreciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonreciprocal.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonreciprocal.Location = new System.Drawing.Point(20, 225);
            this.buttonreciprocal.Name = "buttonreciprocal";
            this.buttonreciprocal.Size = new System.Drawing.Size(106, 47);
            this.buttonreciprocal.TabIndex = 5;
            this.buttonreciprocal.Text = "¹/x";
            this.buttonreciprocal.UseVisualStyleBackColor = false;
            this.buttonreciprocal.Click += new System.EventHandler(this.buttonreciprocal_Click);
            // 
            // buttonkurang
            // 
            this.buttonkurang.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonkurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonkurang.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonkurang.Location = new System.Drawing.Point(446, 341);
            this.buttonkurang.Name = "buttonkurang";
            this.buttonkurang.Size = new System.Drawing.Size(106, 47);
            this.buttonkurang.TabIndex = 16;
            this.buttonkurang.Text = "-";
            this.buttonkurang.UseVisualStyleBackColor = false;
            this.buttonkurang.Click += new System.EventHandler(this.buttonkurang_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(304, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 47);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(162, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 47);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(20, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 47);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // buttonkali
            // 
            this.buttonkali.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonkali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonkali.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonkali.Location = new System.Drawing.Point(446, 283);
            this.buttonkali.Name = "buttonkali";
            this.buttonkali.Size = new System.Drawing.Size(106, 47);
            this.buttonkali.TabIndex = 12;
            this.buttonkali.Text = "×";
            this.buttonkali.UseVisualStyleBackColor = false;
            this.buttonkali.Click += new System.EventHandler(this.buttonkali_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(304, 283);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 47);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(162, 283);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 47);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(20, 283);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 47);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonsamadengan
            // 
            this.buttonsamadengan.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsamadengan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonsamadengan.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonsamadengan.Location = new System.Drawing.Point(446, 457);
            this.buttonsamadengan.Name = "buttonsamadengan";
            this.buttonsamadengan.Size = new System.Drawing.Size(106, 47);
            this.buttonsamadengan.TabIndex = 24;
            this.buttonsamadengan.Text = "=";
            this.buttonsamadengan.UseVisualStyleBackColor = false;
            this.buttonsamadengan.Click += new System.EventHandler(this.buttonsamadengan_Click);
            // 
            // buttonkoma
            // 
            this.buttonkoma.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonkoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonkoma.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonkoma.Location = new System.Drawing.Point(304, 457);
            this.buttonkoma.Name = "buttonkoma";
            this.buttonkoma.Size = new System.Drawing.Size(106, 47);
            this.buttonkoma.TabIndex = 23;
            this.buttonkoma.Text = ",";
            this.buttonkoma.UseVisualStyleBackColor = false;
            this.buttonkoma.Click += new System.EventHandler(this.buttonkoma_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button0.Location = new System.Drawing.Point(162, 457);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(106, 47);
            this.button0.TabIndex = 22;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonplusminus
            // 
            this.buttonplusminus.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonplusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonplusminus.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttonplusminus.Location = new System.Drawing.Point(20, 457);
            this.buttonplusminus.Name = "buttonplusminus";
            this.buttonplusminus.Size = new System.Drawing.Size(106, 47);
            this.buttonplusminus.TabIndex = 21;
            this.buttonplusminus.Text = "+/−";
            this.buttonplusminus.UseVisualStyleBackColor = false;
            this.buttonplusminus.Click += new System.EventHandler(this.buttonplusminus_Click);
            // 
            // buttontambah
            // 
            this.buttontambah.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttontambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttontambah.ForeColor = System.Drawing.Color.LavenderBlush;
            this.buttontambah.Location = new System.Drawing.Point(446, 399);
            this.buttontambah.Name = "buttontambah";
            this.buttontambah.Size = new System.Drawing.Size(106, 47);
            this.buttontambah.TabIndex = 20;
            this.buttontambah.Text = "+";
            this.buttontambah.UseVisualStyleBackColor = false;
            this.buttontambah.Click += new System.EventHandler(this.buttontambah_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(304, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(162, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(20, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(575, 521);
            this.Controls.Add(this.buttonsamadengan);
            this.Controls.Add(this.buttonkoma);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonplusminus);
            this.Controls.Add(this.buttontambah);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonkurang);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonkali);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonbagi);
            this.Controls.Add(this.buttonakarkuadrat);
            this.Controls.Add(this.buttonkuadrat);
            this.Controls.Add(this.buttonreciprocal);
            this.Controls.Add(this.buttonhapus);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonce);
            this.Controls.Add(this.buttonpersen);
            this.Controls.Add(this.pnlBorder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator Klawdia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblEkspresi;
        private System.Windows.Forms.Button buttonpersen;
        private System.Windows.Forms.Button buttonce;
        private System.Windows.Forms.Button buttonhapus;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonbagi;
        private System.Windows.Forms.Button buttonakarkuadrat;
        private System.Windows.Forms.Button buttonkuadrat;
        private System.Windows.Forms.Button buttonreciprocal;
        private System.Windows.Forms.Button buttonkurang;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonkali;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonsamadengan;
        private System.Windows.Forms.Button buttonkoma;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonplusminus;
        private System.Windows.Forms.Button buttontambah;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}