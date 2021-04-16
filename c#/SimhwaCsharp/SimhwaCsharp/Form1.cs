using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimhwaCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("안녕 ");
            MessageBox.Show("Test");
            Console.WriteLine("하세요");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("안녕 ");
            Form2 f = new Form2();
            f.Show();//Modeless 모달리스
            Console.WriteLine("하세요");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();//Model  모달
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Eat();
            c.Sleep();

            Dog d = new Dog();
            d.Eat();
            d.Sleep();

            Animal a = new Dog();
            Animal b = new Cat();
            a.Eat();
            b.Eat();
        }
    }
}
