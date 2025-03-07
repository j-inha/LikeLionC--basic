using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieRPG
{
    class Monster
    {
        public INFO m_tMonster;
        public void setDamage(int iAttack)
        {
            m_tMonster.iHp -= iAttack;
        }
        public void SetMonster(INFO tMonser) { m_tMonster = tMonser; }
        public INFO GetMonster() { return m_tMonster; }
        public void Render()
        {
            Console.WriteLine("。✯ ＼｜／。✯ ＼ ｜ ／✯ 。✯ ＼ ｜ ／✯ 。");
            Console.WriteLine("몬스터 이름 : "+m_tMonster.Name);
            Console.WriteLine("체력 : "+m_tMonster.iHp + "\t공격력 : " +m_tMonster.iAttack);
        }
    }
}
