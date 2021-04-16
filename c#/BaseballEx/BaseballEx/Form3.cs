using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballEx
{
    public partial class Form3 : Form
    {
        Form1 parent = null;
        Timer parentTimer = null;
        public Form3(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.parentTimer = parent.timer;
            
        }
        //StreamWriter w = new StreamWriter(@"D:\blacksheep\starloge2020\c#\BaseballEx\a.b");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parentTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        //     for (int i = 0; i<form1.; i++)
        //{

        //}
    }
}
