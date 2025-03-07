using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MainGame maingame = new MainGame();
            maingame.Initialize();
            maingame.Progress();
        }
    }
}
