using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract2_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label2.Text = "III. Вывести на экран таблицу перевода расстояний в \nдюймах в сантиметры для значений 2, 4, 6,.., 12 дюймов (1 дюйм = 25.4 мм).\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n = 2;
            otvet1.Text = "while\n\n";
            while (n <= 12)
            {
                otvet1.Text += $"\t{n} дюйм\t   {Math.Round((n * 25.4), 2)} mm\n";
                n += 2;
            }
            n = 2;
            otvet2.Text = "do...while\n\n";
            do
            {
                otvet2.Text += $"\t{n} дюйм\t   {Math.Round((n * 25.4), 2)} mm\n";
                n += 2;
            } while (n <= 12);
            otvet3.Text = "for\n\n";
            for (n = 2; n <= 12; n += 2)
            {
                otvet3.Text += $"\t{n} дюйм\t   {Math.Round((n * 25.4), 2)} mm\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
