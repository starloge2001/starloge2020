using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    public class Seller
    {
        private int id;
        private string name;
        private string tel;
        private string email;
        private string jikwi;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Jikwi { get => jikwi; set => jikwi = value; }

        public Seller(int id)
        {
            this.id = id;

            this.name = null;
            this.tel = null;
            this.email = null;
            this.jikwi = null;
        }

        public Seller(string name, string tel, string email, string jikwi)
        {
            this.name = name;
            this.tel = tel;
            this.email = email;
            this.jikwi = jikwi;
        }
    }
}
