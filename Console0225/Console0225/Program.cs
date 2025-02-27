using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Console0225
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 스위치문
            //int day = 1;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    case 6:
            //        Console.WriteLine("토요일");
            //        break;
            //    case 7:
            //        Console.WriteLine("일요일");
            //        break;



            //}
            #endregion
            #region 캐릭터선택 스위치문
            //Console.WriteLine("캐릭터를 선택하세요. 1.검사 2.마법사 3. 도적");
            //int job = int.Parse(Console.ReadLine());
            //switch (job)
            //{
            //    case 1:
            //        Console.WriteLine("검사");
            //        Console.WriteLine("공격력 100");
            //        Console.WriteLine("방어력 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사");
            //        Console.WriteLine("공격력 110");
            //        Console.WriteLine("방어력 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적");
            //        Console.WriteLine("공격력 115");
            //        Console.WriteLine("방어력 70");
            //        break;

            //}
            //Console.WriteLine("캐릭터를 선택하세요. 1.검사 2.마법사 3. 도적");
            //int select = int.Parse(Console.ReadLine());
            //string job = "";
            //int attack = 0;
            //int defence = 0;
            //switch (select)
            //{
            //    case 1:
            //        job = "검사";
            //        attack = 100;
            //        defence = 90;
            //        break;
            //    case 2:
            //        job = "마법사";
            //        attack = 110;
            //        defence = 80;
            //        break;
            //    case 3:
            //        job = "도적";
            //        attack = 115;
            //        defence = 70;
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 선택입니다.");
            //        break;

            //}
            //Console.WriteLine($"직업: {job} \n공격력:{attack}\n방어력:{defence}");
            #endregion
            #region 반복문합계
            //int sum = 0;
            //for (int i = 0; i < 10; i++) {Console.WriteLine(i);}
            //for(int j=0; j < 10; j++) { 
            //    sum += j;

            //}
            //Console.WriteLine(sum);
            #endregion
            //0226
            #region 배열-국수영

            //int[] iKor = new int[3];
            //int[] iEng = new int[3];
            //int[] iMath = new int[3];

            //int[] sum = new int[3];
            //float[] avr = new float[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("학생의 성적입력");
            //    Console.Write("국어 ");
            //    iKor[i] = int.Parse(Console.ReadLine());
            //    Console.Write("영어 ");
            //    iEng[i] = int.Parse(Console.ReadLine());
            //    Console.Write("수학 ");
            //    iMath[i] = int.Parse(Console.ReadLine());

            //    sum[i] = iKor[i] + iEng[i] + iMath[i];
            //    avr[i] = (float)sum[i] / 3;
            //}
            #endregion
            #region 소수점출력
            //double value = 123.456789;
            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점둘째 : {value:F2}");
            //Console.WriteLine(String.Format("소수점둘째 : {0:F2}", value));
            //Console.WriteLine(value.ToString("F0"));

            //double value2 = 12312312545365.123145;
            //Console.WriteLine(value2.ToString("N2")); //숫자를 천단위 구분기호와함께 소수점 이하 2자리까지 출력
            //double value3 = 123_123_12545365.123145;
            //Console.WriteLine(value3);
            //Console.WriteLine(value3.ToString("N2")); //숫자를 천단위 구분기호와함께 소수점 이하 2자리까지 출력

            #endregion
            #region 이차원배열
            //int[,] matrix = new int[2, 3]
            //{
            //    {1, 2, 3 },
            //    {4, 5, 6 }
            //};
            //for (int i = 0; i < 2; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"{matrix[i,j]}");
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine("가변 배열");
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };


            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"{jaggedArray[i][j]}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("var 키워드 사용");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입: {numbers.GetType()}");


            #endregion
            #region 빙고게임
            //int a = 10;
            //int b = 20;
            //int t = 0;

            //t = a;
            //a = b;
            //b = t;

            //Console.Write("a : " + a + "b : " + b);
            //1차원을 2차원for 문을 이용해서 찍는 방법
            //1차원에 1~25라는 숫자가 들어가있다는것은 0부터 24의 인덱스를 가지고있음


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //int[] iArray = new int[25];
            //for (int i = 0; i < 25; i++)
            //{
            //    iArray[i] = i + 1;
            //}
            //Random rnd = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    int iA = rnd.Next(0, 25);
            //    int iB = rnd.Next(0, 25);
            //    int iT = 0;

            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int input = 0;
            //int iBingo = 0;
            //int iCount = 0;
            //while (true)
            //{
            //    Console.Clear();

            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            { Console.Write(" * "); }
            //            else
            //            { Console.Write(iArray[i * 5 + j].ToString("D2") + " "); }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("빙고 숫자 : " + iBingo);
            //    Console.WriteLine("숫자를 입력하세요: ");
            //    input = int.Parse(Console.ReadLine());
            //    iBingo = 0;
            //    for (int i = 0; i < 25; i++)
            //    {

            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }
            //    //가로체크
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                ++iCount;
            //            }
            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }
            //    //세로체크
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i + 5 * j] == 0)
            //            {
            //                ++iCount;
            //            }
            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }
            //    //대각선 오른쪽

            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 4 + 4] == 0)
            //        {
            //            ++iCount;
            //        }
            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;
            //    //대각선 왼쪽
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 6] == 0)
            //        {
            //            ++iCount;
            //        }
            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    if (iBingo >= 5)
            //    {
            //        Console.WriteLine("빙고입니다.");
            //    }

            //}
            #endregion

            #region 빙고튜플

            int[,] board = new int[5, 5];
            bool[,] marked = new bool[5, 5];
            int BingoCount = 0;
            Random randomBingo = new Random();

            int[] numbers = new int[25];
            for (int i = 0; i < 25; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < 100; i++)
            {
                int a = randomBingo.Next(25);
                int b = randomBingo.Next(25);
                //튜플 문법을 이용하여 두 변수의 값을 교환 하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }
            //2차원 배열로 변환
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }
            while (BingoCount < 5)
            {
                Console.Clear();

                Console.WriteLine("현재빙고판");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {BingoCount}");
                Console.Write("숫자를 입력하세요 1~25 : ");

                int number = int.Parse(Console.ReadLine());
                bool found = false;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true;
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
                //빙고 개수 체크
                BingoCount = 0;
                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                    {
                        if (!marked[i, j])
                            rowBingo = false;

                    }
                    if (rowBingo)
                    {
                        BingoCount++;
                    }
                }

                for (int j = 0; j < 5; j++)
                {
                    bool coliBingo = true;
                    for (int i = 0; i < 5; i++)
                    {
                        if (!marked[i, j]) coliBingo = false;

                    }
                    if (coliBingo) BingoCount++;
                }
                bool diag1Bingo = true;
                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, i])
                    {
                        diag1Bingo = false;
                    }

                    
                }
                if (diag1Bingo) BingoCount++;
                bool diag2Bingo = true;
                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, 4 - i])
                    {
                        diag2Bingo = false;
                    }


                }
                if (diag2Bingo) BingoCount++;

                Console.WriteLine("End");

            }
            #endregion

            #region 메모리


            #endregion

        }
    }
}
