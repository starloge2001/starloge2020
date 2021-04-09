using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번문제");
            int inch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inch}inch = {inch * 2.54}cm");

            Console.WriteLine("2번문제");
            int kg = int.Parse(Console.ReadLine());
            Console.WriteLine($"{kg}kg = {kg * 2.20462262}pound");

            Console.WriteLine("3번문제");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double around = 2 * pi * r;
            double area = pi * r * r;
            Console.WriteLine($"원의 둘레는 {around}고 넓이는 {area}이다");

            Console.WriteLine("3번문제");
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            Console.WriteLine(a * (b[2] - '0'));
            //Console.WriteLine(a * int.Parse(b[2].ToString()));
            Console.WriteLine(a * (b[1] - '0'));
            Console.WriteLine(a * (b[0] - '0'));
            Console.WriteLine(a * int.Parse(b));

            
            Console.WriteLine(a * int.Parse(b)%10);
            Console.WriteLine(a * (int.Parse(b) % 100) / 10);
            Console.WriteLine(a * int.Parse(b)/100);
            Console.WriteLine(a * int.Parse(b));

            

           /* string numb = Console.ReadLine();
            int tmp = "123"[0];
            int[] str = { '1', '2', '3', '\0' };
            tmp = str[0];
            int h = numb[0] - '0';
            int g = numb[1] - '0';*/
        }
    }
}
