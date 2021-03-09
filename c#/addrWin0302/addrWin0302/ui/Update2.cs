using addrWin0302.ui;
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
using static System.Windows.Forms.ListView;

namespace addrWin0302
{
  
    partial class Update2 : MaterialForm
    {
        StudentCtrl sc;
        int n;
        Update parent;
        ListViewItemCollection items;
        public Update2(StudentCtrl sc,int n, Update parent, ListViewItemCollection items)
        {
            InitializeComponent();
            this.sc = sc;
            this.n = n;
            this.parent = parent;
            this.items = items;
        }

      

        private void uiSymbolLabel5_Click(object sender, EventArgs e)
        {
            List<Student> scg = sc.getList();
            sc.getList()[n].Name = TextName.Text;
            sc.getList()[n].Tel = TextTel.Text;
            sc.getList()[n].Address = TextAddress.Text;
            sc.getList()[n].Email = TextEmail.Text;
            items.Clear();
            parent.initListView();
            this.Close();                   
        }

        private void addExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Update2_Load(object sender, EventArgs e)
        {
            List<Student> scg = sc.getList();
            TextName.Text = sc.getList()[n].Name;
            TextTel.Text = sc.getList()[n].Tel;
            TextAddress.Text = sc.getList()[n].Address;
            TextEmail.Text = sc.getList()[n].Email;
        }
    }
}