using System;
using System.IO;
using System.Windows.Forms;

namespace pract9_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            try
            {
                string z2path = Environment.CurrentDirectory + @"\F2.txt";
                string[] allstr = File.ReadAllLines(z2path);
                for (int i = 0; i < allstr.Length; i++)
                {
                    char[] chText = allstr[i].ToCharArray();
                    richTextBox1.Text += $"{i + 1}: {chText[0]}\n";
                }
            }
            catch (Exception)
            {
                richTextBox1.Text = "";
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
