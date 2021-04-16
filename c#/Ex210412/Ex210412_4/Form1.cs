using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex210412_4
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = r.Next(1, 50).ToString();
            button2.Text = r.Next(1, 50).ToString();
            button3.Text = r.Next(1, 50).ToString();
            button4.Text = r.Next(1, 50).ToString();
            button5.Text = button1.Text;
            button6.Text = button2.Text;
            button7.Text = button3.Text;
            button8.Text = button4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            list.Add(button1.Text);
            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += list[i]+" ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            list.Add(button2.Text);
            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += list[i] + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            list.Add(button3.Text);
            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += list[i] + " ";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            list.Add(button4.Text);
            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += list[i] + " ";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            list.Remove(button5.Text);
            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += list[i] + " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            list.Remove(button6.Text);
            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += list[i] + " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            list.Remove(button7.Text);
            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += list[i] + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            list.Remove(button8.Text);
            for (int i = 0; i < list.Count; i++)
            {
                label2.Text += list[i] + " ";
            }
        }
    }
}
