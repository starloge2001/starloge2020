using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번 문제");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine($"{inch}inch = {inch*2.54}cm");

            Console.WriteLine("2번 문제");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine($"{kg}kg = {kg * 2.20462262}pound");

            Console.WriteLine("3번 문제");
            double pi = 3.14;
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"둘레 : {2*pi*r}");
            Console.WriteLine($"넓이 : {pi*r*r}");

            Console.WriteLine("4번 문제");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a * (b % 10));
            Console.WriteLine(a * ((b % 100) / 10));
            Console.WriteLine(a * (b / 100));
            Console.WriteLine(a * b);
        }
    }
}
