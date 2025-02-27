using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace shootinggame
{
    internal class Program
    {
        struct PlayerPosition
        {
            public int x;
            public int y;
            public PlayerPosition(int Playerx, int Playery)
            {
                x = Playerx; y = Playery;
                
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
            #region  방향키
            //while (true)
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("x");
            //    keyinfo = Console.ReadKey(true);

            //    //방향키 입력에 따른 좌표 변경
            //switch (keyinfo.Key)
            //{
            //    case ConsoleKey.UpArrow: if (y > 0) y--; break;
            //    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
            //    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
            //    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
            //    case ConsoleKey.Escape: return;
            //}


            //}
            #endregion
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] player = new string[]
            {
                "∧__∧",
                "( ｀Д´ ）",
                "(っ▄︻▇〓┳═☆",
                "/　　 )",
                "( /￣∪",

            };
            PlayerPosition Position;
            Position.x = 0;
            Position.y = 12;
            ConsoleKeyInfo keyinfo;
            Console.CursorVisible = false;

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초
            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기


                if (currentSecond - prevSecond >= 100)
                {

                    Console.Clear();
                    if (Console.KeyAvailable) //키가 눌렸을때 true
                    {
                        keyinfo = Console.ReadKey(true);
                        switch (keyinfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (Position.y > 0) Position.y--; break;
                            case ConsoleKey.DownArrow: if (Position.y < Console.WindowHeight - 1) Position.y++; break;
                            case ConsoleKey.LeftArrow: if (Position.x > 0) Position.x--; break;
                            case ConsoleKey.RightArrow: if (Position.x < Console.WindowWidth - 1) Position.x++; break;
                            case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                            case ConsoleKey.Escape: return;
                        }
                    }

                    for (int i = 0; i < player.Length; i++)
                    {

                        Console.SetCursorPosition(Position.x, Position.y + i);
                        Console.WriteLine(player[i]);
                    }

                    prevSecond = currentSecond;//이전 시간 업데이트
                }
            }
        }
    }
}
