using adressTest0218;
using adressTest0218.control;
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

namespace addrWin0302.ui
{
    partial class Viewform : MaterialForm
    {
        StudentCtrl sc;
        public Viewform(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void initListView()
        {
           
            List<Student> scg = sc.getList();
            for (int i = 0; i < scg.Count; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { i + 1 + "", scg[i].Name, scg[i].Tel, scg[i].Address, scg[i].Email }));
            }
            if(scg.Count==0)
            {
                return;
            }
            setRowColor(listView1, Color.White, Color.LightGray);
            int index = listView1.Items.Count - 1;
            listView1.Items[index].Selected = true;
            listView1.Items[index].Focused = true;
            listView1.EnsureVisible(index);
        }

        private void setRowColor(ListView list, Color color1,Color color2)
        {
            foreach(ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        
        private void Viewform_Load(object sender, EventArgs e)
        {
            initListView();
            initGridView();
        }
        private void initGridView()
        {
           
            List<Student> scg = sc.getList();
            for (int i = 0; i < scg.Count; i++)
            {
                gridView1.Rows.Add(new string[] { i + 1 + "", scg[i].Name, scg[i].Tel, scg[i].Address, scg[i].Email });
            }
            if (scg.Count == 0)
            {
                return;
            }
            int count = gridView1.Rows.Count - 1;
            gridView1.FirstDisplayedScrollingRowIndex = count;
            gridView1.CurrentCell = gridView1.Rows[count - 1].Cells[0];
        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
