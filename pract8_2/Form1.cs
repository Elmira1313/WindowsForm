using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            try
            {
                StringBuilder a = new StringBuilder();
                a.Append(richTextBox1.Text);
                StringBuilder b = new StringBuilder();
                b.Append(a);
                Regex reg = new Regex(@"(\b[ауоеёиыэюя]|\b[АУОЕЁИЫЭЮЯ])(([а-я])*|([А-Я])*)");
                bool flag = false;

                for (int i = 0; i < a.Length; i++)
                    if (char.IsPunctuation(a[i]))
                    {
                        a.Replace($"{a[i]}", $" {a[i]}");
                        i++;
                    }

                for (int i = 0; i < b.Length;)
                    if (char.IsPunctuation(b[i]))
                    {
                        b.Remove(i, 1);
                    }
                    else ++i;

                string str = b.ToString();
                string[] s = str.Split(' ');

                for (int i = 0; i < s.Length; i++)
                {
                    if (reg.IsMatch(s[i]) == true)
                    {
                        flag = true;
                        if (i == 0)
                        {
                            a.Replace($"{s[i]}", "");
                        }
                        else
                        {
                            a.Replace($"{s[i]} ", "");
                        }

                    }
                }
                if (flag == true)
                {
                    for (int i = 0; i < a.Length; i++)
                        if (char.IsPunctuation(a[i]))
                        {
                            a.Remove(i - 1, 1);
                        }
                    richTextBox2.Text = $"{a}";
                }
                else
                {
                    richTextBox2.Text = "";
                    MessageBox.Show("Таких слов нет!");
                }
            }
            catch (Exception)
            {
                richTextBox2.Text = "";
                MessageBox.Show("Что-то введено не так!");
            }
        }
    }
}
