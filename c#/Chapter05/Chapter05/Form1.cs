using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_test.Text = "로또 번호 추첨";
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로또 번호 추첨");

            Random r = new Random();
            //0이상 10미만의 숫자 하나 출력 Next(10)
            //1이상 46미만의 숫자 하나 출력 Next(1,46)
            //MessageBox.Show(r.Next(1, 46).ToString());
            //MessageBox.Show의 괄호 안에는 string 타입만 들어감.
            int[] rotto = new int[6];
            int[] count = new int[45];
            //Label[] labelList = { label_num1 , label_num2 , label_num3, label_num4, label_num5, label_num6};
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    rotto[j] = r.Next(1,46);
                    for (int k = 0; k < j; k++)
                    {
                        if (rotto[j] == rotto[k])
                        {
                            i--;
                            break;
                        }
                    }
                    count[rotto[j]-1] += 1;
                    //labelList[i].Text = rotto[i].ToString();
                }
            }
            int[] max =new int[6];
            int[] max1 = new int[6];
            for (int i = 0; i < 6; i++)
            {
                max[i] = 0;
                for (int j = 0; j < 45; j++)
                {
                    if (i > 0)
                    {
                        if (max1[i - 1] == count[j])
                        {
                            count[j] = 0;
                        }                      
                    }
                    
                    if (max1[i] < count[j])
                    {
                        max1[i] = count[j];
                        max[i] = j + 1;
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (max[i] < max[j])
                    {
                        int dummy = max[i];
                        max[i] = max[j];
                        max[j] = dummy;
                    }
                }
            }
            /* for (int i = 0; i < 6; i++)
             {
                 labelList[i].Text = count[i].ToString();
             }*/

            label_num1.Text = max[0].ToString();
            label_num2.Text = max[1].ToString();
            label_num3.Text = max[2].ToString();
            label_num4.Text = max[3].ToString();
            label_num5.Text = max[4].ToString();
            label_num6.Text = max[5].ToString();
          /*  label1.Text= max1[0].ToString();
            label2.Text= max1[1].ToString();
            label3.Text= max1[2].ToString();
            label4.Text= max1[3].ToString();
            label5.Text= max1[4].ToString();
            label6.Text= max1[5].ToString();*/
        }
    }
}