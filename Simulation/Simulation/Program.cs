﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;

namespace Simulation
{
    internal class Program
    {          //자물쇠 파트 랜덤함수 사용해서 만들기 - 배열사용 배열1(표시된글자의 배열) 아스키 아트로 숫자표시 배열2(플레이어가입력한값) 배열1과 배열2가 일치할때 자물쇠풀리는 방식
        static void Main(string[] args)
        {
            AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //title
            Thread.Sleep(1000);
            Console.WriteLine("███████╗██╗   ██╗██████╗ ██╗   ██╗██╗██╗   ██╗███████╗    ██████╗ ██╗      █████╗ ███╗   ██╗███████╗████████╗\r\n██╔════╝██║   ██║██╔══██╗██║   ██║██║██║   ██║██╔════╝    ██╔══██╗██║     ██╔══██╗████╗  ██║██╔════╝╚══██╔══╝\r\n███████╗██║   ██║██████╔╝██║   ██║██║██║   ██║█████╗      ██████╔╝██║     ███████║██╔██╗ ██║█████╗     ██║   \r\n╚════██║██║   ██║██╔══██╗╚██╗ ██╔╝██║╚██╗ ██╔╝██╔══╝      ██╔═══╝ ██║     ██╔══██║██║╚██╗██║██╔══╝     ██║   \r\n███████║╚██████╔╝██║  ██║ ╚████╔╝ ██║ ╚████╔╝ ███████╗    ██║     ███████╗██║  ██║██║ ╚████║███████╗   ██║   \r\n╚══════╝ ╚═════╝ ╚═╝  ╚═╝  ╚═══╝  ╚═╝  ╚═══╝  ╚══════╝    ╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝   ╚═╝   \r\n                                                                                                             ");
            Console.ReadLine();
            Console.Clear();

            #region 로딩창

            string art =
           "██╗  \n" +
           "╚██╗ \n" +
           " ╚██╗\n" +
           " ██╔╝\n" +
           "██╔╝ \n" +
           "╚═╝  \n" +
           "     ";

            string[] lines = art.Split('\n'); // 각 줄을 분리

            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");
            Console.WriteLine(art);
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");
            int repeatCount = 4;
            for (int i = 0; i < lines.Length; i++) // 마지막 빈 줄 제외
            {
                // 각 줄을 가로로 붙여서 출력
                for (int j = 0; j < repeatCount; j++)
                {
                    Console.Write(lines[i] + "  ");

                } // 줄바꿈
                
                Console.WriteLine();
            }
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");
            int repeatCount2 = 7;
            for (int i = 0; i < lines.Length; i++) // 마지막 빈 줄 제외
            {
                // 각 줄을 가로로 붙여서 출력
                for (int j = 0; j < repeatCount2; j++)
                {
                    Console.Write(lines[i] + "  ");

                } // 줄바꿈

                Console.WriteLine();

            }
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("'##::::::::'#######:::::'###::::'########::'####:'##::: ##::'######:::\r\n ##:::::::'##.... ##:::'## ##::: ##.... ##:. ##:: ###:: ##:'##... ##::\r\n ##::::::: ##:::: ##::'##:. ##:: ##:::: ##:: ##:: ####: ##: ##:::..:::\r\n ##::::::: ##:::: ##:'##:::. ##: ##:::: ##:: ##:: ## ## ##: ##::'####:\r\n ##::::::: ##:::: ##: #########: ##:::: ##:: ##:: ##. ####: ##::: ##::\r\n ##::::::: ##:::: ##: ##.... ##: ##:::: ##:: ##:: ##:. ###: ##::: ##::\r\n ########:. #######:: ##:::: ##: ########::'####: ##::. ##:. ######:::\r\n........:::.......:::..:::::..::........:::....::..::::..:::......::::");
            int repeatCount3 = 10;
            for (int i = 0; i < lines.Length; i++) // 마지막 빈 줄 제외
            {
                // 각 줄을 가로로 붙여서 출력
                for (int j = 0; j < repeatCount3; j++)
                {
                    Console.Write(lines[i] + "  ");

                } // 줄바꿈

                Console.WriteLine();

            }
            Thread.Sleep(300);
            Console.Clear();


            #endregion 로딩창
            #region 메테오

            string meteoart =
                
"⣗⡽⣽⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⡿⡿⡻⡽⡽⣽⢽⣽⣯⣿⣿⣿⡿⡿⡿⢿⣟⡿⣟⣿⣻⣿⢿⣿⢿⣿⢿⡿⣿⣽⣢⢇\n" +
"⡳⣯⢿⣽⣷⣿⣟⣿⣯⣿⣟⣿⡽⡯⣛⢪⢸⡸⡵⣽⢵⣻⣿⡿⣿⣿⡽⢏⢃⢇⢥⣡⣣⣷⢷⣿⣿⡿⣟⣿⢿⡽⣻⢵⢯⣟⣿⢾⣿⣿\n" +
"⣝⢯⣿⣷⣿⣷⣿⣿⡟⢝⣭⣖⢮⢪⢶⣵⢷⣻⣟⣿⣿⣿⡿⣿⡿⣷⢿⡰⡝⣜⣵⣳⣿⣟⡿⣿⣽⢿⡛⡍⣎⢮⡳⣯⢿⣽⣾⣿⣿⣽\n" +
"⣜⢮⢾⣷⣿⣿⣽⣷⣏⡯⣗⣽⣵⡿⣿⣽⣟⣿⣿⣟⣯⣷⣿⡿⣟⣯⢿⣺⣽⢿⡽⡯⡳⡽⣽⠗⢅⢕⠌⣜⢼⢮⡿⣽⢿⣟⣿⣯⢷⣻\n" +
"⣿⣽⢻⣺⣷⣿⣿⣿⣿⣿⣿⢿⣯⣿⣿⡿⣿⣿⣻⣿⣿⡿⣟⡯⣟⣞⡯⣟⡾⡻⡺⡸⡚⠹⡡⠨⢁⢆⡝⡮⣿⣽⢿⣽⣿⣟⡯⡋⡇⡗\n" +
"⣿⣿⣷⣿⢿⣻⣽⣷⣟⣷⣿⣿⣿⣿⢿⣿⣿⣿⡿⣿⣷⢿⢯⡫⣞⣞⠝⠌⡂⠣⠃⠅⠂⠁⠄⡢⢪⣚⢮⣿⢿⣾⣿⣿⡻⠨⡰⠸⡨⠪\n" +
"⣿⣳⣿⣾⡿⣟⣿⣾⣿⣿⣿⣿⣯⣿⣿⣿⣿⣾⣿⣿⢯⢯⡳⢹⠊⠀⢀⠁⢔⢈⠊⡐⠀⢀⠡⡢⡧⣗⣯⢿⣻⣽⣿⠽⠠⣳⣸⣸⢰⢽\n" +
"⣿⣿⣿⣷⣿⣿⢿⣽⣿⢿⣷⣿⣿⢿⣟⣯⣿⣿⣽⣾⣫⡳⠑⢁⠀⡡⢠⢵⡱⣔⠜⠀⢔⢰⢝⢮⢯⡳⡯⣿⢿⣿⣯⡇⣸⣺⡷⣇⢷⣿\n" +
"⣿⣯⣷⣿⣿⣯⣿⣾⣿⣿⣿⣟⣿⣿⣿⣿⣿⢿⣻⣞⠎⢐⠀⠆⣌⡾⣕⣷⣭⡗⡅⢎⢢⡳⡽⡕⡗⡽⣽⣻⣿⣿⣻⣷⣳⣽⣫⣿⣻⣿\n" +
"⣯⣿⣿⣻⣽⣿⣽⣷⣿⣷⣿⣿⢿⣯⣿⣿⣾⣿⣿⡞⠌⢂⢣⣣⡷⣫⣿⣽⣾⡺⢨⡪⣗⢝⢎⢮⣞⣿⣻⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⡿\n" +
"⣿⢿⣾⣿⢿⣻⣿⣻⣿⣽⢿⡾⣿⣟⣿⢾⡿⣯⣷⡿⡈⡐⠕⡔⣽⣻⢯⣋⡾⡴⡻⣚⢘⢜⣜⡷⣯⣿⣻⣽⣿⣿⣾⣿⣿⣾⣿⣾⣿⣻\n" +
"⣟⣿⢿⣾⣿⡿⣟⣿⢽⢞⢯⢪⠳⡱⡫⢯⣻⣻⣽⢷⣡⣂⠡⡦⣗⢾⣟⡷⡽⡝⡍⣆⣧⡷⣟⣿⢯⣿⣻⣿⣻⣾⣿⣿⣾⣿⣯⣷⣿⣿\n" +
"⣽⣟⣿⣻⣾⣻⢯⢯⢫⠣⠣⢑⢈⢐⠑⡕⢕⢗⢯⣟⡿⣞⡧⡩⡯⢟⠷⣙⣪⢮⣾⣷⡿⣿⣻⣯⣿⣿⣻⣿⣿⣿⣿⣽⢿⣞⣷⣿⣿⣿\n" +
"⢾⠯⡗⠯⡚⡪⢃⠣⠡⠁⠁⠂⡀⠂⠡⠨⠨⠊⢇⠗⡏⡟⡗⣟⢽⢷⡻⡿⣽⢿⣻⣾⢿⣿⢿⣟⣿⣽⣿⣿⣷⣿⡻⡾⣽⣿⢿⣿⣿⣾\n" +
"⠁⠁⠁⠁⠀⠀⠀⠀⠀⡀⠁⡀⠠⠀⠁⡀⠈⡈⠠⠡⠊⡄⠑⡐⡅⠥⡱⠩⠪⠹⢪⢺⠹⡝⡯⡟⣟⣟⡿⡯⡷⡳⣝⣽⣟⣿⣿⣿⣟⣿\n" +
"⠀⠀⠂⡀⡂⡈⡀⡁⠄⠄⠂⠠⠐⡀⢁⠄⠂⠠⢀⠔⢈⠐⠨⡨⢔⢤⡄⣔⢄⠌⣐⢳⣱⡰⣌⡊⡆⡎⢎⢊⢂⢇⢷⡻⡿⣿⢿⣯⣿⣿\n" +
"⠀⠀⠁⠀⠠⢑⢨⢨⢪⢰⢨⢬⢲⢸⡘⡌⡊⡚⡔⢜⢔⢍⢕⢅⣕⣀⡉⠎⡏⢯⢺⣑⡳⣝⠲⢅⠇⢌⣆⢮⢪⣪⣲⡹⡪⣫⡫⣻⢽⢿\n" +
           "          ";
            string[] meteolines = meteoart.Split('\n'); // 각 줄을 분리
            Console.WriteLine("███╗███╗   ██╗███████╗██╗    ██╗███████╗███╗\r\n██╔╝████╗  ██║██╔════╝██║    ██║██╔════╝╚██║\r\n██║ ██╔██╗ ██║█████╗  ██║ █╗ ██║███████╗ ██║\r\n██║ ██║╚██╗██║██╔══╝  ██║███╗██║╚════██║ ██║\r\n███╗██║ ╚████║███████╗╚███╔███╔╝███████║███║\r\n╚══╝╚═╝  ╚═══╝╚══════╝ ╚══╝╚══╝ ╚══════╝╚══╝\r\n                                            ");
            for (int j = 0; j < meteolines.Length-1; j++)
            {
                Console.WriteLine(meteolines[j]);
                Thread.Sleep(100);
            }
            Console.ReadLine();
            Console.Clear();


            #endregion
            #region 로보아트
            string roboart =
        "⠀⠀⢀⠀⢀⠀⡀⢀⠀⡀⢀⠀⡀⠀⠀⠀⠀⠀⠀\n" +
        "⢀⡞⠀⠀⣾⣻⢽⢯⢿⢽⣫⢿⢽⠯⡿⣽⣆⠁⠘⣇\n" +
        "⢸⡅⠀⢹⡽⣞⠕⠔⣟⣽⢽⣽⡣⢱⢸⣗⣯⠀⠀⣻⡄\n" +
        "⢸⡇⠀⢼⢯⣿⡨⠱⣽⣺⣽⢾⡕⡑⣼⣻⢾⠈⠄⣺⠅\n" +
        "⠘⣇⠌⠐⢿⣺⣽⢿⣽⣳⣯⢿⡽⣯⣷⣻⠏⠌⠄⡿⠀\n" +
        "⠀⠈⠀⡑⡈⠄⢂⠡⠐⡀⢂⠡⠈⢄⠐⠠⡁⠅⠊⠀⠀\n" +
        "⠀⠀⠀⣴⠐⠌⠂⠆⢕⠰⡐⢌⢌⢂⠊⡂⠂⡆⠀⠀⠀⠀\n" +
        "⠀⠀⠀⢹⠀⠀⡀⠂⠀⢀⠀⢀⠀⠀⡀⠠⢸⠃⠀⠀⠀⠀⠀\n" +
        "⠀⠀⠄⠡⠂⡂⠄⡀⠈⠀⠀⡀⠠⢀⠂⠌⠐⠔⠀⠐⠀⠀\n" +
        "⠐⠀⢌⠂⠀⢐⠐⡠⠡⠁⠅⡐⡈⠄⠌⠈⠀⠁⠅⡀⠐⠀\n" +
        "⠴⡐⠨⠨⡄⠀⠀⠀⠁⡔⡨⠈⠔⢐⢐⡁⠁⠀⠀⠈⣆⠂⡂⢌⠆\n" +
        "⡕⡇⠋⠀⠃⠀⠀⠀⠀⠈⠛⠻⠟⠏⠋⠀⠀⠀⠀⠀⠉⠀⠋⠙⠀\n" +
        "⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⡠\n" +
        "                \n";
            #endregion
            #region 실내챕터
            robowork.robowork.roboW("로봇을 발견했습니다. 버튼을 누르면 !확률적으로! 작동합니다.", "");
            Console.ReadLine();
            Console.Clear();
            randomdoor.randomdoor.rd();
            text.texts.sentence("\"안녕하세요. 저는 당신의 안전을 책임지는 생활로봇 로보라고 합니다.\"", "");
            Console.ReadLine();
            Console.Clear();

            text.texts.sentence("\"현재 운석이 충돌하여 위급상황입니다.\"", "");
            Console.ReadLine();
            Console.Clear();
            text.texts.sentence("\"당신이 생존하실 수 있게 제가 도와 드리겠습니다.\"", "");
            Console.ReadLine();
            Console.Clear();
            text.texts.sentence("\"제가 드리는 선택지를 신중하게 고르세요.", "잘못된 것을 고를시 책임지지 않습니다.\"");
            Console.ReadLine();
            Console.Clear();

            text.texts.sentence("\"우선 식량부터 확보합시다.\"", "");
            Console.ReadLine();
            Console.Clear();
            text.texts.sentence("\"어디로 가시겠습니까?.\"", "1.식당     2.창고");
            string choice = Console.ReadLine();
            Console.Clear();
            if (choice == "1")
            {
                text.texts.sentence("식당을 선택하셨습니다.", "물과 빵을 얻었습니다.");

            }
            else if (choice == "2")
            {
                text.texts.sentence("창고를 선택하셨습니다.", "통조림과 라면을 얻었습니다.");

            }
            else
            {
                textdead.textsdead.deadsen("식량을 확보하지 못했습니다. 당신은 죽었습니다.", "");
                Environment.Exit(0);
            }
            Console.ReadLine();
            Console.Clear();
            text.texts.sentence("\"아직 가보지 않은 곳이 있습니다.\"", "");
            Console.ReadLine();
            Console.Clear();
            text.texts.sentence("\"어디를 가시겠습니까?\"", "1. 화장실     2. 침실");
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                text.texts.sentence("화장실을 선택하셨습니다.", "휴지와 수건을 얻었습니다.");
                Console.ReadLine();
            }
            else if (choice2 == "2")
            {
                text.texts.sentence("침실을 선택하셨습니다.", "자세히 보니 옷장과 서랍이 있습니다.");
                Console.ReadLine();
                Console.Clear();
                text.texts.sentence("\"어느 곳을 확인하겠습니까?\"", "1.옷장     2.서랍");
                string choice3 = Console.ReadLine();
                Console.Clear();
                if (choice3 == "1")
                {
                    text.texts.sentence("옷장을 선택하셨습니다.", "여벌옷을 챙겼습니다.");
                }
                else if (choice3 == "2")
                {
                    text.texts.sentence("서랍을 선택하셨습니다.", "커터칼과 라이터를 챙겼습니다.");
                }

                else
                {
                    textdead.textsdead.deadsen("쓸만한 것을 찾지 못한 당신은 살아남지 못합니다.", "");
                    Environment.Exit(0);
                }
            }

