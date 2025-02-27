using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0227_Report
{
    internal class Program
    {
        //6.함수 오버로딩(Overloading)

        /// <summary>
        /// 두수를 곱하는 함수
        /// </summary>
        /// <param name="a">int,double 오버로딩해놈</param>
        /// <param name="b">int,double 오버로딩해놈</param>
        /// <returns></returns>
        //전역변수
        static int num2 = 2;

        static int GetNumber()
        {
            return 42;
        }
        //매개변수와 반환값이 있는 함수
        static int add(int x, int y)
        {
            return x + y;
        }

        //기본값을 가진 매개변수 (디폴트 매개변수)
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        

        //out 키워드 (여러 값을 반환할떄)
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        //ref 키워드(값을 참조하여 수정)
        static void Increase(ref int num)
        {
            num += 10;
        }
        //params 키워드 개수 제한 없이 여러개의 인자를 전달 할 수 있도록 해주는 기능
        //가변 매개변수
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers) { total += number; }
            return total;
        }
        //재귀함수(자기자신을 호출)

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3));
            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);
            int q, r;
            Divide(10,3,out q,out r);
            Console.WriteLine($"몫 : {q}, 나머지 : {r}");

            Greet(); //그냥 사용할 수 도 있고
            Greet("철수");  //이렇게 매개변수를 넣어도 된다.

            //함수 안의 변수는 로컬 변수라고 한다.
            int num = GetNumber();
            Console.WriteLine(num);
            Console.WriteLine(num2);
            int addnum = add(3, 5);
            Console.WriteLine(addnum);

        }


    }
}
