using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Console0224
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("이진수를 입력하세요 : ");
            //string bineryInput = Console.ReadLine();
            //int decimaValue = Convert.ToInt32(bineryInput, 2);

            //string bineryOutput = Convert.ToString(decimaValue, 2);

            //Console.WriteLine($"입력한 이진수 : {bineryInput} ");
            //Console.WriteLine($"10진수로 변환 : {decimaValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {bineryOutput}");

            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");

            //int c = 0, d = 0;
            //int sum = 0;
            //c = 10;
            //d = 3;
            //sum = c % d;  //나머지구하는 연산자
            //Console.WriteLine($"합 : {sum}");

            //Console.Write("국어 점수를 입력하세요.");
            //int KoreanValue = int.Parse(Console.ReadLine());
            //Console.Write("영어 점수를 입력하세요.");
            //int EnglishValue = int.Parse(Console.ReadLine());
            //Console.Write("수학 점수를 입력하세요.");
            //int MathValue = int.Parse(Console.ReadLine());

            //int sum = KoreanValue + EnglishValue + MathValue;

            //float average = (float) sum / 3;
            //Console.WriteLine($"평균 점수는 {average.ToString("F2")}");

            //Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            //Console.Write("정수를 입력하세요.");
            //int Input = int.Parse(Console.ReadLine());
            //int Output = ~Input;
            //Console.WriteLine(Output);


            Console.WriteLine("문제 1번");
            Console.WriteLine("첫번째 정수를 입력하세요");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 정수를 입력하세요");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("세번째 정수를 입력하세요");
            int z = int.Parse(Console.ReadLine());
            int max = 0;
            if (x < y ) { max = y; }
            else { max = x; }
            if (max < z) { max = z; }
            Console.WriteLine(max);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("문제 2번");
            Console.WriteLine("학생의 점수를 입력하세요");
            int StudentValue = int.Parse(Console.ReadLine());
            if (StudentValue >= 90)
            {
                Console.WriteLine("A");
            }
            else if (StudentValue >= 80)
            {
                Console.WriteLine("B");
            }
            else if (StudentValue >= 70)
            {
                Console.WriteLine("C");
            }
            else if (StudentValue >= 60)
            {
                Console.WriteLine("D");
            }
            else { Console.WriteLine("F"); }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("문제 3번");
            Console.WriteLine("첫번째 정수를 입력하세요");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 정수를 입력하세요");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요");
            string m = Console.ReadLine();
            float result = 0f;
            if (k == 0 || l == 0)
            {
                if (m == "/")
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                if (m == "+")
                {
                    result = k + l;
                }
                else if (m == "-")
                {
                    result = k - l;
                }
                else if (m == "*") { result = k * l; }
                else if (m == "/") { result = k / l; }
                Console.WriteLine(result);

            }
        }
    } 
}
