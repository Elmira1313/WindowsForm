using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "I. Разработать метод f(n), который для заданного \nнатурального числа n находит значение scrt(n)+n. \nВычислить с помощью него значение выражения \n\n(scrt(6)+6)/2+(scrt(13)+13)/2+(scrt(21)+21)/2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        static double f1(double n)
        {
            double r = Math.Sqrt(n) + n;
            return r;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int n = 3;
            double x1, x2, x3, z = 0;
            if (Double.TryParse(textBox1.Text, out x1) && Double.TryParse(textBox2.Text, out x2) && Double.TryParse(textBox3.Text, out x3))
            {
                z = f1(x1) / 2 + f1(x2) / 2 + f1(x3) / 2;
                otvet.Text = $"{Math.Round(z, 5)}";
            }
            else
            {
                otvet.Text = "?";
                MessageBox.Show("Вы ввели что-то не то");
            }

            
        }
    }
}
