using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap06_2
{
    public partial class Form1 : Form
    {
        Accouent a1;
        Accouent a2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int money);
            string name = textBox2.Text;

            a1 = new Accouent(money, name);

            string message = a1.name + "님, 잔액은 " + a1.myMoney + "입니다.";

            Label msg = new Label();
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(200, 200);
            Controls.Add(msg);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int money);
            string name = textBox4.Text;

            a2 = new Accouent(money, name);

            string message = a2.name + "님, 잔액은 " + a2.myMoney + "입니다.";

            Label msg = new Label();
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(500, 200);
            Controls.Add(msg);

            MessageBox.Show(a1.name + a1.myMoney);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            outExample(out int abc, out int def, out int hij);
            MessageBox.Show(abc+def+hij+"");
            foreach (var item in Controls)
            {
                /*if ((item as TextBox) != null)
                    (item as TextBox).Text = "";*/
                var temp = item as TextBox;
                if (temp != null)
                    temp.Text = "하이하이하이";
            }
        }
        private void outExample(out int a, out int b, out int c)
        {
            a = 100;
            b = 200;
            c = 300;
        }
    }
}
