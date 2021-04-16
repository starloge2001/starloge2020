using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06_2
{
    class Accouent
    {
        public int myMoney;
        public string name;
        public Accouent(int money,string name)
        {
            myMoney = money;
            this.name = name;
        }

        public void deposit(int money)
        {
            myMoney += money;
        }

        public void withdraw(int money)
        {
            myMoney -= money;
        }
    }
}
