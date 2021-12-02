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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "I. Дана точка на плоскости с координатами (х, у). \nСоставить программу, которая выдает одно из сооб-\nщений «Да», «Нет», «На границе» в зависимости от \nтого, лежит ли точка внутри заштрихованной области, \nвне заштрихованной области или на ее границе.\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y;
            if (Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out y))
            {
                if (x * x + y * y < 625 && y < 0 && y < -1 * (Math.Abs(x)))
                    otvet.Text = "внутри";
                else if (x * x + y * y == 625 || y == 0 || y == -1 * (Math.Abs(x)))
                    otvet.Text ="на границе";
                else otvet.Text = "вне области";
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
