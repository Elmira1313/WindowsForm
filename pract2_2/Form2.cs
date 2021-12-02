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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = "II. С 1 января 1990 года по некоторый день прошло \nm месяцев, определить название текущего месяца.\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m;
            if (int.TryParse(textBox1.Text, out m))
            {
                while (m > 12)
                {
                    m = m - 12;
                }
                switch (m)
                {
                    case 1: otvet.Text = "~Январь~"; break;
                    case 2: otvet.Text = "~Февраль~"; break;
                    case 3: otvet.Text = "~Март~"; break;
                    case 4: otvet.Text = "~Апрель~"; break;
                    case 5: otvet.Text = "~Май~"; break;
                    case 6: otvet.Text = "~Июнь~"; break;
                    case 7: otvet.Text = "~Июль~"; break;
                    case 8: otvet.Text = "~Август~"; break;
                    case 9: otvet.Text = "~Сентябрь~"; break;
                    case 10: otvet.Text = "~Октябрь~"; break;
                    case 11: otvet.Text = "~Ноябрь~"; break;
                    case 12: otvet.Text = "~Декабрь~"; break;
                    default: Console.WriteLine("ВЫ ОШИБЛИСЬ"); break;
                }
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
