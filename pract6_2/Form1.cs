using System;
using System.Windows.Forms;

namespace pract6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int Change(int[,] a)
        {
            int n = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a[i, j] % 2 != 0)
                    {
                        n++;
                    }
            return n;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            otvet1.Text = "";
            otvet2.Text = "";
            int n1, n2, m2;
            Random rnd = new Random();
            if (Int32.TryParse(textBox1.Text, out n1) && Int32.TryParse(textBox2.Text, out n2) && Int32.TryParse(textBox3.Text, out m2) && n1>0 && n2>0 && m2>0)
            {
                int[] a = new int[n1];
                for (int i = 0; i < n1; ++i)
                {

                    a[i] = rnd.Next(-10, 10);
                }
                for (int i = 0; i < a.Length; ++i)
                {
                    if (a[i] >= 0)
                    {
                        otvet1.Text += $" {a[i]}\n";
                    }
                    else
                    {
                        otvet1.Text += $"{a[i]}\n";
                    }
                }
                    
                int Mo = 0;
                for (int i = 0; i < a.Length; ++i)
                {
                    if (a[i] % 2 == 0)
                    {

                    }
                    else
                    {
                        Mo++;
                    }
                }
                otvet1.Text += $"\nКол-во нечет. элементов: {Mo}";


                int[,] b = new int[n2, m2];
                for (int i = 0; i < n2; ++i)
                {
                    for (int j = 0; j < m2; ++j)
                    {
                        b[i, j] = rnd.Next(-9, 9);
                    }
                }
                for (int i = 0; i < b.GetLength(0); ++i, otvet2.Text += "\n")
                {
                    for (int j = 0; j < b.GetLength(1); ++j)
                    {
                        if (b[i, j] >= 0)
                        {
                            otvet2.Text += $" {b[i, j]} ";
                        }
                        else
                        {
                            otvet2.Text += $"{b[i, j]} ";
                        }
                    }
                }

                int Md = 0;
                for (int i = 0; i < b.GetLength(0); ++i)
                    for (int j = 0; j < b.GetLength(1); ++j)
                        if (b[i, j] % 2 != 0)
                        {
                            Md++;
                        }
                otvet2.Text += $"\n\nКо-во нечет. элементов: {Md}";
            }
            else
            {
                MessageBox.Show("Неверные данные");
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
           