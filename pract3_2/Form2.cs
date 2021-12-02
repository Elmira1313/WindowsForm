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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = "II. Постройте таблицу значений функции y=f(x) \nдля  х принадлежащем [a, b]  с шагом h.";
        }

        static double f2(double x)
        {
            double y = 0;
            if (x < 0) y = -4;
            else if (x >= 0 && x < 1) y = x * x + 3 * x + 4;
            else y = 2;
            return y;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            otvet.Text = "";
            double a, b, h;
            if (Double.TryParse(textBox1.Text, out a) && Double.TryParse(textBox2.Text, out b) && Double.TryParse(textBox3.Text, out h))
            {
                for (double i = a; i <= b; i += h)
                    otvet.Text += $"f({Math.Round(i, 2)}) = {Math.Round(f2(i), 2)}\n";
            }
            else
            {
                otvet.Text = "?";
                MessageBox.Show("Вы ввели что-то не то");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
