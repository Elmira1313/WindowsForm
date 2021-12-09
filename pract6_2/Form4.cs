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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        static int[] sum(int[][] a)
        {
            int n;
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; ++i)
                for (int j = 0; j < a.Length; ++j)
                    if (a[i][j] >= 0 && a[i][j] % 2 == 0)
                    {
                        arr[j] += a[i][j];
                    }
            return arr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otvet1.Text = "";

            int n;
            Random rnd = new Random();
            if (Int32.TryParse(textBox1.Text, out n) && n>0)
            {
                int[][] a = new int[n][];
                for (int i = 0; i < n; ++i)
                {
                    a[i] = new int[n];
                    for (int j = 0; j < n; ++j)
                    {
                        a[i][j] = rnd.Next(-9, 9);
                    }
                }

                for (int i = 0; i < a.Length; ++i, otvet1.Text += "\n")
                {
                    for (int j = 0; j < a[i].Length; ++j)
                    {
                        if (a[i][j] >= 0)
                        {
                            otvet1.Text += $" {a[i][j]} ";
                        }
                        else
                        {
                            otvet1.Text += $"{a[i][j]} ";
                        }
                    }
                }
                int[] rez = new int[a[0].Length];
                for (int i = 0; i < a.Length; ++i)
                    for (int j = 0; j < a[i].Length; ++j)
                        rez[j] = sum(a)[j];

                otvet1.Text += $"\nНовый массив:\n";

                for (int i = 0; i < a.Length; ++i)
                {
                    if (rez[i] >= 0)
                    {
                        otvet1.Text += $" {rez[i]} ";
                    }
                    else
                    {
                        otvet1.Text += $"{rez[i]} ";
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
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
