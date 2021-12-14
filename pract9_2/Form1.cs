using System;
using System.IO;
using System.Windows.Forms;

namespace pract9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int n, c, a;
            try
            {
                if(Int32.TryParse(textBox1.Text, out n) && Int32.TryParse(textBox2.Text, out c))
                {
                    FileStream f = new FileStream("F1.bin", FileMode.Open);
                    BinaryWriter fOut = new BinaryWriter(f);
                    Random rnd = new Random();
                    for (int i = 1; i <= n; i++)
                    {
                        a = rnd.Next(-100, 100);
                        if (a % c != 0)
                        {
                            fOut.Write(a);
                        }
                    }
                    fOut.Close();
                    f = new FileStream("F1.bin", FileMode.Open);
                    BinaryReader fIn = new BinaryReader(f);
                    long m = f.Length;
                    Console.WriteLine();
                    for (long i = 0; i < m; i += 4)
                    {
                        f.Seek(i, SeekOrigin.Begin);
                        a = fIn.ReadInt32();
                        richTextBox1.Text += $"{a}\n";
                    }
                    Console.WriteLine();
                    fIn.Close();
                    f.Close();
                }
                else
                {
                    richTextBox1.Text = "";
                    MessageBox.Show("Что-то введено не так!");
                }
            }
            catch (Exception)
            {
                richTextBox1.Text = "";
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
