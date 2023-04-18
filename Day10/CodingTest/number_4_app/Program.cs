using number_4_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_4_app
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        void Eat();
        void Sleep();
        void Sound();
    }

    class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name}이 밥을 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name}이 잠을 잡니다.");
        }

        public void Sound()
        {
            Console.WriteLine($"{Name}이 멍멍 짖습니다.");
        }
    }

    class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name}이 밥을 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name}이 잠을 잡니다.");
        }

        public void Sound()
        {
            Console.WriteLine($"{Name}이 야옹 울음소리를 냅니다.");
        }
    }

    class Horse : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Horse(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name}이 건초를 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name}이 자리에서 쉽니다.");
        }

        public void Sound()
        {
            Console.WriteLine($"{Name}이 히이잉 소리를 냅니다.");
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
    {
        IAnimal dog = new Dog("바둑이", 2);
        dog.Eat();
        dog.Sound();

        IAnimal cat = new Cat("나비", 3);
        cat.Eat();
        cat.Sound();

        IAnimal horse = new Horse("말", 5);
        horse.Eat();
        horse.Sound();
    }
}