            else
            {
                textdead.textsdead.deadsen("식량만 챙긴 당신은 밤에 추위에 얼어죽었습니다.", "");
                Environment.Exit(0);
            }
            Console.ReadLine();

            Console.Clear();
            text.texts.sentence("\"필요한 건 다 챙겼습니다. 밖으로 나가 봅시다.\"", "");
            Console.ReadLine();
            Console.Clear();
            text.texts.sentence("\"문에 자물쇠가 있습니다. 기회는 10번 뿐입니다.\"", "당신은 비밀번호를 아무거나 넣기 시작했습니다.");
            Console.ReadLine();
            Console.Clear();
            randomlock.randomlock.rdl();
            Console.ReadLine();
            Console.Clear();
            #endregion
            text.texts.sentence("부디 살아남으시길 바랍니다.", "");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(5, 2);
            endimage.endanim.endPlay();
        }
    }
}




namespace text
{
    class texts
    {
        public static void sentence(string text,string text2) {
            string roboart =
        "⠀ ⢀⠀⢀⠀⡀⢀⠀⡀⢀⠀⡀⠀⠀⠀⠀⠀⠀\n" +
        "⢀⡞⠀⠀⣾⣻⢽⢯⢿⢽⣫⢿⢽⠯⡿⣽⣆⠁⠘⣇\n" +
        "⢸⡅⠀⢹⡽⣞⠕⠔⣟⣽⢽⣽⡣⢱⢸⣗⣯⠀⠀⣻⡄\n" +
        "⢸⡇⠀⢼⢯⣿⡨⠱⣽⣺⣽⢾⡕⡑⣼⣻⢾⠈⠄⣺⠅\n" +
        "⠘⣇⠌⠐⢿⣺⣽⢿⣽⣳⣯⢿⡽⣯⣷⣻⠏⠌⠄⡿⠀\n" +
        "⠀⠈⠀⡑⡈⠄⢂⠡⠐⡀⢂⠡⠈⢄⠐⠠⡁⠅⠊⠀⠀\n" +
        "⠀⠀⠀⣴⠐⠌⠂⠆⢕⠰⡐⢌⢌⢂⠊⡂⠂⡆⠀⠀⠀⠀\n" +
        "⠀⠀⠀⢹⠀⠀⡀⠂⠀⢀⠀⢀⠀⠀⡀⠠⢸⠃⠀⠀⠀⠀⠀\n" +
        "⠀⠀⠄⠡⠂⡂⠄⡀⠈⠀⠀⡀⠠⢀⠂⠌⠐⠔⠀⠐⠀⠀\n" +
        "⠐⠀⢌⠂⠀⢐⠐⡠⠡⠁⠅⡐⡈⠄⠌⠈⠀⠁⠅⡀⠐⠀\n" +
        "⠴⡐⠨⠨⡄⠀⠀⠀⠁⡔⡨⠈⠔⢐⢐⡁⠁⠀⠀⠈⣆⠂⡂⢌⠆\n" +
        "⡕⡇⠋⠀⠃⠀⠀⠀⠀⠈⠛⠻⠟⠏⠋⠀⠀⠀⠀⠀⠉⠀⠋⠙⠀\n" +
        "⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⡠\n" +
        "                \n";
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(
                roboart +
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                     \r\n" +
                "                                                                     \r\n" +
                $" {text}                       \r\n" +
                $" {text2}                                                                    \r\n" +
                "                                                                     \r\n" +
                "┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");



        }
    }
}
namespace robowork
{
    class robowork
    {
        public static void roboW(string text, string text2)
        {
            string roboart =
        "⠀ ⢀⠀⢀⠀⡀⢀⠀⡀⢀⠀⡀⠀⠀⠀⠀⠀⠀\n" +
        "⢀⡞⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣽⣆⠁⠘⣇\n" +
        "⢸⡅⠀⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣗⣯⠀⠀⣻⡄\n" +
        "⢸⡇⠀⢼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣻⢾⠈⠄⣺⠅\n" +
        "⠘⣇⠌⠐⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠌⠄⡿⠀\n" +
        "⠀⠈⠀⡑⡈⠄⢂⠡⠐⡀⢂⠡⠈⢄⠐⠠⡁⠅⠊⠀⠀\n" +
        "⠀⠀⠀⣴⠐⠌⠂⠆⢕⠰⡐⢌⢌⢂⠊⡂⠂⡆⠀⠀⠀⠀\n" +
        "⠀⠀⠀⢹⠀⠀⡀⠂⠀⢀⠀⢀⠀⠀⡀⠠⢸⠃⠀⠀⠀⠀⠀\n" +
        "⠀⠀⠄⠡⠂⡂⠄⡀⠈⠀⠀⡀⠠⢀⠂⠌⠐⠔⠀⠐⠀⠀\n" +
        "⠐⠀⢌⠂⠀⢐⠐⡠⠡⠁⠅⡐⡈⠄⠌⠈⠀⠁⠅⡀⠐⠀\n" +
        "⠴⡐⠨⠨⡄⠀⠀⠀⠁⡔⡨⠈⠔⢐⢐⡁⠁⠀⠀⠈⣆⠂⡂⢌⠆\n" +
        "⡕⡇⠋⠀⠃⠀⠀⠀⠀⠈⠛⠻⠟⠏⠋⠀⠀⠀⠀⠀⠉⠀⠋⠙⠀\n" +
        "⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⡠\n" +
        "                \n";
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(
                roboart +
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                     \r\n" +
                "                                                                     \r\n" +
                $" {text}                       \r\n" +
                $" {text2}                                                                    \r\n" +
                "                                                                     \r\n" +
                "┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");



        }
    }
}

