using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x1, x2;
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    MessageBox.Show("n.r.k");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    label6.ResetText();
                    label7.ResetText();
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    label6.Text = x1.ToString();
                    label7.Text = x2.ToString();
                }
            }
            catch
            {
                MessageBox.Show("vkd");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                label6.ResetText();
                label7.ResetText();
            }



        }
        void calc()
        {
            double a, b, c, d, x1, x2;
            
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    MessageBox.Show("n.r.k");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    label6.ResetText();
                    label7.ResetText();
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    label6.Text = x1.ToString();
                    label7.Text = x2.ToString();
                }
            }
            catch
            {
                //MessageBox.Show("vkd");
                //textBox1.Clear();
                //textBox2.Clear();
                //textBox3.Clear();
                //label6.ResetText();
                //label7.ResetText();
            
        }
    }
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "a=";
            label2.Text = "b=";
            label3.Text = "c=";
            label4.Text = "x1=";
            label5.Text = "x2=";
            label6.Text = "";
            label7.Text = "";
            button1.Text = "Calculate";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                calc();
            }
        
    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                calc();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                calc();
        }
    }
}
