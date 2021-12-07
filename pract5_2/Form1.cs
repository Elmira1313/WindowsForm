using System;
using System.Windows.Forms;

namespace pract5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            try
            {
                if (Math.Round(x, 2) <= 0.5) throw new Exception();
                else return Math.Round(x / Math.Sqrt(2 * x - 1), 2);
            }
            catch
            {
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            otvet.Text = "";
            double a, b, h;
            if (Double.TryParse(textBox1.Text, out a) && Double.TryParse(textBox2.Text, out b) && Double.TryParse(textBox3.Text, out h))
            {
                
                    
                    for (double i = a; i <= b; i += h)
                        try
                        {
                            otvet.Text += $"y({Math.Round(i, 2)}) = {Math.Round(f(i), 2)}\n";
                        }
                        catch
                        {
                            otvet.Text += $"y({Math.Round(i, 2)})  не определена\n";
                        }
                
            }
            else
            {
                otvet.Text = "Oшибка";
            }
            
        }
    }
}
