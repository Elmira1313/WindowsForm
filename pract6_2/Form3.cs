using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract6_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        static void Rezalt(int[,] a)
        {
            int s = a.GetLength(1), r, buf;
            if (s % 2 == 0)
            {
                r = s / 2 - 1;

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    buf = a[i, r];
                    a[i, r] = a[i, r + 1];
                    a[i, r + 1] = buf;
                }
            }
            else
            {
                r = (s - 1) / 2;
                for (int i = 0; i < a.GetLength(0); ++i)
                {
                    buf = a[i, 0];
                    a[i, 0] = a[i, r];
                    a[i, r] = buf;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            otvet2.Text = "";

            int n;
            Random rnd = new Random();
            if (Int32.TryParse(textBox2.Text, out n) && n>0)
            {
                int[,] a = new int[n, n];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        a[i, j] = rnd.Next(-9,9);
                    }
                }

                for (int i = 0; i < a.GetLength(0); ++i, otvet2.Text += "\n")
                {
                    for (int j = 0; j < a.GetLength(1); ++j)
                    {
                        if (a[i, j] >= 0)
                        {
                            otvet2.Text += $" {a[i, j]} ";
                        }
                        else
                        {
                            otvet2.Text += $"{a[i, j]} ";
                        }
                    }
                }

                Rezalt(a);

                otvet2.Text += $"\n\n\n";

                for (int i = 0; i < a.GetLength(0); ++i, otvet2.Text += "\n")
                {
                    for (int j = 0; j < a.GetLength(1); ++j)
                    {
                        if (a[i, j] >= 0)
                        {
                            otvet2.Text += $" {a[i, j]} ";
                        }
                        else
                        {
                            otvet2.Text += $"{a[i, j]} ";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
