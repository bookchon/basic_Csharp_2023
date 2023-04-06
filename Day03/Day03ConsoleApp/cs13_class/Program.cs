using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs13_class
{
    class Cat // private이라도 같은 cs13_class 안에 있기 때문에 접근 가능
    {
        #region < 생성자>
        public Cat() 
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }
        #endregion

        // 사용자 지정 생성자
        public Cat(string name, string color, sbyte age)
        {
            Name = name;
            Color = color;
            Age = 0;
        }

        public Cat(string v1, string v2)
        {
        }

        #region < 멤버변수 - 속성 >
        public string Name; // 고양이 이름
        public string Color; // 고양이 색상
        public sbyte Age; // 고양이 나이
        #endregion

        #region < 멤버 메서드 - 기능 >
        public void Meow() // public을 써주지 않으면 기본 private로 저장
        {
            Console.WriteLine("{0} - 야옹", Name);
        }

        public void Run()
        {
            Console.WriteLine("{0} 고양이가 도망간다.", Name);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 생성자를 만든 다음 초기화
            Cat hellokitty = new Cat(); // 헬로키티라는 이름의 객체를 생성하려면 new와 class가 와야 함
            hellokitty.Name = "헬로키티";
            hellokitty.Color = "흰색";
            hellokitty.Age = 50;
            hellokitty.Meow();
            hellokitty.Run();

            // 객체를 생성하면서 속성 초기화
            Cat nero = new Cat() {
                Name = "네로",
                Color = "black",
                Age = 27,
            };
            nero.Meow();
            nero.Run();

            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", hellokitty.Name, hellokitty.Color, hellokitty.Age);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", nero.Name, nero.Color, nero.Age);

            Cat yaongi = new Cat();
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", yaongi.Name, yaongi.Color, yaongi.Age);

            Cat norangi = new Cat("노랑이", "노란색") ;
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", norangi.Name, norangi.Color, norangi.Age);

        }
    }
}
