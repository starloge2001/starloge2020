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

        }
        public static void Load()
        {
            cars.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
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
            }
        }
        private static void Creatfile()
        {

        }
        public static void Saver()
        {

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
