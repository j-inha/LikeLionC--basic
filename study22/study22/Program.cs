using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study22
{
    class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Strength { get; set; }
        public  void Print()
        {
            Console.WriteLine($"이름 : {Name}, 점수 : {Score}, 힘 : {Strength}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Warrior warrior = new Warrior();
            //warrior.Name = "leo";
            //warrior.Score = 50;
            //warrior.Strength = 100;
            //warrior.Print();
            
            //String input = Console.ReadLine();
            //try
            //{
            //    int count = int.Parse(input);
            //    Console.WriteLine("입력값 "+ count);

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("올바른 숫자 입력해");
            //}
            //List<string> list = new List<string>();
            //list.Add("사과");
            //list.Add("바나나");
            //list.Add("포도");

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("첫 번째 작업");

            //Stack<int> stack = new Stack<int>();
            //stack.Push(10); 
            //stack.Push(20);
            //stack.Push(30);

            //foreach(int s in stack)
            //{
            //    Console.WriteLine(s);
            //}

            //string sentence = Console.ReadLine();
            //Console.WriteLine(sentence.ToUpper());
            //Console.WriteLine(sentence.Replace("C#", "CSharp"));
            //Console.WriteLine(sentence.Length);

            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbersMethod = number.Where(num => num % 2 == 0);
            int sum = number.Sum();
            
            Console.WriteLine("배열 합: " + sum);
        }
    }
}
