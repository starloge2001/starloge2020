using CarManager0323.DB;
using CarManager0323.Model;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CarManager0323.UI
{
    public partial class CustomerForm : MaterialForm
    {
        private DaoOracle oracle;
        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        private void custCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void custOK_Click(object sender, EventArgs e)
        {
            Customer cust = null;
            if (custName.Text == "" || custTel.Text == "" ||
               custAddr.Text == "" || custEmail.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" +
                    "올바르게 입력하세요.");
                return;
            }
            try
            {
                cust = new Customer(
                    custName.Text,
                    custTel.Text,
                    custAddr.Text,
                    custEmail.Text);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("객체 정보를 확인하세요.");
            }
            Close();
            new CarForm(oracle, cust).ShowDialog();

        }
    }
}
