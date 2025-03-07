using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DelicateEvent
//{
//    class Program
//    {
//        delegate void MessageHandler(string message);
//        static void DisplayMessage(string message)
//        {
//            Console.WriteLine(message);
//        }
//        static void DisplayMessageUpper(string message)
//        {
//            Console.WriteLine(message.ToUpper());
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("예제");

//            MessageHandler messageHandler = DisplayMessage;
//            messageHandler("hello");
//            messageHandler += DisplayMessageUpper;
//            messageHandler("Today, I love you");
//        }

//    }
//}

namespace Event
{
    class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public event EventHandler OnDamaged;
        //생성자
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }
        //메서드
        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은체력 : {Health}");
            //EventArgs.Empty는 추가 데이터가 없을 때 사용하는 빈 이벤트 인자
            OnDamaged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {

        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            //sender > character 타임으로 변환
            Character character = (Character)sender;
            Console.WriteLine($"Notice : {character.Name}가 데미지를 입었습니다.! " +
                $"현재 체력 : {character.Health}");

        }
        static void Main(string[] args)
        {
            Character hero = new Character("쉐도우밀크쿠키", 100);
            //이벤트 구독 +=
            //이벤트가 발생했을때 실행될 메서드 등록
            hero.OnDamaged += Hero_OnDamaged;

            //데미지 입히기
            //TakeDamage 메서드 내에서 OnDamaged 이벤트가 발생함
            hero.TakeDamage(30);

            hero.OnDamaged -= Hero_OnDamaged;
            Console.WriteLine("이벤트 발생 취소");
            hero.TakeDamage(20); // 이벤트 발생함수는 실행하지만 내용은 실행 안함

        }
    }
}
