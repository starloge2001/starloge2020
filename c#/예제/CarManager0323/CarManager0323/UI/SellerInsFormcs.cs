﻿using CarManager0323.DB;
using CarManager0323.Handler;
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
    partial class SellerInsFormcs : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;

        public SellerInsFormcs()
        {
            InitializeComponent();
        }

        public SellerInsFormcs(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public SellerInsFormcs(DaoOracle oracle, 
            DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void sellerOK_Click(object sender, EventArgs e)
        {
            if (sellerName.Text == "" || sellerTel.Text == "" ||
                sellerEmail.Text == "" || sellerJikwi.Text == "" ||
                sellerOffice.Text=="")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" +
                    "올바르게 입력하세요.");
                return;
            }

            List<Deal> list = dHandler.getDealList();
            try
            {
                Seller seller = new Seller(
                    sellerName.Text,
                    sellerTel.Text,
                    sellerEmail.Text,
                    sellerJikwi.Text,
                    sellerOffice.Text);
                list[0].Seller = seller;
                oracle.insertSeller(seller);
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("객체 정보를 확인하세요.");
            }
        }

        private void sellerCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
