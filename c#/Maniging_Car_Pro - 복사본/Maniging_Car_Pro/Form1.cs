using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maniging_Car_Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Datamaniger.Load();
            //List<ParkingCar> cars = new List<ParkingCar>();
            //cars.Add(new ParkingCar() { parkingSpot = 1, carNumber = "30고9484", driverName = "이동준", phoneNumber = "010-2940-1613", parkingTime = DateTime.Now });
            dataGridView1.DataSource = Datamaniger.cars;

            //cars.Add(new ParkingCar());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("1번 버튼 클릭");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("2번 버튼 클릭");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeLog("3번 버튼 클릭", DateTime.Now.ToString("yyyy / MM / dd"));

        }
        private void writeLog(string contents)
        {
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contents}";
            //listBox1.Items.Add(logContens);
            listBox1.Items.Insert(0, logContens);
            Datamaniger.printLog(logContens);
        }
        private void writeLog(string contents, string date)
        {
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contents}";
            //listBox1.Items.Add(logContens);
            listBox1.Items.Insert(0, logContens);
            Datamaniger.printLog(logContens, date);
        }
    }
}
