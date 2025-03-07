using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action1
{
     //델리게이트와 이벤트를 더 쉽게 만든 Action
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void ShowNotification()
        {
            Console.WriteLine("Caution!!");
        }
        //매개변수 있는 경우
        static void HelloWorld(string message)
        {
            Console.WriteLine($"New message {message}");
        }

        static void Main(string[] args)
        {
            //Action은 매개변수가 없고 반환값이 없는 메서드를 참조
            //메서드 이름을 변수에 저장한다고 생각하면 쉬움
            Action sayHello = SayHello;
            sayHello += ShowNotification;
            sayHello?.Invoke();

            Action<string> h = null;
            h += HelloWorld;
            h?.Invoke("variable check");
            //람다식
            Action noti = null;
            //매개변수가 없는 람다식
            noti += () => Console.WriteLine("Lambda Expression");
            noti?.Invoke();
            Action<int> Square = number => Console.WriteLine(number * number);
            Square(5);

        }
    }
}
