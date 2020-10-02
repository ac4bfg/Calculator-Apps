using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Hasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = int.Parse(txtNilaiB.Text);

            Hasil.Items.Clear();

            if (Operasi.Text == "Penjumlahan")
            {
                Hasil.Items.Add(Penjumlahan(a, b));
            }
            else if (Operasi.Text == "Pengurangan")
            {
                Hasil.Items.Add(Pengurangan(a, b));
            }
            else if (Operasi.Text == "Perkalian")
            {
                Hasil.Items.Add(Perkalian(a, b));
            }
            else
            {
                Hasil.Items.Add(Pembagian(a, b));
            }
        }
    }
}
