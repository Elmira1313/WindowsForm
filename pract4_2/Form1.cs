using System;
using System.Windows.Forms;

namespace pract4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f1(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return 1 / f1(x, Math.Abs(n));
            }
            else
            {
                return x * f1(x, n - 1);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double x, z=0;
            int n;
            otvet.Text = "x^n = ";
            if (Double.TryParse(textBox1.Text, out x) && x!=0 && Int32.TryParse(textBox2.Text, out n))
            {
                try
                {
                    z += f1(x, n);
                    otvet.Text += $"{Math.Round(z, 5)}";
                }
                catch (Exception)
                {
                    otvet.Text = "x^n = ";
                    MessageBox.Show("Что-то введено не так!");
                }
            }
            else
            {
                otvet.Text = "x^n = ";
                MessageBox.Show("Что-то введено не так!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
