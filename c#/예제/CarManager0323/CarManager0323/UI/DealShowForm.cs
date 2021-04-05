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
    public partial class DealShowForm : MaterialForm
    {
        private DaoOracle ora;
        private Deal[] deals;
        private List<string[]> rows = new List<string[]>();

        public DealShowForm(DaoOracle ora)
        {
            InitializeComponent();
            this.ora = ora;
            deals = ora.getSelectAllDeals();




            // --------------
            // data grid view
            // --------------
            gridView.ColumnCount = 5;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            gridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gridView.GridColor = Color.Black;
            gridView.RowHeadersVisible = false;

            gridView.Columns[0].Name = "거래 번호";
            gridView.Columns[1].Name = "차량";
            gridView.Columns[2].Name = "고객";
            gridView.Columns[3].Name = "판매자";
            gridView.Columns[4].Name = "거래 일시";
            gridView.Columns[4].DefaultCellStyle.Font =
                new Font(gridView.DefaultCellStyle.Font, FontStyle.Italic);
            gridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            gridView.MultiSelect = false;

            foreach (var item in deals)
            {
                int d_id = item.Id;
                Car car = item.Car;
                Customer cust = item.Customer;
                Seller seller = item.Seller;
                string d_date = item.Date;

                StringBuilder sb = new StringBuilder();
                rows.Add(new string[] {
                    d_id.ToString(),
                    new StringBuilder(car.Id + "/").Append(car.Model).ToString(),
                    new StringBuilder(cust.Id + "/").Append(cust.Name).ToString(),
                    new StringBuilder(seller.Id + "/").Append(seller.Name).ToString(),
                    d_date
                });
            }
            foreach (var item in rows)
            {
                gridView.Rows.Add(item);
            }

            gridView.Columns[0].DisplayIndex = 1;
            gridView.Columns[1].DisplayIndex = 4;
            gridView.Columns[2].DisplayIndex = 3;
            gridView.Columns[3].DisplayIndex = 2;
            gridView.Columns[4].DisplayIndex = 0;
        }
    }
}
