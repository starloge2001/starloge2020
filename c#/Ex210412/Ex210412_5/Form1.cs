using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex210412_5
{
    public partial class Form1 : Form
    {
        //List<Button> list = new List<Button>();
        Button temp = null;

        public Form1()
        {
            InitializeComponent();
            /*list.Add(button2);
            list.Add(button3);
            list.Add(button4);
            list.Add(button5);
            list.Add(button6);
            list.Add(button7);*/
            
        }

      

        private void myButtonClick(object sender, EventArgs e)
        {
            /*            for (int i = 0; i < list.Count; i++)
                        {
                            list[i].Enabled = true;
                        }*/




            if (temp != null)
            {
                temp.Enabled = true;
                ((Button)sender).Enabled = false;
                temp = (Button)sender;
            }
            else
            {

                ((Button)sender).Enabled = false;
                temp = (Button)sender;
            }
        }
    }
}
