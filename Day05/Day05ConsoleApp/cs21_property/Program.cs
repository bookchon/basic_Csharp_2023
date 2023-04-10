using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs21_property
{
    class Boiler
    {
        private int temp; // 멤버변수

        public int Temp // 프로퍼티(속성)
        {
            get { return temp; }
            set 
            {
                if (value <= 10 || value >= 70)
                {
                    temp = 10;
                }
                
                else
                {
                    temp = value;
                }
            }

    }

        // 위의 get; set; 비교
        public void SetTemp(int temp)
        {
            if (temp <= 10 | temp >= 70) 
            {
                //Console.WriteLine("수온 설정값이 너무 낮거나 높습니다. 10 ~ 70도 사이로 지정해주세요");
                //return;
                this.temp = 10;
            }
            this.temp = temp;
        }

        public int GetTemp() { return this.temp;}

        class Car
        {
            string name;
            string color;
            int year;
            string fuel;
            int door;
            string tireType;
            string company;
            int price;
            string carplateNumber;
        }
    }

    interface Iproduct
    {
        string productName { get; set; }

        void Produce();
    }

    class MyProduct : Iproduct
    {
        private string productName;
        public string ProductName 
            { get { return productName; }
              set { productName = value; } }

        public void Produce()
        {
            Console.WriteLine("{0}를 생산합니다.", productName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            // kitturami.temp = 60;

            // kitturami.temp = 300000; // 보일러 물 수온

            kitturami.SetTemp(50);
            Console.WriteLine(kitturami.GetTemp());

            Boiler navien = new Boiler();
            navien.Temp = 5000;
            Console.WriteLine(navien.Temp);

        }
    }
}
