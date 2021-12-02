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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = 5;
            otvet.Text = "";
            for (int i = 6; i <= 10; ++i, otvet.Text += "\n")
            {
                for (int j = 0; j < k; j++)
                {
                    otvet.Text += $"   {i}";
                }
                k--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
