using CarManager0323.DB;
using CarManager0323.Model;
using System;
using System.Windows.Forms;

namespace CarManager0323.UI
{
    public partial class CarForm : Form
    {
        private DaoOracle oracle;
        private Customer cust;

        public CarForm()
        {
            InitializeComponent();
        }

        public CarForm(DaoOracle oracle, Customer cust)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.cust = cust;
        }

        private void carCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carOK_Click(object sender, EventArgs e)
        {
            Car car = null;
            if (carModel.Text == "" || carPrice.Text == "" ||
                carColor.Text == "" || carCompany.Text == "" ||
                carYear.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" +
                    "올바르게 입력하세요.");
                return;
            }


            try
            {
                car = new Car(
                   carModel.Text,
                   carPrice.Text,
                   carColor.Text,
                   carCompany.Text,
                   carYear.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("가격을 올바른 숫자로 입력하세요.");
            }
            Close();
            new SellerForm(oracle, cust, car).ShowDialog();

        }
    }
}
