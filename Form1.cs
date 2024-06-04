using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cıkarma =Convert.ToDouble(textBox8.Text) / 4;
            double sonuc = Convert.ToDouble(textBox1.Text) - cıkarma;
            double cıkarma2 = Convert.ToDouble(textBox7.Text) / 4;
            double sonuc2 = Convert.ToDouble(textBox4.Text) - cıkarma;
            double cıkarma3 = Convert.ToDouble(textBox6.Text) / 4;
            double sonuc3 = Convert.ToDouble(textBox3.Text) - cıkarma;
            double cıkarma4 = Convert.ToDouble(textBox5.Text) / 4;
            double sonuc4 = Convert.ToDouble(textBox2.Text) - cıkarma;

            label10.Text =Convert.ToString(sonuc);
            label11.Text = Convert.ToString(sonuc2);
            label12.Text = Convert.ToString(sonuc3);
            label13.Text = Convert.ToString(sonuc4);
            double toplamnet = sonuc + sonuc2 + sonuc3 + sonuc4;
            label14.Text = Convert.ToString(toplamnet);


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
