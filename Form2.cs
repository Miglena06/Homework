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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        calculator calc = new calculator();

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeFormText(sender, e);
            //double val1, val2; //Декларираме 2 променливи от тип double type
            //try
            //{   //Ще присвоим на първата променлива стойността в първото текстово поле
            //    //Тъй като това е string, трябва да конвертираме към double
            //    val1 = Double.Parse(textBox1.Text);
            //    val2 = Double.Parse(textBox2.Text);
            //    //Обратно конвертираме
            //    //от double към string, използвайки .ToString() 
            //    ChangeFormText( sender, e);
            //    if (P == "+") textBox3.Text = AddNumbers(val1, val2).ToString();
            //    if (P == "-") textBox3.Text = AddNumbers(val1, val2).ToString();
            //    if (P == "*") textBox3.Text = AddNumbers(val1, val2).ToString();
            //    if (P == "/") textBox3.Text = AddNumbers(val1, val2).ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
            //    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            //}

                
                
        }
        public double AddNumbers(double val1, double val2)
        { return val1 + val2; }
        public double AddNumbers1(double val1, double val2)
        { return val1 - val2; }
        public double AddNumbers2(double val1, double val2)
        { return val1 * val2; }
        public double AddNumbers3(double val1, double val2)
        { return val1 / val2; }
        string P = "";
        private void ChangeFormText(object sender, EventArgs e)
        {
           
            if (sender is Button)
            {
                P = (sender as Button).Text;               
            }

            double val1, val2; //Декларираме 2 променливи от тип double type
            try
            {   //Ще присвоим на първата променлива стойността в първото текстово поле
                //Тъй като това е string, трябва да конвертираме към double
                val1 = Double.Parse(textBox1.Text);
                val2 = Double.Parse(textBox2.Text);
                //Обратно конвертираме
                //от double към string, използвайки .ToString() 
              //  ChangeFormText(sender, e);
                if (P == "+") textBox3.Text = AddNumbers(val1, val2).ToString();
                if (P == "-") textBox3.Text = AddNumbers1(val1, val2).ToString();
                if (P == "*") textBox3.Text = AddNumbers2(val1, val2).ToString();
                if (P == "/") textBox3.Text = AddNumbers3(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //double val1, val2; //Декларираме 2 променливи от тип double type
            //try
            //{   //Ще присвоим на първата променлива стойността в първото текстово поле
            //    //Тъй като това е string, трябва да конвертираме към double
            //    val1 = Double.Parse(textBox1.Text);
            //    val2 = Double.Parse(textBox2.Text);
            //    //Обратно конвертираме
            //    //от double към string, използвайки .ToString()
            //    if (val2 == 0)
            //    {
            //        MessageBox.Show("Не се дели на 0");
            //        textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            //    }
            //    else
            //        textBox3.Text = calculator.AddNumbers3(val1, val2).ToString();

            //}
            //catch
            //{
            //    MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
            //    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            //}
            ChangeFormText(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //double val1, val2; //Декларираме 2 променливи от тип double type
            //try
            //{   //Ще присвоим на първата променлива стойността в първото текстово поле
            //    //Тъй като това е string, трябва да конвертираме към double
            //    val1 = Double.Parse(textBox1.Text);
            //    val2 = Double.Parse(textBox2.Text);
            //    //Обратно конвертираме
            //    //от double към string, използвайки .ToString() 
            //    textBox3.Text = calculator.AddNumbers1(val1, val2).ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
            //    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            //}
            ChangeFormText(sender, e);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //double val1, val2; //Декларираме 2 променливи от тип double type
            //try
            //{   //Ще присвоим на първата променлива стойността в първото текстово поле
            //    //Тъй като това е string, трябва да конвертираме към double
            //    val1 = Double.Parse(textBox1.Text);
            //    val2 = Double.Parse(textBox2.Text);
            //    //Обратно конвертираме
            //    //от double към string, използвайки .ToString() 
            //    textBox3.Text = calculator.AddNumbers2(val1, val2).ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
            //    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            //}
            ChangeFormText(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }
    }
}
       