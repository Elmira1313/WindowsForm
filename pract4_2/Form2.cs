using System;
using System.Text;
using System.Windows.Forms;

namespace pract4_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void stroka(int n)
        {
            StringBuilder str = new StringBuilder();
            for (int i = n; i > 0; i--)
            {
                str.Append(i + " ");
            }
            otvet.Text += $"{str}\n";
        }
        void f2(int n)
        {
            StringBuilder str = new StringBuilder();
            if (n > 0)
            {
                f2(n - 1);
                stroka(n);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            otvet.Text = "";
            if (Int32.TryParse(textBox1.Text, out n) && n >0 )
            {
                try
                {
                    f2(n);
                }
                catch (Exception)
                {
                    otvet.Text = "?";
                    MessageBox.Show("Что-то введено не так!");
                }
            }
            else
            {
                otvet.Text = "?";
                MessageBox.Show("Что-то введено не так!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
