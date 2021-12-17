using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace pract10_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string path = @"C:\Temp";
        string s1, s2;
        StringBuilder s3 = new StringBuilder();

        string spath1 = @"\К1";
        string spath2 = @"\К2";
        string spathall = @"\ALL";
        DirectoryInfo dirInfo;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text = "";

                dirInfo = Directory.CreateDirectory(path + spath1);
                FileInfo[] files1 = dirInfo.GetFiles();
                for (int i = 0; i < files1.Length; i++)
                {
                    richTextBox3.Text += $"Имя: {files1[i].Name} \nПуть: {files1[i].FullName} \nРазмер: {files1[i].Length}\n\n";
                }
                dirInfo = Directory.CreateDirectory(path + spath2);
                FileInfo[] files2 = dirInfo.GetFiles();
                for (int i = 0; i < files2.Length; i++)
                {
                    richTextBox3.Text += $"Имя: {files2[i].Name} \nПуть: {files2[i].FullName} \nРазмер: {files2[i].Length}\n\n";
                }

            }
            catch
            {
                richTextBox3.Text = "";
                MessageBox.Show("Что-то не так!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text += "\n\n";
                File.Move(path + spath1 + $"\\t2.txt", path + spath2 + $"\\t2.txt");

                richTextBox3.Text += "Файл  t2.txt перемещен в папку K2.";
            }
            catch
            {
                richTextBox3.Text = "";
                MessageBox.Show("Что-то не так!");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text += "\n\n";
                File.Copy(path + spath1 + $"\\t1.txt", path + spath2 + $"\\t1.txt");

                richTextBox3.Text += "Файл  t1.txt скопирован в папку K2.";
            }
            catch
            {
                richTextBox3.Text = "";
                MessageBox.Show("Что-то не так!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text += "\n\n";
                Directory.Move(path + spath2, path + spathall);
                Directory.Delete(path + spath1, true);

                richTextBox3.Text += "Папка К2 переименовывается в ALL\nПапка К1 удаляется\n";

                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            catch
            {
                richTextBox3.Text = "";
                MessageBox.Show("Что-то не так!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text += "\n\n";

                dirInfo = Directory.CreateDirectory(path + spathall);
                FileInfo[] filesALL = dirInfo.GetFiles();
                for (int i = 0; i < filesALL.Length; i++)
                {
                    richTextBox3.Text += $"Имя: {filesALL[i].Name} \nПуть: {filesALL[i].FullName} \nРазмер: {filesALL[i].Length}\n\n";
                }

            }
            catch
            {
                richTextBox3.Text = "";
                MessageBox.Show("Что-то не так!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Text += "\n\n";
                foreach (string folder in Directory.GetDirectories(path))
                {
                    Directory.Delete(folder, true);
                }
                richTextBox3.Text += "В папке С:\\Temp все удалено!";
            }
            catch
            {
                richTextBox3.Text = "";
                MessageBox.Show("Что-то не так!");
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
