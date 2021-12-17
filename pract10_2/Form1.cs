using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace pract10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = @"C:\Temp";
        string s1, s2;
        StringBuilder s3 = new StringBuilder();

        string spath1 = @"\К1";
        string spath2 = @"\К2";
        DirectoryInfo dirInfo;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text = "";
                dirInfo = Directory.CreateDirectory(path + spath1);
                dirInfo = Directory.CreateDirectory(path + spath2);

                richTextBox3.Text = "В папке С:\\Тemp создаются папки К1 и К2.";

                button3.Enabled = false;
            }
            catch
            {
                richTextBox3.Text = "";
                MessageBox.Show("Что-то не так!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && richTextBox2.Text != "")
            {
                try
                {
                    richTextBox3.Text += "\n\n";
                    s1 = richTextBox1.Text;
                    s2 = richTextBox2.Text;
                    File.WriteAllText(path + spath1 + $"\\t1.txt", s1);
                    File.WriteAllText(path + spath1 + $"\\t2.txt", s2);

                    richTextBox3.Text += "В папке К1 создаются 2 файла: t1.txt и t2.txt";
                }
                catch
                {
                    richTextBox3.Text = "";
                    MessageBox.Show("Что-то не так!");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text += "\n\n";

                string[] bufs1 = File.ReadAllLines(path + spath1 + $"\\t1.txt");
                string[] bufs2 = File.ReadAllLines(path + spath1 + $"\\t2.txt");
                for (int i = 0; i < bufs1.Length; i++)
                {
                    s3.Append(bufs1[i]);
                }
                s3.Append("\n");
                for (int i = 0; i < bufs2.Length; i++)
                {
                    s3.Append(bufs2[i]);
                }
                File.WriteAllText(path + spath2 + $"\\t3.txt", $"{s3}");

                richTextBox3.Text += "В папке К2 создается файл t3.txt:";
            }
            catch
            {
                richTextBox3.Text = "";
                MessageBox.Show("Что-то не так!");
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
