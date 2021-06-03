using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    public class Customer
    {
        private int id;
        private string name;
        private string tel;
        private string addr;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Email { get => email; set => email = value; }

        public Customer(int id)
        {
            this.id = id;

            this.name = null;
            this.tel = null;
            this.addr = null;
            this.email = null;
        }

        public Customer(string name, string tel, string addr, string email)
        {
            this.name = name;
            this.tel = tel;
            this.addr = addr;
            this.email = email;
        }
    }
}
