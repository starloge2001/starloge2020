using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] rotto = new int[6];
            int[] count = new int[45];
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    rotto[j] = r.Next(1, 46);
                    for (int k = 0; k < j; k++)
                    {
                        if (rotto[j] == rotto[k])
                        {
                            i--;
                            break;
                        }
                    }
                    count[rotto[j] - 1] +=  1;
                }
            }
        }
    }
}
