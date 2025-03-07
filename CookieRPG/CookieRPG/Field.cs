using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieRPG
{
    class Field
    {
        Player m_pPlayer = null;
        Monster m_pMonster = null;
        public INFO m_tInfo;
        public void SetPlayer(ref Player pPlayer)
        {
            m_pPlayer = pPlayer;
        }
        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                DrawMap();
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 4) break;
                if (iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }
        public void Create(string Mname, int Mhp, int Mattack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();
            tMonster.Name = Mname;
            tMonster.iAttack = Mattack;
            tMonster.iHp = Mhp;
            pMonster.SetMonster(tMonster);
        }
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1: Create("케이크 들개", 30, 4, out m_pMonster); break;
                case 2: Create("진리의 은둔자", 300, 20, out m_pMonster); break;
                case 3: Create("미궁의 단죄자", 200, 30, out m_pMonster); break;
            }
        }
        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();
                Console.WriteLine("1. 공격  \t2.후퇴");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.setDamage(m_pPlayer.GetInfo().iAttack);
                    if (m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }
                }
                //if (iInput == 2)
                //{
                //    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                //    if (m_tInfo.Name == "퓨어바닐라 쿠키")
                //    {
                //        m_tInfo.iHp += m_tInfo.iHeal;
                //    }
                //    else m_pMonster.setDamage(m_pPlayer.GetInfo().SkillAttack);
                //}
                //if (iInput == 3 || m_pMonster.GetMonster().iHp <= 0)
                //{
                //    m_pMonster = null;
                //    break;
                //}
                if (iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
            }
        }
        public void DrawMap()
        {
            Console.WriteLine("1.크리스피 월드");
            Console.WriteLine("2.비스트이스트 월드");
            Console.WriteLine("3.오늘의 현상수배");
            Console.WriteLine("4.전단계");
            Console.WriteLine("⋆｡°✶⋆.༘⋆° ̥✩ ̥°̩̥·.°̩̥˚̩̩̥͙✩.˚｡⋆୨୧⋆｡˚·. ̥✩°̩̥‧̥·̊°ˎˊ✶˚ ༘✩*⋆｡˚⋆");
            Console.WriteLine("맵을 선택하세요.");
        }

    }
}
