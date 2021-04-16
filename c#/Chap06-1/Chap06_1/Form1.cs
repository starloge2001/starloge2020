using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap06_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //함수를 쓰지 않고 해보기
            label1.Text = int.Parse(textBox2.Text) * int.Parse(textBox2.Text)+"";

            //합수를 사용해서 해보기
            
        }
    }
}
