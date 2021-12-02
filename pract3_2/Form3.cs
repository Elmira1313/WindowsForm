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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label2.Text = "III. Перегрузите метод f из I задания так,\nчтобы его сигнатура (заголовок) соответствовала виду \nstatic void f (double x, out double y).  \nПродемонстрируйте работу перегруженных методов";
        }

        static double f1(double n)
        {
            double r = Math.Sqrt(n) + n;
            return r;
        }
        static void f1(double n, out double y)
        {
            y = (Math.Sqrt(n) + n) / 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = 3;
            double x1, x2, x3, z1 = 0, z2 = 0, y;
            if (Double.TryParse(textBox1.Text, out x1) && Double.TryParse(textBox2.Text, out x2) && Double.TryParse(textBox3.Text, out x3))
            {
                z1 = f1(x1) / 2 + f1(x2) / 2 + f1(x3) / 2;
                otvet1.Text = $"{Math.Round(z1, 5)}";
                f1(x1, out y);
                z2 += y;
                f1(x2, out y);
                z2 += y;
                f1(x3, out y);
                z2 += y;
                otvet2.Text = $"{Math.Round(z2, 5)}";
            }
            else
            {
                otvet1.Text = "?";
                otvet2.Text = "?";
                MessageBox.Show("Вы ввели что-то не то");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
