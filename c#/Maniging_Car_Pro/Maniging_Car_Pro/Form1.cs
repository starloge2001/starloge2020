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
            //Datamaniger.Load();
            //List<ParkingCar> cars = new List<ParkingCar>();
            //cars.Add(new ParkingCar() { parkingSpot = 1, carNumber = "30고9484", driverName = "이동준", phoneNumber = "010-2940-1613", parkingTime = DateTime.Now });
            dataGridView1.DataSource = Datamaniger.cars;
            textBox1.Text = Datamaniger.cars[0].parkingSpot.ToString();
            textBox2.Text = Datamaniger.cars[0].carNumber.ToString();
            textBox3.Text = Datamaniger.cars[0].driverName.ToString();
            textBox4.Text = Datamaniger.cars[0].phoneNumber.ToString();
            //cars.Add(new ParkingCar());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("주차 버튼 클릭");
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차공간을 입력해라");
                writeLog("주차공간을 입력해라");
            }
            else if(textBox2.Text.Trim() == "")
            {
                MessageBox.Show("차번호를 입력해라");
                writeLog("차번호를 입력해라");
            }
            else
            {
                try
                {
                    ParkingCar car = Datamaniger.cars.Single((x) => x.parkingSpot.ToString() == textBox1.Text);
                    if (car.carNumber.Trim() != "")
                    {
                        MessageBox.Show("해당 공간에는 이미 차 있어요." + textBox1.Text);
                        writeLog("해당 공간에는 이미 차 있어요." + textBox1.Text);
                    }
                    else
                    {
                        car.parkingSpot = int.Parse(textBox1.Text);
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Datamaniger.cars;
                        Datamaniger.Save();

                        string contens = $"주차 공간{textBox1.Text}에 {textBox2.Text}차를 주차됨";
                        MessageBox.Show(contens);
                        writeLog(contens, DateTime.Now.ToString("yyyy_MM_dd"));
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    writeLog(ex.Message);
                }
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("출차 버튼 클릭");
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차공간 번호를 입력해 주세요!");
                return;
            }
            try
            {
                for (int i = 0; i < Datamaniger.cars.Count; i++)
                {
                    if (Datamaniger.cars[i].parkingSpot.ToString() == textBox1.Text)
                    {
                        if(Datamaniger.cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("아직 차 없음");
                            writeLog("아직 차 없음");
                            break;
                        }
                        else
                        {
                            Datamaniger.cars[i].carNumber = "";
                            Datamaniger.cars[i].driverName = "";
                            Datamaniger.cars[i].phoneNumber = "";
                            Datamaniger.cars[i].parkingTime = DateTime.Now;
                            string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차량 출차";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = Datamaniger.cars;
                            Datamaniger.Save();
                            break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                writeLog(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeLog("주차 차량 조회", DateTime.Now.ToString("yyyy / MM / dd"));
            if (Datamaniger.cars[int.Parse(textBox5.Text)-1].carNumber == "")
            {
                MessageBox.Show("주차된 차가 없습니다.");

            }
            else
            {
                
                MessageBox.Show($"주차공간 {Datamaniger.cars[int.Parse(textBox5.Text)-1].parkingSpot}에 {Datamaniger.cars[int.Parse(textBox5.Text)-1].carNumber}차량이 {Datamaniger.cars[int.Parse(textBox5.Text)-1].parkingTime}에 주차되었습니다.");

            }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar temp = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }
    }
}
