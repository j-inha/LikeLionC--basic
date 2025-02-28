using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study21
{
    //값을 private 로 막았을때 사용법
    //class Person
    //{
    //    private string name;
    //    //값 설정하기 (setter)
    //    public void SetName(string newName)
    //    {
    //        name = newName;
    //    }
    //    //값 가져오기 (Getter)
    //    public string GetName()
    //    {
    //        return name;
    //    }

    //}


    //프로퍼티
    //class Person
    //{
    //    private string name;

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //}

    //자동구현프로퍼티
    class Person
    {
        public string Name { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {



            //Person p = new Person();
            //    p.Name = "Test";
            //    Console.WriteLine(p.Name);


            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //Person  p = new Person();
            //p.SetName("길동");
            //Console.WriteLine(p.GetName());

        }
    }
}
