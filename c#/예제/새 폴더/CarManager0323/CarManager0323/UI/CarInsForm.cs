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
    public partial class CarInsForm : MaterialForm
    {
        private DaoOracle ora;

        public CarInsForm(DaoOracle ora)
        {
            InitializeComponent();
            this.ora = ora;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Car car = null;
            try
            {
                car = new Car(txtbxCarModel.Text, Int32.Parse(txtbxCarPrice.Text), txtbxCarColor.Text, txtbxCarCompany.Text, txtbxCarYear.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("가격은 숫자만 입력해주세요 :)");
                return;
            }
            if(ora.tryInsertCar(car))
            {
                MessageBox.Show("추가되었습니다 :)");
                Close();
            }
            else
            {
                MessageBox.Show("올바른 정보를 기재해주세요 :)");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
