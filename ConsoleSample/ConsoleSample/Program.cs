using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Thread.Sleep(1000);
            #region
            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");

            Console.WriteLine(
                    "  /$$$$$$ \n" +
                    " /$$__  $$\n" +
                    "| $$  \\ $$\n" +
                    "| $$  | $$\n" +
                    "|  $$$$$$/\n" +
                    " \\______/ \n" +
                    "          ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");

            Console.WriteLine(
                    "  /$$$$$$    /$$$$$$ \r\n" +
                    " /$$__  $$  /$$__  $$\r\n" +
                    "| $$  \\ $$ | $$  \\ $$\r\n" +
                    "| $$  | $$ | $$  | $$\r\n" +
                    "|  $$$$$$/ |  $$$$$$/\r\n" +
                    " \\______/   \\______/ \r\n" +
                    "                     ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");

            Console.WriteLine(
                    "  /$$$$$$    /$$$$$$    /$$$$$$ \r\n" +
                    " /$$__  $$  /$$__  $$  /$$__  $$\r\n" +
                    "| $$  \\ $$ | $$  \\ $$ | $$  \\ $$\r\n" +
                    "| $$  | $$ | $$  | $$ | $$  | $$\r\n" +
                    "|  $$$$$$/ |  $$$$$$/ |  $$$$$$/\r\n" +
                    " \\______/   \\______/   \\______/ \r\n" +
                    "                                ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");

            string art =
           "  /$$$$$$ \n" +
           " /$$__  $$\n" +
           "| $$  \\ $$\n" +
           "| $$  | $$\n" +
           "|  $$$$$$/\n" +
           " \\______/ \n" +
           "          ";

            string[] lines = art.Split('\n'); // 각 줄을 분리

            for (int i = 0; i < lines.Length - 1; i++) // 마지막 빈 줄 제외
            {
                // 각 줄을 가로로 붙여서 출력
                Console.Write(lines[i] + "  " + lines[i] + "  " + lines[i] + "  " + lines[i]);
                Console.WriteLine(); // 줄바꿈

            }
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");

            string arts =
            "  /$$$$$$ \n" +
            " /$$__  $$\n" +
            "| $$  \\ $$\n" +
            "| $$  | $$\n" +
            "|  $$$$$$/\n" +
            " \\______/ \n" +
            "          ";

            string[] liness = art.Split('\n'); // 각 줄을 분리

            for (int i = 0; i < lines.Length - 1; i++) // 마지막 빈 줄 제외
            {
                // 각 줄을 가로로 붙여서 다섯 개 출력
                Console.Write(lines[i] + "  " + lines[i] + "  " + lines[i] + "  " + lines[i] + "  " + lines[i]);
                Console.WriteLine(); // 줄바꿈
            }
            Thread.Sleep(1000);
            Console.Clear();
            #endregion
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                     \r\n" +
                "                                                                     \r\n" +
                "                  현재 행성에 큰 운석이 부딪혔습니다.                \r\n" +
                "                                                                     \r\n" +
                "                                                                     \r\n" +
                "     ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");
            Console.ReadLine();
            Console.Clear();
           
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                    \r\n" +
                "                                                                    \r\n" +
                "                         우선 식량부터 확보합시다.                  \r\n" +
                "                                                                    \r\n" +
                "                                                                    \r\n" +
                "     ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");
            Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(5, 2);
            Console.WriteLine(
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                    \r\n" +
                "                                                                    \r\n" +
                "                         어디로 가시겠습니까?                       \r\n" +
                "                         1. 식당      2. 창고                       \r\n" +
                "                                                                    \r\n" +
                "     ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");
            string choice = Console.ReadLine();
            Console.Clear();
            
            if (choice == "1")
            {
                Console.SetCursorPosition(5, 2);
                Console.WriteLine(
                    " ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                    "                                                                     \r\n" +
                    "                                                                     \r\n" +
                    "                           식당을 선택하셨습니다.                    \r\n" +
                    "                            물과 빵을 얻었습니다.                    \r\n" +
                    "                                                                     \r\n" +
                    "     ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                        "                                ");
            }
            else if (choice == "2")
            {
                Console.SetCursorPosition(5, 2);
                Console.WriteLine(
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                    \r\n" +
                "                                                                    \r\n" +
                "                            창고을 선택하셨습니다.                  \r\n" +
                "                           통조림과 라면을 얻었습니다.              \r\n" +
                "                                                                    \r\n" +
                "     ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다. 1 또는 2를 선택하세요");
            }
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                    \r\n" +
                "                                  수많은                            \r\n" +
                "                              별똥별을 피해서                       \r\n" +
                "                               살아남으세요.                        \r\n" +
                "                                                                    \r\n" +
                "     ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                  \r\n" +
                "                                                                  \r\n" +
                "                             행운을 빕니다.                       \r\n" +
                "                                                                  \r\n" +
                "                                                                  \r\n" +
                "     ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");
            Console.ReadLine();
            Console.Clear();
        
            Study.MyProgram.Play();
        }
    }
}
namespace Study
{
    class MyProgram
    {
        public static void Play()
        {
            // 게임 시작
            // 타이틀 변경
            Console.Title = "별 피하기";
            // 콘솔 크기 변경
            Console.SetWindowSize(30, 30);
            // 콘솔창의 아래 중앙에 캐릭터가 위치하게 하는것
            // -> 콘솔의 x좌표 14, y좌표 28에 그려줘
            Console.SetCursorPosition(14, 28);
            Console.WriteLine(
                "( ｀Д´ ）"
                );

            // 콘솔 커서를 안보이게 해줘 C#언어 visual 2022 miscrosoft c#
            Console.CursorVisible = false;
            Random random = new Random();
            int x = 14, y = 28; //player position
            int Ex = random.Next(0, 28), Ey = 0; //Enemy position
            bool Enermy = false; //star alive : true / star dead : false

            //별이 다중으로 내려오게 하는 방법
            //int[] Exs = new int[] { random.Next(0, 28), random.Next(0, 28) };
            int[] Exs = new int[4];
            int[] Exy = new int[4];

            for (int i = 0; i < Exs.Length; i++)
            {
                Exs[i] = random.Next(0, 28);
            }
            for (int i = 0; i < Exy.Length; i++)
            {
                Exy[i] = 0;
            }


            while (true)
            {

                Console.Clear();
                Console.SetCursorPosition(x, y);
                // draw player position
                Console.WriteLine(
                "( ｀Д´ ）"
                    );

                //동작키
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ");

                    // change player position
                    if (key == ConsoleKey.UpArrow)
                    {
                        y--;
                        if (y < 0) y = 0;

                    }
                    if (key == ConsoleKey.W)
                    {
                        y--;
                        if (y < 0) y = 0;

                    }

                    //아래로이동
                    if (key == ConsoleKey.DownArrow)
                    {
                        y++;
                        if (y > 30) y = 30;

                    }
                    if (key == ConsoleKey.X)
                    {
                        y++;
                        if (y > 30) y = 30;

                    }

                    //왼쪽이동
                    if (key == ConsoleKey.LeftArrow)
                    {
                        x--;
                        if (x < 0) x = 0;

                    }
                    if (key == ConsoleKey.A)
                    {
                        x--;
                        if (x < 0) x = 0;

                    }
                    //오른쪽이동
                    if (key == ConsoleKey.RightArrow)
                    {
                        x++;
                        if (x > 30) x = 30;

                    }
                    if (key == ConsoleKey.D)
                    {
                        x--;
                        if (x < 0) x = 0;

                    }



                }
                //

                if (!Enermy)
                {
                    Enermy = true;
                }
                Console.SetCursorPosition(Ex, Ey);
                Console.Write("★");

                for (int i = 0; i < Exs.Length; i++)
                {
                    Console.SetCursorPosition(Exs[i], Exy[i]);
                    Console.Write("★");
                }

                if (Enermy)
                {
                    Ey = Ey + random.Next(0, 2);
                    for (int i = 0; i < 4; i++)
                    {
                        Exy[i] = Exy[i] + random.Next(0, 2); // 별들의 개별 속도 조절
                    }
                }
                //개별적으로 하늘에서 떨어지는 위치 정하기
                if (Ey >= 28)
                {
                    Enermy = false;
                    Ey = 0;
                    Ex = random.Next(0, 28);

                }
                for (int i = 0; i < Exs.Length; i++)
                {
                    if (Exy[i] >= 28)
                    {
                        Exs[i] = random.Next(0, 28);
                        Exy[i] = 0;
                    }
                }

                if (x == Ex && y == Ey)
                {
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("Game over");
                    break;
                }
                //배열 각각에 설정
                if (x == Exs[0] && y == Exy[0])
                {
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("Game over");
                    break;
                }
                if (x == Exs[1] && y == Exy[1])
                {
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("Game over");
                    break;

                }
                if (x == Exs[2] && y == Exy[2])
                {
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("Game over");
                    break;

                }
                if (x == Exs[3] && y == Exy[3])
                {
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("Game over");
                    break;
                }
                /*for (int i = 0; i < Exs.Length; i++)
                {
                    if (x == Exs[i] && y == Exy[i])
                    {
                        Console.SetCursorPosition(10, 15);
                        Console.WriteLine("Game over");
                        Thread.Sleep(50);
                        break;


                    }
                */





                //게임을 꺼버릴수도있고 다시 계속 재생할 수도 있음
                Thread.Sleep(50);
            }

            Console.ReadKey();
        }
    }
}

