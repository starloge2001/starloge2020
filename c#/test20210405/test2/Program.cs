using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1/2);

            //덧셈 뺄셈 곱셈 나눗샘 나머지
            Console.WriteLine(5+3);
            Console.WriteLine(5-3);
            Console.WriteLine(5*3);
            Console.WriteLine(5/3);
            Console.WriteLine(5%3);

            //연산의 우선 순위를 신경쓰고 싶지 않다면 괄호를 넣어줄것
            Console.WriteLine((5+3)*(5-2));

            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);

            //문자 선택자
            Console.WriteLine("안녕하세요"[0]);//안
            Console.WriteLine("안녕하세요"[4]);//요
            //Console.WriteLine("안녕하세요"[5]);//Error!!!!!

            Console.WriteLine((int)"안녕하세요"[0]);//안
            Console.WriteLine(Convert.ToString((int)"안녕하세요"[0],16));//안

            Console.WriteLine(1==1);
            Console.WriteLine(1!=1);

            bool result = true;
            bool result2 = false;
            
            Console.WriteLine(!result);//논리 부정 연산자
            Console.WriteLine(!result2);//논리 부정 연산자

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(1+1);

            int a = int.MaxValue;
            int b = int.MaxValue;
            Console.WriteLine(a+b);
            Console.WriteLine((long)a+b);

            uint c = uint.MaxValue;
            Console.WriteLine(c);

            int example = 100;
            Console.WriteLine(example++);//100
            Console.WriteLine(++example);//102

            int exex = 100;
            Console.WriteLine(exex);
            exex = exex + 1;
            
            exex = exex + 1;
            Console.WriteLine(exex);

            int conclusion = 100;
            //++을 무조건 뒤에 붙이고 그냥 두 줄로 나눠서 쓰기
            conclusion++;
            Console.WriteLine(conclusion);
            conclusion++;
            Console.WriteLine(conclusion);

            string input = Console.ReadLine();
            Console.WriteLine("안녕 나는 " + input + "이야");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("내 키는 " + input2 + "cm야");
            int number = int.Parse(Console.ReadLine());
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(number/num);

        }
    }
}
