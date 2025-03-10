﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SkillSystemStudy
{
    class Skill
    {
        public string Name { get; set; }
        public int ManaCost { get; set; }
        public int Cooldown { get; set; }
        public int LastUsedTime { get; set; }

        public Skill(string name, int manaCost, int cooldown)
        {
            Name = name;
            ManaCost = manaCost;
            Cooldown = cooldown * 1000;
            LastUsedTime = 0;
        }
        public bool CanUse(int playerMana)
        {
            int currenTime = Environment.TickCount;
            if (playerMana < ManaCost)
            {
                Console.WriteLine($"마나가 부족합니다! 필요마나 : {ManaCost}");
                return false;
            }
            if (currenTime - LastUsedTime < Cooldown)
            {
                int remainingTime = (Cooldown - (currenTime - LastUsedTime)) / 1000;
                Console.WriteLine($"{Name} 스킬은 아직 사용할 수 없습니다. 남은시간 {remainingTime}");
                return false;
            }
            return true;
        }
        public void Use(ref int playerMana)
        {
            if (!CanUse(playerMana)) return;
            
                playerMana -= ManaCost;
                LastUsedTime = Environment.TickCount;

                Console.WriteLine($"{Name} 스킬 사용! MP - {ManaCost}");
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int playerMana = 200;
            Skill[] skills = new Skill[]
            {
                new Skill("파이어볼",20,3),
                new Skill("얼음창",15,2),
                new Skill("힐링",30,5),
            };

            while (true)
            {

                Console.Clear();
                Console.WriteLine($"현재 마나 : {playerMana}");
                Console.WriteLine("사용 가능한 스킬: ");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {skills[i].Name} MP : {skills[i].ManaCost}"+
                        $"쿨다운 {skills[i].Cooldown / 1000}s");
                    Console.WriteLine("0.종료");
                    Console.WriteLine("사용할 스킬 번호를 입력하세요: ");

                    try
                    {
                        int skillIndex = int.Parse(Console.ReadLine());
                        if (skillIndex == 0) break;
                        if(skillIndex >0 && skillIndex <= skills.Length)
                        {
                            skills[skillIndex - 1].Use(ref playerMana);
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("숫자를 입력하세요!");
                    }
                    Thread.Sleep(500);


                }
                Console.WriteLine("게임종료");
            }
        }
    }
}
