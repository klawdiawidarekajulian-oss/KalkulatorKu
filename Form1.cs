using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorKu
{
    public partial class Form1 : Form
    {
        // ==================== VARIABEL KALKULATOR ====================
        double angkaPertama = 0;
        string operatorDipilih = "";
        bool tungguAngkaKedua = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tidak perlu cari Label lagi karena sudah ada di designer
            // lblHasil dan lblEkspresi sudah langsung tersedia
        }

        // ==================== FUNGSI INPUT ANGKA ====================
        private void InputAngka(string angka)
        {
            if (tungguAngkaKedua)
            {
                lblHasil.Text = angka;
                tungguAngkaKedua = false;
            }
            else
            {
                if (lblHasil.Text == "0")
                    lblHasil.Text = angka;
                else
                    lblHasil.Text = lblHasil.Text + angka;
            }
        }

        // ==================== TOMBOL ANGKA ====================
        private void button1_Click_1(object sender, EventArgs e) { InputAngka("1"); }
        private void button2_Click_1(object sender, EventArgs e) { InputAngka("2"); }
        private void button3_Click_1(object sender, EventArgs e) { InputAngka("3"); }
        private void button4_Click_1(object sender, EventArgs e) { InputAngka("4"); }
        private void button5_Click_1(object sender, EventArgs e) { InputAngka("5"); }
        private void button6_Click_1(object sender, EventArgs e) { InputAngka("6"); }
        private void button7_Click(object sender, EventArgs e) { InputAngka("7"); }
        private void button8_Click(object sender, EventArgs e) { InputAngka("8"); }
        private void button9_Click(object sender, EventArgs e) { InputAngka("9"); }
        private void button0_Click(object sender, EventArgs e) { InputAngka("0"); }

        // ==================== TOMBOL FUNGSI ====================

        private void buttonkoma_Click(object sender, EventArgs e)
        {
            if (!lblHasil.Text.Contains(",") && !lblHasil.Text.Contains("."))
            {
                lblHasil.Text = lblHasil.Text + ",";
            }
        }

        private void buttonplusminus_Click(object sender, EventArgs e)
        {
            double nilai = double.Parse(lblHasil.Text);
            nilai = -nilai;
            lblHasil.Text = nilai.ToString();
        }

        private void buttonpersen_Click(object sender, EventArgs e)
        {
            double nilai = double.Parse(lblHasil.Text);
            nilai = nilai / 100;
            lblHasil.Text = nilai.ToString();
        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            lblHasil.Text = "0";
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            lblHasil.Text = "0";
            angkaPertama = 0;
            operatorDipilih = "";
            tungguAngkaKedua = false;
            lblEkspresi.Text = "";
        }

        private void buttonhapus_Click(object sender, EventArgs e)
        {
            if (lblHasil.Text.Length > 1)
            {
                lblHasil.Text = lblHasil.Text.Substring(0, lblHasil.Text.Length - 1);
            }
            else
            {
                lblHasil.Text = "0";
            }
        }

        private void buttonreciprocal_Click(object sender, EventArgs e)
        {
            double nilai = double.Parse(lblHasil.Text);
            if (nilai != 0)
            {
                nilai = 1 / nilai;
                lblHasil.Text = nilai.ToString();
            }
            else
            {
                lblHasil.Text = "Error";
            }
        }

        private void buttonkuadrat_Click(object sender, EventArgs e)
        {
            double nilai = double.Parse(lblHasil.Text);
            nilai = nilai * nilai;
            lblHasil.Text = nilai.ToString();
        }

        private void buttonakarkuadrat_Click(object sender, EventArgs e)
        {
            double nilai = double.Parse(lblHasil.Text);
            if (nilai >= 0)
            {
                nilai = Math.Sqrt(nilai);
                lblHasil.Text = nilai.ToString();
            }
            else
            {
                lblHasil.Text = "Error";
            }
        }

        // ==================== TOMBOL OPERATOR ====================

        private void buttonbagi_Click(object sender, EventArgs e)
        {
            angkaPertama = double.Parse(lblHasil.Text);
            operatorDipilih = "/";
            tungguAngkaKedua = true;
            lblEkspresi.Text = angkaPertama.ToString() + " ÷";
        }

        private void buttonkali_Click(object sender, EventArgs e)
        {
            angkaPertama = double.Parse(lblHasil.Text);
            operatorDipilih = "*";
            tungguAngkaKedua = true;
            lblEkspresi.Text = angkaPertama.ToString() + " ×";
        }

        private void buttonkurang_Click(object sender, EventArgs e)
        {
            angkaPertama = double.Parse(lblHasil.Text);
            operatorDipilih = "-";
            tungguAngkaKedua = true;
            lblEkspresi.Text = angkaPertama.ToString() + " -";
        }

        private void buttontambah_Click(object sender, EventArgs e)
        {
            angkaPertama = double.Parse(lblHasil.Text);
            operatorDipilih = "+";
            tungguAngkaKedua = true;
            lblEkspresi.Text = angkaPertama.ToString() + " +";
        }

        private void buttonsamadengan_Click(object sender, EventArgs e)
        {
            double angkaKedua = double.Parse(lblHasil.Text);
            double hasil = 0;

            switch (operatorDipilih)
            {
                case "+":
                    hasil = angkaPertama + angkaKedua;
                    break;
                case "-":
                    hasil = angkaPertama - angkaKedua;
                    break;
                case "*":
                    hasil = angkaPertama * angkaKedua;
                    break;
                case "/":
                    if (angkaKedua != 0)
                        hasil = angkaPertama / angkaKedua;
                    else
                    {
                        lblHasil.Text = "Error";
                        return;
                    }
                    break;
                default:
                    return;
            }

            lblEkspresi.Text = angkaPertama.ToString() + " " + operatorDipilih + " " + angkaKedua.ToString() + " =";
            lblHasil.Text = hasil.ToString();
            operatorDipilih = "";
            tungguAngkaKedua = true;
        }

        // ==================== EVENT LAMA YANG TIDAK DIPAKAI ====================
        private void button1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void button6_Click(object sender, EventArgs e) { }
        private void button14_Click(object sender, EventArgs e) { }
        private void button15_Click(object sender, EventArgs e) { }
        private void button16_Click(object sender, EventArgs e) { }
        private void button19_Click(object sender, EventArgs e) { }
    }
}