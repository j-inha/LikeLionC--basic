using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightStudy3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int[] numbers = new int[5];
            //for(int i = 0;i < numbers.Length; i++) 
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    sum += numbers[i];

            //}

            //int[] numbers = new int[] { 12, 45, 7, 34, 22 };
            //int max = numbers[0];
            //int min = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine(max + "\t" + min);
            //List<int> number = new List<int>();
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[4-i]);
            //}
            //List<int> number = new List<int>();
            //for(int i = 0; i < 5; i++)
            //{
            //    number.Add(i + 1);
            //}
            //for (int i = 0; i < number.Count; i++)
            //{
            //    Console.WriteLine(number[4 - i]);
            //}
            //number.ForEach((n) => Console.WriteLine(number.Count-n+1));
            //int[,] array =
            //{
            //    {1,2,3 },
            //    {4,5,6 },
            //    {7,8,9 },
            //};
            //int rowSum = 0;
            //for(int i = 0;i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        rowSum += array[i, j];
            //    }

            //    Console.WriteLine(rowSum);
            //}

            //int columnSum = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        columnSum += array[j, i];
            //    }
            //    Console.WriteLine(columnSum);
            //}
            int[,] num =
            {
                {1,2,3 },
                {4,5,6 },
            };
            for(int i = 0; i < num.GetLength(0); i++)
            {
                Console.WriteLine($"{i+1}행" );

                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i,j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < num.GetLength(1); i++)
            {
                Console.WriteLine($"{i + 1}열");

                for (int j = 0; j < num.GetLength(0); j++)
                {
                    Console.Write(num[j, i]);
                }
                Console.WriteLine();
            }


        }
    }
}
