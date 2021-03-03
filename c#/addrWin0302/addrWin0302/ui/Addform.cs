using adressTest0218;
using adressTest0218.control;
using adressTest0218.util;
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
  
    partial class Addform : MaterialForm
    {
        StudentCtrl sc;
        public Addform(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

      

        private void uiSymbolLabel5_Click(object sender, EventArgs e)
        {
            if (TextName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요.");
            }
            if (TextTel.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
            }
            if (TextAddress.Text == "")
            {
                MessageBox.Show("주소를 입력하세요.");
            }
            if (TextEmail.Text == "") 
            {
                MessageBox.Show("email을 입력하세요.");
            }
            if (TextName.Text != "" && TextTel.Text != "" && TextAddress.Text != "" && TextEmail.Text != "")
            {


                Random r = new Random();
                sc.getList().Add(new Student(new RandData(r).getId(), TextName.Text, TextTel.Text, TextAddress.Text, TextEmail.Text));
                Close();
            }
        }

        private void addExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}