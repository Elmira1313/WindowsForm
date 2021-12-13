using System;
using System.Text;
using System.Windows.Forms;

namespace pract7_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            try
            {
                StringBuilder b = new StringBuilder();
                b.Append(richTextBox1.Text);
                StringBuilder a = new StringBuilder();
                a.Append(b);
                bool flag = true;

                for (int i = 0; i < b.Length; i++)
                    if (char.IsPunctuation(b[i]))
                    {
                        b.Replace($"{b[i]}", $" {b[i]}");
                        i++;
                    }

                for (int i = 0; i < a.Length;)
                    if (char.IsPunctuation(a[i]))
                    {
                        a.Remove(i, 1);
                    }
                    else ++i;
                string str = a.ToString();
                string[] s = str.Split(' ');
                string bstr = str.ToLower();
                string[] bs = bstr.Split(' ');
                int k = 0, l = 0;

                for (int i = 0; i < bs.Length; i++)
                {
                    for (int j = 0; j < bs.Length; j++)
                    {
                        if (bs[i] == bs[j])
                        {
                            k++;
                        }
                    }
                    if (k > 1)
                    {
                        if (i == 0)
                        {
                            b.Replace($"{s[i]}", "");
                        }
                        else
                        {
                            b.Replace($"{s[i]} ", "");
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                    k = 0;
                }
                if (flag == true)
                {
                    for (int i = 0; i < b.Length; i++)
                        if (char.IsPunctuation(b[i]))
                        {
                            b.Remove(i - 1, 1);
                        }
                    richTextBox2.Text = $"{b}";
                }
                else
                {
                    richTextBox2.Text = "";
                    MessageBox.Show("Повторяющихся слов нет!");
                }
            }
            catch (Exception)
            {
                richTextBox2.Text = "";
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
