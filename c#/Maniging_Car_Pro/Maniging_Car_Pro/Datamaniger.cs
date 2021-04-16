using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Maniging_Car_Pro
{
    class Datamaniger
    {
        public static List<ParkingCar> cars = new List<ParkingCar>();
        static Datamaniger()
        {
            Load();
        }
        public static void Load()
        {
            cars.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars1.xml");
                XElement carsXElement = XElement.Parse(carsOutput);
                foreach (var item in carsXElement.Descendants("car"))
                {
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value);
                    string tempCarNumber = item.Element("carNumber").Value;
                    string tempDriverName = item.Element("driverName").Value;
                    string tempPhoneNumber = item.Element("phoneNumber").Value;
                    DateTime tempParkingTime = item.Element("parkingTime").Value == ""? 
                        DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value);
                    ParkingCar p = new ParkingCar()
                    {
                        parkingSpot = tempParkingSpot,
                        carNumber = tempCarNumber,
                        driverName = tempDriverName,
                        phoneNumber = tempPhoneNumber,
                        parkingTime = tempParkingTime
                    };
                    cars.Add(p);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                Creatfile();
                Save();
                Load();
            }
        }
        private static void Creatfile()
        {
            //Cars.xml 파일을 만들겁니다.

            string fileName = @"./Cars1.xml";
            StreamWriter writer = File.CreateText(fileName);//파일이 없으면 해당 파일 생성
            writer.Dispose();//메모리해제
        }
        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<cars>\n";
            if (cars.Count > 0)
            {
                foreach (var item in cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{item.parkingSpot}</parkingSpot>";
                    booksOutput += $"   <carNumber>{item.carNumber}</carNumber>";
                    booksOutput += $"   <driverName>{item.driverName}</driverName>";
                    booksOutput += $"   <phoneNumber>{item.phoneNumber}</phoneNumber>";
                    booksOutput += $"   <parkingTime>{item.parkingTime}</parkingTime>";
                    booksOutput += "</car>\n";
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{i}</parkingSpot>";
                    booksOutput += "   <carNumber></carNumber>";
                    booksOutput += "   <driverName></driverName>";
                    booksOutput += "   <phoneNumber></phoneNumber>";
                    booksOutput += "   <parkingTime></parkingTime>";
                    booksOutput += "</car>\n";

                }
            }
            booksOutput += "</cars>";
            File.WriteAllText(@"./Cars1.xml", booksOutput);
        }
        private void ex()
        {

        }
        public static void printLog(string contents,string name = "parkingHistory")
        {

            DirectoryInfo di = new DirectoryInfo("parkingHistory");
            if (!di.Exists)
            {
                di.Create();
            }
            //using (StreamWriter writer= new StreamWriter(@"parkingHistory\parkingHistory.txt",true))
            using (StreamWriter writer= new StreamWriter(@"parkingHistory\"+name+".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
