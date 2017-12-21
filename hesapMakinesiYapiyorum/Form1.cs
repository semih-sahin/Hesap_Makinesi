using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesiYapiyorum
{
    public partial class Form1 : Form
    {
        double toplam = 0, fark = 0, carpim = 0, bolum = 0, sayi1, sayi2;

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            fark = sayi1 - sayi2;
            textBox3.Text = Convert.ToString(fark);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            carpim = sayi1 * sayi2;
            textBox3.Text = Convert.ToString(carpim);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            if (sayi2 == 0 && sayi1 != 0)
            {
                textBox3.Text = "Sonsuz";
            }
            if (sayi2 == 0 && sayi1 == 0)
            {
                textBox3.Text = "Belirsiz";
                return;
            }
            bolum = sayi1 / sayi2;
            textBox3.Text = Convert.ToString(bolum);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 + sayi2;
            textBox3.Text = Convert.ToString(toplam);
        }
    }
}
