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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("F");
            comboBox1.Items.Add("C");
            comboBox1.SelectedIndex = 0;
            label1.Text = "Convert";
            label2.Text = "From";
            label3.Text = "";
            
        }
        void calc()
        {
            double p, r;
            if (comboBox1.Text == "F")
            {
                p = double.Parse(textBox1.Text);
                r = (p - 32) * 5 / 9;
                textBox2.Text = r.ToString();
                label3.Text = textBox1.Text + " from " + comboBox1.Text + " to C = ";
            }
            if (comboBox1.Text == "C")
            {
                p = double.Parse(textBox1.Text);
                r = p * 9 / 5 + 32;
                textBox2.Text = r.ToString();
                label3.Text = textBox1.Text + " from " + comboBox1.Text + " to F = ";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                calc();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                calc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
}
