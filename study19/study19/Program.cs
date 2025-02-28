using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace study19
{
    class Person
    {
        public string Name;
        public int Age;
        //기본생성자
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //클래스와 같은 이름가치이며 반환형이 없다. void도 사용안함
        //객체를 만들때 필요한 초기값을 설정할때 사용 많이함
        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("기본 생성자가 실행됨");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        }
    }

    class Marin
    {
        public string Name;
        public int Mineral;
        public Marin()
        {
            Name = "마린";
            Mineral = 50;
        }
        public Marin(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");

        }
    }
    class SCV
    {
        public string Name;
        public int Scv;
        public SCV()
        {
            Name = "SCV";
            Scv = 50;
        }
        public SCV(string name, int mineral)
        {
            Name = name;
            Scv = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Scv}");

        }
    }
    class BARRACK
    {
        public string Name;
        public int Barrack;
        public BARRACK()
        {
            Name = "베럭";
            Barrack = 150;
        }
        public BARRACK(string name, int barrack)
        {
            Name = name;
            Barrack = barrack;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Barrack}");

        }
    }
    //미네랄클래스
    //Mineral 1500

    class Mineral
    {
        public int MineralCount;

        public Mineral()
        {
            MineralCount = 1500;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : {MineralCount}");
        }

    }

    //Game클래스를 만들어보자

    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {charCount}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();

            Marin marin = new Marin("불꽃테란", 100);
            SCV scv = new SCV("열받은SCV", 70);
            BARRACK barrack = new BARRACK();
            Mineral[] mineral = new Mineral[7];
            for (int i = 0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }


            marin.ShowInfo();

            scv.ShowInfo();
            barrack.ShowInfo();


        }
    }
}