namespace textdead
{
    class textsdead
    {
        public static void deadsen(string dtext, string dtext2)
        {
            string droboart =
        "⠀ ⢀⠀⢀⠀⡀⢀⠀⡀⢀⠀⡀⠀⠀⠀⠀⠀⠀\n" +
        "⢀⡞⠀⠀⣾⣻⢽⢯⢿⢽⣫⢿⢽⠯⡿⣽⣆⠁⠘⣇\n" +
        "⢸⡅⠀⢹⡽⣞⢿⣟⣽⢽⣽⢿⢸⣗⣯⢿⠀⣻⡄\n" +
        "⢸⡇⠀⢼⢯⣿⢿⢿⣽⣺⣽⢾⢿⣼⣻⢾⠈⠄⣺⠅\n" +
        "⠘⣇⠌⠐⢿⣺⣽⢿⣽⣳⣯⢿⡽⣯⣷⣻⠏⠌⠄⡿⠀\n" +
        "⠀⠈⠀⡑⡈⠄⢂⠡⠐⡀⢂⠡⠈⢄⠐⠠⡁⠅⠊⠀⠀\n" +
        "⠀⠀⠀⣴⠐⠌⠂⠆⢕⠰⡐⢌⢌⢂⠊⡂⠂⡆⠀⠀⠀⠀\n" +
        "⠀⠀⠀⢹⠀⠀⡀⠂⠀⢀⠀⢀⠀⠀⡀⠠⢸⠃⠀⠀⠀⠀⠀\n" +
        "                \n";
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(
                droboart +
                "┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ ♥ ┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓\r\n" +
                "                                                                     \r\n" +
                "                                                                     \r\n" +
                $" {dtext}                       \r\n" +
                $" {dtext2}                                                                    \r\n" +
                "                                                                     \r\n" +
                "┗ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┓ ♥ ┏ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┛ \r\n" +
                    "                                ");


        }
    }
}

