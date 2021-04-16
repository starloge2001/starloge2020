using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex210412_3
{
    public partial class Form1 : Form
    {
        List<Word> rlist = new List<Word>();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rlist.Add(new Word() { word = "힘내라" });
            rlist.Add(new Word() { word = "대한민국" });
            rlist.Add(new Word() { word = "이기자" });
            rlist.Add(new Word() { word = "동준샘" });
            rlist.Add(new Word() { word = "단어만들기가" });
            rlist.Add(new Word() { word = "힘듭니다" });
            rlist.Add(new Word() { word = "예시좀" });
            rlist.Add(new Word() { word = "제시해" });
            rlist.Add(new Word() { word = "주세요" });
            rlist.Add(new Word() { word = "^^" });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = rlist[r.Next(0, 10)].word;
        }

       
    }
}
