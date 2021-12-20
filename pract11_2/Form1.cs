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
            button17.Enabled = false;
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "\nУмножение на число\n";
                double x;
                if (Double.TryParse(x1.Text, out x))
                {
                    a = a * x;
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text += "\nУмножение на число\n";
                double x;
                if (Double.TryParse(x2.Text, out x))
                {
                    b = b * x;
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "\n++\n";
                double x;
                a = a++;
                a.Vivod(richTextBox1);
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "\n--\n";
                double x;
                a = a--;
                a.Vivod(richTextBox1);
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (a)
                {
                    MessageBox.Show("Элементы строк возрают");
                }
                else
                {
                    MessageBox.Show("Элементы строк не возрают");
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text += "\n++\n";
                double x;
                b = b++;
                b.Vivod(richTextBox2);
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text += "\n--\n";
                double x;
                b = b--;
                b.Vivod(richTextBox2);
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (b)
                {
                    MessageBox.Show("Элементы строк возрают");
                }
                else
                {
                    MessageBox.Show("Элементы строк не возрают");
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        MyArray s;

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text = "";
                otvet3.Text = "?";

                s = a * b;
                if (s != null)
                {
                    s.Vivod(richTextBox3);
                    otvet3.Text = $"{s.Line}";
                }
                else
                {
                    richTextBox3.Text = "Матрицы нельзя перемножить";
                }                
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }
        double[][] r;
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text = "Преобразование в массив\n\n";

                r = (double[][])s;
                for (int i = 0; i < r.Length; ++i, richTextBox3.Text += "\n")
                    for (int j = 0; j < r[i].Length; ++j)
                        richTextBox3.Text += $"{Math.Round(r[i][j], 1),5}";
                button17.Enabled = true;
                button16.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text = "Преобразование в класс\n\n";
                MyArray bufa = (MyArray)r;
                bufa.Vivod(richTextBox3);
                button16.Enabled = true;
                button17.Enabled = true;
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
                    a.Text += $"{Math.Round(DoubleArray[i, j], 1), 5}";
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

        public static MyArray operator ++(MyArray a)
        {
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < a.DoubleArray.GetLength(1); j++)
                {
                    a.DoubleArray[i, j] = a.DoubleArray[i, j] + 1;
                }
            }
            return a;
        }

        public static MyArray operator --(MyArray a)
        {
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < a.DoubleArray.GetLength(1); j++)
                {
                    a.DoubleArray[i, j] = a.DoubleArray[i, j] - 1;
                }
            }
            return a;
        }

        public static bool operator true(MyArray a)
        {
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 1; j < a.DoubleArray.GetLength(1); j++)
                {
                    if (a.DoubleArray[i, j] < a.DoubleArray[i, j - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(MyArray a)
        {
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 1; j < a.DoubleArray.GetLength(1); j++)
                {
                    if (a.DoubleArray[i, j] > a.DoubleArray[i, j - 1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static MyArray operator *(MyArray a, MyArray b)
        {
            if (a.m == b.n)
            {
                MyArray c = new MyArray(a.n, b.m);
                double sum = 0;
                for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
                {
                    for (int j = 0; j < b.DoubleArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < b.DoubleArray.GetLength(0); k++)
                        {
                            sum += a.DoubleArray[i, k] * b.DoubleArray[k, j];
                        }
                        c.DoubleArray[i, j] = sum;
                        sum = 0;
                    }
                }
                return c;
            }
            else
            {
                return null;
            }
        }

        public static MyArray operator *(MyArray a, double b)
        {
            MyArray c = new MyArray(a.n, a.m);
            double sum = 0;
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < a.DoubleArray.GetLength(1); j++)
                {
                    c.DoubleArray[i, j] = a.DoubleArray[i, j] * b;
                }
            }
            return c;
        }

        //***********************************************************************

        public static explicit operator double[][](MyArray a)
        {
            double[][] buf = new double[a.n][];
            for (int i = 0; i < a.n; i++)
            {
                buf[i] = new double[a.m];
                for (int j = 0; j < a.m; j++)
                {
                    buf[i][j] = a.DoubleArray[i, j];
                }
            }
            return buf;
        }

        public static explicit operator MyArray(double[][] a)
        {
            int n = a.GetLength(0);
            int m = a[0].Length;
            MyArray b = new MyArray(n, m);
            for (int chet = 1; chet < a.GetLength(0); chet++)
            {
                if (a[chet].Length == a[chet - 1].Length)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            b.DoubleArray[i, j] = a[i][j];
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            return b;
        }
    }
}
