using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0227_Class
{
    internal class Program
    {

        //열거형
        //Enumberation enum
        //숫가 값에 이름을 부여하는 자료형
        //가독성을 높이고, 의미 있는 값으로 표현
        //기본적으로 첫번째 값 0부터 시작하여 1씩증가
        enum DayofWeek
        {
            Sunday, //0
            Monday,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
        //enum 값 변경(0부터 시작하지 않기)
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404,
        }
        enum WeaponType
        {
            Sword,
            Bow,
            Staff,

        }
        static void ChooseWeapon(WeaponType weaponType)
        {
            if (weaponType == WeaponType.Sword)
            {
                Console.WriteLine("검을 선택했습니다.");
            }
            else if (weaponType == WeaponType.Bow)
            {
                Console.WriteLine("활을 선택했습니다.");

            }
            else if (weaponType == WeaponType.Staff)
            {
                Console.WriteLine("지팡이을 선택했습니다.");

            }
        }

        //구조체
        //클래스와 비슷하지만 값 타입(value type)이며 가볍고 빠름
        //주로 간단한 데이터 묶음에 사용

        //struct Point
        //{
        //    public int X;
        //    public int Y;

        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //    public void Print()
        //    {
        //        Console.WriteLine($"{X}, {Y}");
        //    }
        //}
        struct Point
        {
            public int x;
            public int y;
        }
        //생성자
        //매개변수를 통한 초기화 가능
        //모든 필드를 반드시 초기화 해야함(클래스와 다름)
        struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }

        struct Student
        {
            public string name;
            public int Korean;
            public int English;
            public int MAth;
            public void Print()
            {
                Console.WriteLine($"{name}\t{Korean}\t{English}\t{MAth}");
                //$"{name,-5}\t{Korean,5}\t{English,5}\t{MAth,5}"-5는 5왼쪽정렬하겠다는 의미
                //\t 하나의 탭을 추가하는 문자로 일정한 간격 생김
            }
        }

        static void Main(string[] args)
        {
            //학생 배열 선언
            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("학생의 이름을 입력하세요 : ");
                students[i].name = Console.ReadLine();
                Console.WriteLine("학생성적을 입력하세요.");
                Console.WriteLine("국어 :");
                students[i].Korean = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 :");
                students[i].English = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 :");
                students[i].MAth = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("이름\t국어\t영어\t수학");
            foreach (Student student in students)
            {
                student.Print();
            }


            Point[] points = new Point[2];
            points[0].x = 10;
            points[0].y = 10;

            points[1].x = 20;
            points[1].y = 20;

            foreach (var point in points) { Console.WriteLine($"Point: ({point.x}, {point.y})"); }


            //  var rect = new Rectangle { Width = 5, Height = 4 };
            Rectangle rect;
            rect.Width = 10;
            rect.Height = 20;
            Console.WriteLine($"Area : {rect.GetArea()}");




            //Point p1 = new Point(5, 15);
            //p1.Print();

            //Point p;//구조체 선언 (초기화필요)
            //p.X = 10;
            //p.Y = 20;
            ChooseWeapon(WeaponType.Bow); // 활을 선택했습니다.
            StatusCode status = StatusCode.Success;
            Console.WriteLine(status);
            Console.WriteLine((int)status);


            DayofWeek today = DayofWeek.Sunday;
            //숫자를 직접 사용하지 않고, 의미있는이름으로 관리가능
            Console.WriteLine(today);
            Console.WriteLine((int)today);

            //math클래스 사용
            //수학적 계산
            Console.WriteLine($"Pi: {Math.PI}");
            Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            Console.WriteLine($"Power (2^3): {Math.Pow(2, 3)}");
            Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");

        }

        //화살표함수
        static int AddArrow(int x, int y) => x + y;

        static void PrintMEssege()
        {
            Console.WriteLine("안녕하세요");
        }

        static void PrintMessageArrow() => Console.WriteLine("안녕하세요");
    }
}
//c#에서 화살표함수 => 람다 표현식이라고도하며
//간결한 방식으로 함수 정의 가능

//namespace
//클래스, 함수,변수 이름이 충돌하는것을 방지하기위해 사용된다.

namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요 !MyNamespace의 MyClass입니다.");
        }
    }
}

