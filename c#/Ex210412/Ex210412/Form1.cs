using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex210412
{
    public partial class Ex1 : Form
    {
        Random r = new Random();
        int quiz;
        public Ex1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            quiz = r.Next(1, 100);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (quiz > int.Parse(textBox1.Text))
            {
                MessageBox.Show("입력한 숫자보다 큽니다.");
            }
            if (quiz < int.Parse(textBox1.Text))
            {
                MessageBox.Show("입력한 숫자보다 작습니다..");
            }
            if (quiz == int.Parse(textBox1.Text))
            {
                MessageBox.Show("정답입니다.");
                quiz = r.Next(1, 100);
            }
        }

    }
}
