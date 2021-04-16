using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    public class Deal
    {
        private int id;
        private string date;
        Customer customer;
        Car car;
        Seller seller;

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }

        public Deal(Customer customer, Car car, Seller seller)
        {
            this.date = null;
            this.customer = customer;
            this.car = car;
            this.seller = seller;
        }
    }
}
