using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballEx
{
    public partial class Form1 : Form
    {
        Rank rank;
        Random r = new Random();
        int[] baseball = new int[3];
        List<string> mylist = new List<string>();
        public List<Rank> rankList = new List<Rank>();
        List<Rank> dummy = new List<Rank>();
        
        string temp;
        int count = 0;
        int scount = 0;
        int bcount = 0;

        public Timer timer = null;
        public Form1()
        {
            InitializeComponent();
            FileInfo fi = new FileInfo("a.dat");
            //FileInfo.Exists로 파일 존재유무 확인 "
            if (fi.Exists) 
            {
                Stream rs = new FileStream("a.dat", FileMode.Open);
                BinaryFormatter deserializer = new BinaryFormatter();
                rankList = (List<Rank>)deserializer.Deserialize(rs);
                rs.Close();
            }
            
            timer = new Timer() { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Start();
            for (int i = 0; i < 3; i++)
            {
                baseball[i] = r.Next(1, 9);
                for (int j = 0; j < i; j++)
                {
                    if (baseball[i] == baseball[j])
                    {
                        i--;
                    }
                }
            }

            dummy.Clear();
            dummy.Add(new Rank(0,0,"a"));


        }


        int totalTime = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            label2.Text = ++totalTime + "초";
        }

        private void mybutton_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;

        }

        //Form4 form4 = null;
        private void button10_Click(object sender, EventArgs e)
        {
            
            
            scount = 0;
            bcount = 0;
            if (textBox1.Text.Length != 3)
            {
                MessageBox.Show("잘못 입력하셧습니다.");
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                if (baseball[i] == Convert.ToInt32(textBox1.Text[i].ToString()))
                {
                    scount++;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        if (baseball[i] == int.Parse(textBox1.Text[j].ToString()))
                        {
                            bcount++;
                        }
                    }
                }
            }
            count++;
            
            mylist.Add(textBox1.Text+"  "+ scount + "S " + bcount + "B  "+ count +"번 시도함");
            textBox1.Text = "";
            listBox1.Items.Add(mylist[0]);
            mylist.Clear();
            if (scount == 3)
            {
                MessageBox.Show("정답입니다.");


                listBox1.Items.Clear();
                for (int i = 0; i < 3; i++)
                {
                    baseball[i] = r.Next(1, 9);
                    for (int j = 0; j < i; j++)
                    {
                        if (baseball[i] == baseball[j])
                        {
                            i--;
                        }
                    }
                }
               
                timer.Stop();
                rank = new Rank(count, totalTime, DateTime.Now.ToString("yyyy" + "년" + "MM" + "월" + "dd" + "일" + " " + "HH" + "시" + "mm" + "분" + "ss" + "초") + "    기록 :" + totalTime + "초" + "   시도횟수 : " + count);
                rankList.Add(rank);
                if (rankList.Count > 1)
                {
                   
                    for (int i = 0; i < rankList.Count() - 1; i++)
                    {
                        for (int j = i; j < rankList.Count() - 1; j++)
                        {
                            if (rankList[i].TotalTime > rankList[j+1].TotalTime)
                            {
                                dummy[0] = rankList[i];
                                rankList[i] = rankList[j + 1];
                                rankList[j + 1] = dummy[0];
                                
                            }
                        }
                    }
                    for (int i = 0; i < rankList.Count() - 1; i++)
                    {
                        for (int j = i; j < rankList.Count() - 1; j++)
                        {
                            if (rankList[i].Count1 > rankList[j + 1].Count1)
                            {
                                dummy[0] = rankList[i];
                                rankList[i] = rankList[j + 1];
                                rankList[j + 1] = dummy[0];

                            }
                        }
                    }
                    if (rankList.Count == 11)
                        rankList.RemoveAt(11);
                }
               
                Stream ws = new FileStream("a.dat", FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(ws, rankList);
                ws.Close();

                new Form4(this).ShowDialog();
                totalTime = 0;
                count = 0;

            }
            if(count==10)
            {
                timer.Stop();
                //MessageBox.Show("기회를 모두 소진하셧습니다. 게임을 다시 시작합니다.");
                count = 0;

                listBox1.Items.Clear();
                for (int i = 0; i < 3; i++)
                {
                    baseball[i] = r.Next(1, 9);
                    for (int j = 0; j < i; j++)
                    {
                        if (baseball[i] == baseball[j])
                        {
                            i--;
                        }
                    }
                }
                
                new Form3(this).ShowDialog();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {                
                e.Handled = true;
            }
            if (e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button10_Click(null, null);
            }

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {
                textBox1.Text = temp;
                MessageBox.Show("3자리만 입력하세요");
            }
            if (textBox1.Text.Length > 1)
            {
                for (int i = 0; i < textBox1.Text.Length-1; i++)
                {
                    for (int j = i+1; j < textBox1.Text.Length; j++)
                    {
                        if (textBox1.Text[i] == textBox1.Text[j])
                        {
                            textBox1.Text = temp;
                            MessageBox.Show("같은 숫자를 입력할수 없습니다.");
                            return;
                        }
                    }
                }
            }
            if (textBox1.Text.Length <= 3)
            {
                temp = textBox1.Text;
            }
          
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length!=0)
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
