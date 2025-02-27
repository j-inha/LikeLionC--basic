using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Program
    {
        struct item
        {
            public int Count;
            public string Name;
            public item(string name, int count)
            {
                Name = name;
                Count = count;
            }
        }
        const int Max_ITEMS = 10;
        //아이템 배열 (이름저장)
        //static string[] itemNames = new string[Max_ITEMS];
        //static int[] itemCounts = new int[Max_ITEMS];
        static item[] inventory = new item[Max_ITEMS];
        //아이템 추가 함수
        static void AddItem(string name, int count)
        {
            for (int i = 0; i < Max_ITEMS; i++)
            {
                if (inventory[i].Name == name)//이미 있는 아이템이면 개수 증가
                {
                    inventory[i].Count += count;
                    return;
                }
            }
            //빈 슬롯에 새로운 아이템 추가
            for (int i = 0; i < Max_ITEMS; i++)
            {
                if (inventory[i].Name == null)
                {
                    inventory[i].Name = name;
                    inventory[i].Count = count;
                    return;
                }

            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }
        //static void AddItem(string name, int count)
        //{
        //    for (int i = 0; i < Max_ITEMS; i++)
        //    {
        //        if (itemNames[i] == name)//이미 있는 아이템이면 개수 증가
        //        {
        //            itemCounts[i] += count;
        //            return;
        //        }
        //    }
        //    //빈 슬롯에 새로운 아이템 추가
        //    for (int i = 0; i < Max_ITEMS; i++)
        //    {
        //        if (itemNames[i] == null)
        //        {
        //            itemNames[i] = name;
        //            itemCounts[i] = count;
        //            return;
        //        }

        //    }
        //    Console.WriteLine("인벤토리가 가득 찼습니다.");
        //}

        ////아이템 제거 함수
        //static void RemoveItem(string name, int count)
        //{
        //    for (int i = 0; i < Max_ITEMS; i++)
        //    {
        //        if (itemNames[i] == name)//이름하고 같은지
        //        {
        //            if (itemCounts[i] >= count)
        //            {
        //                itemCounts[i] -= count;
        //                if(itemCounts[i] == 0)
        //                {
        //                    itemNames[i] = null;
        //                }
        //                return;
        //            }
        //            else
        //            {
        //                Console.WriteLine("아이템 개수가 부족합니다!");
        //                return;
        //            }
        //        }
        //    }
        //    Console.WriteLine("아이템을 찾을 수 없습니다.");
        //}
        ////인벤토리 출력 함수
        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for (int i = 0; i < Max_ITEMS; i++)
            {
                if (inventory[i].Name != null)
                {
                    Console.WriteLine($"{inventory[i].Name} (X{inventory[i].Count}");
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }

        static void Main(string[] args)
        {
            //테스트 : 아이템추가
            AddItem("포션", 5);
            AddItem("칼", 1);

            ShowInventory();

        }
    }
}
