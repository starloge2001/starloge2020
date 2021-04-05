using CarManager0323.DB;
using CarManager0323.UI;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CarManager0323
{
    public partial class MainForm : MaterialForm
    {
        DaoOracle ora = new DaoOracle();
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ora.dbConnect();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ora.dbClose();
        }

        private void createTB_Click(object sender, EventArgs e)
        {
            ora.makeCustomer();
            ora.makeCar();
            ora.makeSeller();
            ora.makeSell();
        }

        private void drobTB_Click(object sender, EventArgs e)
        {
            ora.dropAllTB();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            new CustomerForm(ora).ShowDialog();
            /* ora.insertCar();
            ora.insertCustomer();
            ora.insertSeller();
            ora.insertSell();*/
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            ora.dbClose();
            Application.Exit();
        }
    }
}
