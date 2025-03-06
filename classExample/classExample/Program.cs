using System;
using System.Collections.Generic;

namespace classExample
{
    class Cookie
    {
        public string Name { get; set; }
        public string SkillType { get; set; }
        public int Cooldown { get; set; }
        public int LastUsedTime { get; set; }
        public string Grade { get; set; }
        public int Combat { get; set; }

        public Cookie()
        {
            Name = "Test";
            SkillType = "";
            Cooldown = 0;
            Grade = "";
            Combat = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}가 공격합니다.");
        }
        public virtual void Skilltype()
        {
            Console.WriteLine($"{Name}은 {SkillType}입니다.");
        }
        public virtual void Heal(Cookie target)
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다.");
        }
        public virtual void Cooltime()
        {
            Console.WriteLine($"{Name}의 스킬 사용 쿨타임은 {Cooldown}입니다.");
        }
        public virtual void GradeCheck()
        {
            Console.WriteLine($"{Name}의 등급은 {Grade}입니다.");
        }
        public virtual void CombatCheck()
        {
            Console.WriteLine($"{Name}의 전투력은 {Combat}입니다.");
        }

    }

    class Shadow : Cookie
    {
        public Shadow()
        {
            Name = "쉐도우밀크쿠키";
            SkillType = "마법형";
            Cooldown = 11;
            Grade = "BEAST";
            Combat = 844189;
        }
        public override void Attack()
        {
            Console.WriteLine($"{Name}가 거짓의 연극을 펼칩니다.");
        }
        public override void Cooltime()
        {
            base.Cooltime();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cookie> cookies = new List<Cookie>();
            cookies.Add(new Shadow());

            foreach (var cookie in cookies)
            {
                cookie.Attack();
                cookie.Cooltime();
                cookie.GradeCheck();
                cookie.CombatCheck();
                Console.WriteLine();

            }
        }
    }
}
