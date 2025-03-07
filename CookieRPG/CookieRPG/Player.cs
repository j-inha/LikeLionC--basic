using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CookieRPG
{
    class Player
    {
        public INFO m_tInfo;
        public Color m_color;
        public void SetDamage(int iAttack) { m_tInfo.iHp -= iAttack; }
        public void SetSkillDamage(int skillAttack) { m_tInfo.iHp -= skillAttack; }
        public INFO GetInfo() { return m_tInfo; }
        public void SetHp(int iHp) { m_tInfo.iHp = iHp; }

        public void SelectJob()
        {
            m_tInfo = new INFO();
            {
                Console.WriteLine("함께할 쿠키를 선택하세요. 1. 쉐도우밀크 쿠키 2. 퓨어바닐라 쿠키 3. 골드치즈 쿠키 4. 버닝스파이스 쿠키");
                int iInput = 0;
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1)
                {
                    m_tInfo.Name = "쉐도우밀크 쿠키";
                    m_tInfo.iAttack = 40;
                    m_tInfo.iHp = 250;
                    m_tInfo.SkillName = "거짓의 장막";
                    m_tInfo.SkillAttack = 100;
                }
                else if (iInput == 2)
                {
                    m_tInfo.Name = "퓨어바닐라 쿠키";
                    m_tInfo.iAttack = 15;
                    m_tInfo.iHp = 300;
                    m_tInfo.SkillName = "모두를 위한 다짐";
                    m_tInfo.iHeal = 80;
                }
                else if (iInput == 3)
                {
                    m_tInfo.Name = "골드치즈 쿠키";
                    m_tInfo.iAttack = 30;
                    m_tInfo.iHp = 250;
                    m_tInfo.SkillName = "위대한 불멸의 왕";
                    m_tInfo.SkillAttack = 80;
                }
                else if (iInput == 4)
                {
                    m_tInfo.Name = "버닝스파이스 쿠키";
                    m_tInfo.iAttack = 25;
                    m_tInfo.iHp = 350;
                    m_tInfo.SkillName = "폭군의 분노";
                    m_tInfo.SkillAttack = 50;
                }
            }
        }
        public void Render()
        {
            Console.WriteLine("。✯ ＼｜／。✯ ＼ ｜ ／✯ 。✯ ＼ ｜ ／✯ 。");
            Console.WriteLine("쿠키 이름 : " + m_tInfo.Name);
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 : "+m_tInfo.iAttack);
        }
       
    }
}
