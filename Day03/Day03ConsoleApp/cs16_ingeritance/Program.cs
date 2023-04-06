using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs16_ingeritance
{
    class Base // 부모클래스
    {   // 자식 클래스에서 상속을 받으려면 private는 안 쓰는게 좋음
        protected string Name;
        private string Color; // 만약 상속을 하려면 private를 protected로 변경해 주어야 함
        public int Age;

        public Base(string Name, string Color, int Age)
        { 
            this.Name = Name; this.Color = Color; this.Age = Age;
            Console.WriteLine("{0}.Base()", Name);
        }

        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()", Name);
        }

        public string GetColor()
        {
            return Color;
        }

    class Child : Base // 상속 받은 이후 Base의 Name, Color, Age를 새로 만들거나 하지 않음
    {
        public Child(string Name, string Color, int Age) : base(Name, Color, Age) 
        {
            Console.WriteLine("{0}.Child()", Name);
        }
            public void ChildMethod()
            {
                Console.WriteLine("{0}.ChildMethod()", Name);
            }

            public string GetColor()
            {
                return Color;
            }
    }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base("NameB", "White", 1);
            b.BaseMethod();

            Child c = new Child("NameC", "Black", 2);
            c.BaseMethod();
            c.ChildMethod();
        }
    }
}
