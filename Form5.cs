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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double[,] K = new double[4, 4];

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("feet");
            comboBox1.Items.Add("yards");
            comboBox1.Items.Add("inches");
            comboBox1.Items.Add("miles"); 
            comboBox2.Items.Add("feet");
            comboBox2.Items.Add("yard");
            comboBox2.Items.Add("inches");
            comboBox2.Items.Add("miles");


            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            textBox2.Text= "";
            textBox2.Text = 0.ToString();
            K[0, 0] = 1;
            K[0, 1] = 0.3333;
            K[0, 2] = 1.1989;
            K[0, 3] = 0.0001893;
            K[1, 0] = 3;
            K[1, 1] = 1;
            K[1, 2] = 3.5966;
            K[1, 3] = 0.0005682;
            K[2, 0] = 0.8341;
            K[2, 1] = 0.278;
            K[2, 2] = 1;
            K[2, 3] = 0.0001579;
            K[3, 0] = 5280;
            K[3, 1] = 1760;
            K[3, 2] = 6330;
            K[3, 3] = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text=((double.Parse(textBox1.Text)*K[comboBox1.SelectedIndex,comboBox2.SelectedIndex])).ToString();
           switch(comboBox2.SelectedIndex)
            {
                case 0:
                label4.Text="feet";
                break;
                case 1:
                label4.Text = "yards";
                break;
                case 2:
                label4.Text = "inches";
                break;
                case 3:
                label4.Text = "miles";
                break;
                default:
                label4.Text = "Result";
                break;
            }
        }


       
    }
}
