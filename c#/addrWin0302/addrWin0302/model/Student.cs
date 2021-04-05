using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    class Student
    {
        private static Student inst;

        public static Student getInst()
        {
            if (inst == null)
            {
                inst = new Student();
            }
            return inst;
        }

        public Student() { }

        public Student(string name, string tel, 
            string address, string email)
        {
            this.Name = name;
            this.Tel = tel;
            this.Address = address;
            this.Email = email;
        }

        public Student(string id, string name, string tel, 
            string address, string email) 
            : this(name, tel, address, email)
        {
            this.Id = id;
        }

        

        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }


    }
}
