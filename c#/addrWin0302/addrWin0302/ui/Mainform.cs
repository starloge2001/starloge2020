using addrWin0302.ui;
using adressTest0218.control;
using adressTest0218.util;
using adressTest0218.view;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addrWin0302
{
    public partial class Mainform : MaterialForm
    {
        MyMenu mymenu = new MyMenu();
        StudentCtrl sc = new StudentCtrl();
        public Mainform()
        {
            InitializeComponent();
            
        }

        private void addrOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update 2021년 3월 2일 by starloge");
        }
        
        private void addrAdd_Click(object sender, EventArgs e)
        {
            new Addform(sc).ShowDialog();
        }

        private void addrDel_Click(object sender, EventArgs e)
        {
            sc.delItem(Console.ReadLine());
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            new Viewform(sc).ShowDialog();
            //sc.viewItem();
        }

        private void addrAllDel_Click(object sender, EventArgs e)
        {
            sc.delItemAll();
        }

        private void addrAddRand_Click(object sender, EventArgs e)
        {
            string cnt = myinputBox("랜덤 데이터 생성", "랜덤하게 데이터를 생성할 갯수를 입력하세요", "0");
            if (cnt == "")
            {
                return;
            }
            sc.randData(Convert.ToInt32(cnt));
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            sc.updateItem();
        }
        private string myinputBox(string title, string body, string prompt)
        {
            Point parentPoint = this.Location;
            string input = Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, parentPoint.X, parentPoint.Y);
            return input;
        }
    }
}
