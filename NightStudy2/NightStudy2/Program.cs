using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NightStudy2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i<10; i++)
            //{
            //    Console.WriteLine($"{i}단");

            //    for (int j =1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i*j}");
            //    }
            //}
            //for (int i = 1; i < 10; i++)
            //{

            //    for (int j = 2; j < 10; j++)
            //    {
            //        Console.Write($"{j} * {i} = {i * j}\t");
            //    }
            //    Console.WriteLine();
            //}

            Random rnd = new Random();
            Console.WriteLine("1. 가위 2.바위 3. 보 중에서 선택하세요.");
            int answer = int.Parse(Console.ReadLine());
            int computer = rnd.Next(1, 3);
            if (answer == computer)
            {
                Console.WriteLine("무승부");
            }
            else if ((answer == 1 && computer == 3) || (answer == 2 && computer == 1) || (answer == 3 && computer == 2)) { Console.WriteLine("승리"); }
            else Console.WriteLine("패배");
            Console.WriteLine($"상대는 {computer}를 냈습니다.");

            //switch (answer)
            //{
            //    case 1:
            //}
        }
    }
}
