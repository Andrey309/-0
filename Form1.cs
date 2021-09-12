using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, R, Vball, Vcube, Percent;
                a = Convert.ToDouble(textBox2.Text);
                R = Convert.ToDouble(textBox5.Text);
                if (a >= 0 && R >= 0)
                {
                    Vcube = Math.Pow(a, 3);
                    textBox4.Text = "Объем куба = " + Convert.ToString(Vcube);
                    {
                        if (R <= a / 2)
                        {
                            Vball = 4 / 3 * Math.PI * Math.Pow(R, 3);
                            textBox1.Text = "Объём шара = " + Convert.ToString(Vball);
                            Percent = (Vcube - Vball) / 100;
                            textBox3.Text = "Процент отходов = " + Convert.ToString(Percent);
                        }
                        else
                        {
                            Console.WriteLine("Введены некорректные значения переменной R ");
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
