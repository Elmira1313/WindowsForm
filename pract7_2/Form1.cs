using System;
using System.Text;
using System.Windows.Forms;

namespace pract7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            char x;
            StringBuilder a = new StringBuilder();
            if (Char.TryParse(textBox1.Text, out x))
            {
                a.Append(richTextBox1.Text);
                try
                {
                    bool flag = true;
                    for (int i = 0; i < a.Length; ++i)
                    {
                        if (a[i] == x)
                        {
                            a.Insert(i + 1, x);
                            ++i;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    if (flag == true)
                    {
                        richTextBox2.Text = $"{a}";
                    }
                    else
                    {
                        richTextBox2.Text = "";
                        MessageBox.Show("Такого символа нет!");
                    }
                }
                catch (Exception)
                {
                    richTextBox2.Text = "";
                    MessageBox.Show("Что-то введено не так!");
                }
            }
            else
            {
                richTextBox2.Text = "";
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
