using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("함수결과"+f(int.Parse(textBox1.Text)));
        }
        private int f (int x)
        {
            return x * x + 2 * x + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //함수를 쓰지 않고 해보기
            label1.Text = int.Parse(textBox2.Text) * int.Parse(textBox2.Text) + "";

            //함수를 사용해서 해보기
            MessageBox.Show(power(textBox2.Text));
        }
        private string power(string inputNumber)
        {
            return "" + int.Parse(inputNumber) * int.Parse(inputNumber);
        }
        private string cm (string inputInch)
        {
            return "" + int.Parse(inputInch) * 2.54;
        }
        private string pound (string inputKg)
        {
            return "" + int.Parse(inputKg) * 2.20462262;
        }
        private string around(string inputr)
        {
            return "" + int.Parse(inputr) * 2 * 3.14;
        }
        private string area(string inputr)
        {
            return "" + int.Parse(inputr) * int.Parse(inputr) * 3.14;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = cm(textBox4.Text)+"cm";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = pound(textBox5.Text) + "pound";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "둘레 : " + around(textBox6.Text);
            label6.Text = "넓이 : " + area(textBox6.Text);

        }
    }
}
