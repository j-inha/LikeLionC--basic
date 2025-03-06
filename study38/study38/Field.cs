﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study38
{
    class Field
    {
        Player m_pPlayer = null;
        Monster m_pMonster = null;
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
        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();
            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;
            pMonster.SetMonster(tMonster);
        }
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1: Create("케이크 들개", 30, 4, out m_pMonster); break;
                case 2: Create("단단한 흑설탕 골렘", 60, 6, out m_pMonster); break;
                case 3: Create("레드벨벳 케이크 드래곤", 90, 9, out m_pMonster); break;
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
                Console.WriteLine("1.공격 2.후퇴 :");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);
                    if (m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }
                }
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
            Console.WriteLine("==============================");
            Console.WriteLine("맵을 선택하세요.");
        }

    }
}

