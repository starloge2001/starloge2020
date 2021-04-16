using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex210412_2
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        string[] a = { "가위", "바위", "보" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "가위";
            label5.Text = a[r.Next(0, 3)];
            if (label5.Text == "가위")
            {
                label7.Text = "비김";
            }
            if (label5.Text == "바위")
            {
                label7.Text = "짐";
            }
            if (label5.Text == "보")
            {
                label7.Text = "이김";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "바위";
            label5.Text = a[r.Next(0, 3)];
            if (label5.Text == "가위")
            {
                label7.Text = "이김";
            }
            if (label5.Text == "바위")
            {
                label7.Text = "비김";
            }
            if (label5.Text == "보")
            {
                label7.Text = "짐";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "보";
            label5.Text = a[r.Next(0, 3)];
            if (label5.Text == "가위")
            {
                label7.Text = "짐";
            }
            if (label5.Text == "바위")
            {
                label7.Text = "이김";
            }
            if (label5.Text == "보")
            {
                label7.Text = "비김";
            }
        }
    }
}
