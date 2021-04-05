using CarManager0323.DB;
using CarManager0323.Model;
using System;
using System.Windows.Forms;

namespace CarManager0323.UI
{
    public partial class SellerForm : Form
    {
        private DaoOracle oracle;
        private Customer cust;
        private Car car;

        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(DaoOracle oracle, Customer cust, Car car)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.cust = cust;
            this.car = car;
        }
        private void sellerCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sellerOK_Click(object sender, EventArgs e)
        {
            Seller seller = null;
            if (sellerName.Text == "" || sellerTel.Text == "" ||
                sellerEmail.Text == "" || sellerJikwi.Text == "" ||
                sellerOffice.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" +
                    "올바르게 입력하세요.");
                return;
            }

            try
            {
                seller = new Seller(
                    sellerName.Text,
                    sellerTel.Text,
                    sellerEmail.Text,
                    sellerJikwi.Text,
                    sellerOffice.Text);
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("객체 정보를 확인하세요.");
            }
            oracle.insertCustomer(cust);
            oracle.insertCar(car);
            oracle.insertSeller(seller);
            oracle.insertSell();
            Close();
        }

    }

}
