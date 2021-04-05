using CarManager0323.Model;
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

namespace CarManager0323.UI
{
    public partial class DealInsForm : MaterialForm
    {
        private DaoOracle ora;
        private Car[] cars;
        private Customer[] customers;
        private Seller[] sellers;

        public DealInsForm(DaoOracle ora)
        {
            InitializeComponent();
            this.ora = ora;
            this.cars = ora.getSelectAllCars();
            this.customers = ora.getSelectAllCustomers();
            this.sellers = ora.getSelectAllSellers();

            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            foreach (var item in cars)
            {
                sb.Append(item.Id + " / ").Append(item.Model);
                list.Add(sb.ToString());
                sb.Clear();
            }
            this.comboBoxCar.Items.AddRange(list.ToArray());
            list.Clear();
            sb.Clear();
            foreach (var item in customers)
            {
                sb.Append(item.Id + " / ").Append(item.Name);
                list.Add(sb.ToString());
                sb.Clear();
            }
            this.comboBoxCustomer.Items.AddRange(list.ToArray());
            list.Clear();
            sb.Clear();
            foreach (var item in sellers)
            {
                sb.Append(item.Id + " / ").Append(item.Name);
                list.Add(sb.ToString());
                sb.Clear();
            }
            this.comboBoxSeller.Items.AddRange(list.ToArray());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string carId = null, customerId = null, sellerId = null;
            if (comboBoxCar.SelectedItem != null)
                carId = comboBoxCar.SelectedItem.ToString()
                .Split(new string[] { " / " }, StringSplitOptions.RemoveEmptyEntries)[0];
            else
            {
                MessageBox.Show("어떤 판매자가 어떤 고객에게 무슨차를 팔았는지 선택해주세요 :)");
                return;
            }
            if (comboBoxCustomer.SelectedItem != null)
                customerId = comboBoxCustomer.SelectedItem.ToString()
                .Split(new string[] { " / " }, StringSplitOptions.RemoveEmptyEntries)[0];
            else
            {
                MessageBox.Show("어떤 판매자가 어떤 고객에게 무슨차를 팔았는지 선택해주세요 :)");
                return;
            }
            if (comboBoxSeller.SelectedItem != null)
                sellerId = comboBoxSeller.SelectedItem.ToString()
                .Split(new string[] { " / " }, StringSplitOptions.RemoveEmptyEntries)[0];
            else
            {
                MessageBox.Show("어떤 판매자가 어떤 고객에게 무슨차를 팔았는지 선택해주세요 :)");
                return;
            }

            bool isSuccess = ora.tryInsertDeal(
                new Deal
                (
                    new Customer(int.Parse(customerId)),
                    new Car(int.Parse(carId)),
                    new Seller(int.Parse(sellerId))
                )
            );
            if (isSuccess)
            {
                MessageBox.Show("추가되었습니다 :)");
                Close();
            }
            else
            {
                MessageBox.Show("올바르게 선택해주세요 :)");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