namespace randomdoor
{
    class randomdoor
    {
        public static void rd()
        {
            Random rand = new Random();
            int eventChance = rand.Next(1,101);
            if (eventChance <= 70) 
            {
                text.texts.sentence("로봇이 작동합니다.", "");
                Console.ReadLine();
                Console.Clear();

            }
            else 
            {
                text.texts.sentence("로봇이 폭발했습니다. 당신은 죽었습니다.", "");
                Environment.Exit(0);

            }

        }
    }
}
namespace randomlock
{
    class randomlock
    {
        public static void rdl()
        {
            int count = 9;

            Random rand = new Random();
            for (int i = 0; i < 10; i++) 
            {
                int eventChance = rand.Next(1, 101);
                if(eventChance <= 30)
                {
                    text.texts.sentence("문을 열었습니다.", "밖으로 나가봅시다.");
                    break;
                }
                else
                {

                    if (count == 0)
                    {
                        textdead.textsdead.deadsen("문을 여는데 시간을 너무 쓴 당신은 죽고맙니다.", "");
                        Environment.Exit(0);

                    }
                    else 
                    {
                        text.texts.sentence("문을 여는데 실패했습니다.", $"앞으로 {count}번 남았습니다.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                }
                count = 8 - i;

            }
        }
    }
}

namespace endimage
{
    class endanim
    {
        public static void endPlay()
        {
            Console.WriteLine("   ▄██████▄   ▄██████▄   ▄██████▄  ████████▄        ▄█       ███    █▄   ▄████████    ▄█   ▄█▄ \r\n  ███    ███ ███    ███ ███    ███ ███   ▀███      ███       ███    ███ ███    ███   ███ ▄███▀ \r\n  ███    █▀  ███    ███ ███    ███ ███    ███      ███       ███    ███ ███    █▀    ███▐██▀   \r\n ▄███        ███    ███ ███    ███ ███    ███      ███       ███    ███ ███         ▄█████▀    \r\n▀▀███ ████▄  ███    ███ ███    ███ ███    ███      ███       ███    ███ ███        ▀▀█████▄    \r\n  ███    ███ ███    ███ ███    ███ ███    ███      ███       ███    ███ ███    █▄    ███▐██▄   \r\n  ███    ███ ███    ███ ███    ███ ███   ▄███      ███▌    ▄ ███    ███ ███    ███   ███ ▀███▄ \r\n  ████████▀   ▀██████▀   ▀██████▀  ████████▀       █████▄▄██ ████████▀  ████████▀    ███   ▀█▀ \r\n                                                   ▀                                 ▀         ");
        }
    }
}
