using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0226_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 반복문
            //int[] number1 = new int[5] { 10, 20, 30, 40, 50 };
            //for (int i = 0; i < number1.Length; i++)
            //{
            //    Console.Write(number1[i] + " ");
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("숫자를 입력하세요");


            //int[] number2 = new int[5];
            //for (int i = 0; i < number2.Length; i++)
            //{
            //    number2[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //for (int i = 0; i < number2.Length; i++)
            //{
            //    sum += number2[i];
            //}
            //Console.WriteLine(sum);





            //Console.ReadLine();
            //Console.Clear();

            //int[] number3 = new int[5] { 3, 8, 15, 6, 2 };
            //int max = 0;
            //for (int i = 0; i < number3.Length; i++)
            //{
            //    if (number3[i] > max)
            //    {
            //        max = number3[i];
            //    }
            //}
            //Console.WriteLine(max);

            //Console.ReadLine();
            //Console.Clear();
            ////반복문
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.Write(i + " ");

            //}
            //Console.ReadLine();
            //Console.Clear();
            //int k = 1;
            //while (k < 11)
            //{
            //    if (k % 2 == 0)
            //    {
            //        Console.Write(k + " ");
            //    }
            //    k++;

            //}

            //Console.ReadLine();
            //Console.Clear();
            //int[] number6 = new int[5] { 1, 2, 3, 4, 5 };
            //foreach (int number in number6)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion
            //int num1 = 0;
            //int num2 = 0;
            //Console.Write("첫번째 숫자 입력 : ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("두번째 숫자 입력 : ");
            //num2 = int.Parse(Console.ReadLine());
            //int addcal = addcount(num1, num2);
            //Console.WriteLine($"{num1}과 {num2}의 합 : {addcal}");



            //string sen = "";
            //Console.Write("문자열 입력 : ");
            //sen = Console.ReadLine();
            //int size = length(sen);
            //Console.WriteLine($"문자열의 길이 : {size}");
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.Write("첫번째 숫자 입력 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자 입력 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("세번째 숫자 입력 : ");
            num3 = int.Parse(Console.ReadLine());
            int max = maxnumber(num1, num2, num3);
            Console.WriteLine($"가장 큰 수 :  {max}");
        }

        
        static int maxnumber(int number1, int number2, int number3)
        {
            int maxcount = number1;
            if (maxcount < number2) { maxcount = number2; }
            if (maxcount < number3) { maxcount = number3; }
            return maxcount;
        }


    }
}
