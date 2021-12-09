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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static double Max(double[] a)
        {
            double max = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] > max) max = a[i];
            return max;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otvet1.Text = "";
            otvet2.Text = "";
            int n;
            Random rnd = new Random();
            if (Int32.TryParse(textBox1.Text, out n) && n>0)
            {
                double[] a = new double[n];
                for (int i = 0; i < n; ++i)
                {

                    a[i] = rnd.Next(-10, 10);
                }
                for (int i = 0; i < a.Length; ++i)
                {
                    if (a[i] >= 0)
                    {
                        otvet1.Text += $"a[{i}] =  {a[i]}\n";
                    }
                    else
                    {
                        otvet1.Text += $"a[{i}] = {a[i]}\n";
                    }
                }
                double max = Max(a);
                int m = 0;
                for (int i = 0; i < a.Length; ++i)
                    if (a[i] == max) m = i;
                otvet2.Text += $"Номер последнего \nмакс элемента: {m}";
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
