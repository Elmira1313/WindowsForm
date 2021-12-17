using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyArray a, b;
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            otvet1.Text = "?";
            int n, m;
            if(Int32.TryParse(textBox1.Text, out n) && Int32.TryParse(textBox2.Text, out m))
            {
                a = new MyArray(n, m);
                a.Vvod();
                a.Vivod(richTextBox1);
                otvet1.Text = $"{a.Line}";
            }
            else
            {
                richTextBox1.Text = "";
                otvet1.Text = "?";
                MessageBox.Show("Проверьте введенные данные");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            otvet2.Text = "?";
            int n, m;
            if (Int32.TryParse(textBox6.Text, out n) && Int32.TryParse(textBox5.Text, out m))
            {
                b = new MyArray(n, m);
                b.Vvod();
                b.Vivod(richTextBox2);
                otvet2.Text = $"{b.Line}";
            }
            else
            {
                richTextBox2.Text = "";
                otvet2.Text = "?";
                MessageBox.Show("Проверьте введенные данные");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a.MySort();
                richTextBox1.Text += "\nCортировка\n";
                a.MySort();
                a.Vivod(richTextBox1);
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                b.MySort();
                richTextBox2.Text += "\nCортировка\n";
                b.MySort();
                b.Vivod(richTextBox2);
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double x;
                richTextBox1.Text += "\nПрибавление\n";
                if (Double.TryParse(textBox3.Text, out x))
                {
                    a.Incr = x;
                    a.Vivod(richTextBox1);
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные");
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text += "\nПрибавление\n";
                double x;
                if (Double.TryParse(textBox4.Text, out x))
                {
                    b.Incr = x;
                    b.Vivod(richTextBox2);
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные");
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }
    }
    class MyArray
    {
        double[,] DoubleArray;
        int n, m;

        public MyArray(int N, int M)
        {
            n = N;
            m = M;
            DoubleArray = new double[n, m];
        }

        public void Vvod()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    DoubleArray[i, j] = rnd.Next(-10, 10);
                }
        }

        public void Vivod(RichTextBox a)
        {
            for (int i = 0; i < DoubleArray.GetLength(0); ++i, a.Text += "\n")
                for (int j = 0; j < DoubleArray.GetLength(1); ++j)
                {
                    a.Text += $"{Math.Round(DoubleArray[i, j], 1), 4}";
                }
        }

        public void MySort()
        {
            double temp;

            for (int i = 0; i < DoubleArray.GetLength(0); i++)
            {
                for (int j = 1; j < DoubleArray.GetLength(1); j++)
                {
                    if (DoubleArray[i, j] > DoubleArray[i, j - 1])
                    {
                        temp = DoubleArray[i, j];
                        DoubleArray[i, j] = DoubleArray[i, j - 1];
                        DoubleArray[i, j - 1] = temp;
                    }                    
                }
                for (int j = 0; j < DoubleArray.GetLength(1)-1; j++)
                {
                    if (DoubleArray[i, j] < DoubleArray[i, j + 1])
                    {
                        temp = DoubleArray[i, j];
                        DoubleArray[i, j] = DoubleArray[i, j + 1];
                        DoubleArray[i, j + 1] = temp;
                    }
                }
            }

        }

        public int Line
        {
            get
            {
                return DoubleArray.Length;
            }
        }

        public double Incr
        {
            set
            {
                for (int i = 0; i < DoubleArray.GetLength(0); i++)
                {
                    for (int j = 0; j < DoubleArray.GetLength(1); j++)
                    {
                        DoubleArray[i, j] = DoubleArray[i, j] + value;
                    }
                }
            }
        }
    }
}
