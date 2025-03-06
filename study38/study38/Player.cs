using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study38
{
    class Player
    {
        public INFO m_tInfo;
        public void SetDamage(int iAttack) { m_tInfo.iHp -= iAttack; }
        public INFO GetInfo() { return m_tInfo; }
        public void SetHp(int iHp) { m_tInfo.iHp = iHp; }
        public void SetSkill(int sAttack) { m_tInfo.iHp -= sAttack; }

        public void SelectJob()
        {
            m_tInfo = new INFO();
            {
                Console.WriteLine("쿠키을 선택하세요 1.쉐도우밀크쿠키 2.퓨어바닐라쿠키 3.블랙사파이어쿠키");
                int iInput = 0;
                iInput = int.Parse(Console.ReadLine());
                switch (iInput)
                {
                    case 1:
                        m_tInfo.strName = "쉐도우밀크쿠키";
                        m_tInfo.iHp = 90;
                        m_tInfo.iAttack = 30;
                        break;
                    case 2:
                        m_tInfo.strName = "퓨어바닐라쿠키";
                        m_tInfo.iHp = 150;
                        m_tInfo.iAttack = 10;
                        break;
                    case 3:
                        m_tInfo.strName = "블랙사파이어쿠키";
                        m_tInfo.iHp = 100;
                        m_tInfo.iAttack = 15;
                        break;
                }

            }
        }
        public void Render()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("쿠키 이름 : " + m_tInfo.strName);
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 : " + m_tInfo.iAttack);
        }
        public Player() { }
        ~Player() { }
    }
}
