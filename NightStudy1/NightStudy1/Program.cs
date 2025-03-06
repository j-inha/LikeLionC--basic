using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NightStudy1
{
    internal class Program
    {
        static void Main(string[] args)
        { //F10 > 디버깅 모드 에서 F11 번을 누르면 시작부터 한 단계씩 시작이된다

            //int Score = int.Parse(Console.ReadLine());
            //if (Score <= 100)
            //{
            //    Console.WriteLine("레벌업");
            //}
            //else { Console.WriteLine("노력필요"); }
            //string message = Score <= 100 ? "레벌업" : "노력필요";
            //Console.WriteLine(message);
            //int age = int.Parse(Console.ReadLine());
            //if (age < 13)
            //{ Console.WriteLine("어린이"); }
            //else if (13 <= age && age <= 19) { Console.WriteLine("청소년"); }
            //else { Console.WriteLine("성인"); }

            //string grade = Console.ReadLine();
            //switch (grade)
            //{
            //    case "A": Console.WriteLine("최고"); break;
            //    case "B": Console.WriteLine("좋음"); break;
            //    case "C": Console.WriteLine("보통"); break;
            //    case "D": Console.WriteLine("탈락"); break;


            //}

            //int month = int.Parse(Console.ReadLine());
            //switch (month) {
            //    case 1:
            //    case 2:
            //    case 12:
            //     Console.WriteLine("겨울"); break;
            //    case 3: case 4: case 5: Console.WriteLine("봄");break;
            //    case 6: case 7: case 8: Console.WriteLine("여름");break;
            //    case 9: case 10: case 11: Console.WriteLine("가을");break;
            //    default: Console.WriteLine("잘못 입력되었습니다"); break;

            //}
            int j = 0;
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 10; i++) { Console.WriteLine(i + 1); }
            for (int i = 0; i < 10; i++) { sum += i; }
            Console.WriteLine(sum);
            while (j < 10)
            {
                Console.WriteLine(j + 1);
                j++;

            }
            for (int i = 0; i < 10; i++) { count = 2 * (i + 1); Console.WriteLine(count); }
            string star = "";
            for (int i = 0; i < 10; i++)
            {
                star += "*";
                Console.WriteLine(star);
            }
        }
    }
}
