﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs20_abstractClass
{
    abstract class AbstractParent
    {
        protected void MethodA()
        {
            Console.WriteLine("AbstractParent.MethodA()");
        }

        public void MethodB() // 클래스랑 동일
        {
            Console.WriteLine("AbstractParent.MethodB()");
        }

        public abstract void MethodC(); // 인터페이스랑 동일, 추상 메서드
    }

    class Child : AbstractParent
    {
        public override void MethodC() // 재정의(재구현)
        {
            Console.Write("Child.MethodC() - 추상클래스 구현");
            MethodA(); // protected는 자기 자신과 자식 클래스 내에서만 사용 가능함
        }
    }
    
    abstract class Mammal // 포유류 최상위 클래스
    {
        public void Nurse()
        {
            Console.WriteLine();
        }
        public abstract void Sound();
    }

    class Dogs : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cats : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("야옹");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractParent parent = new Child();
            parent.MethodC();
            parent.MethodB();
        }
    }
}
