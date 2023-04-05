using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs12_methods
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minuss(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        /// <summary>
        /// 실행시 메모리에 최초 올라가야 하기 때문에 static이 되어야 하고,
        /// 메서드 이름이 Main이면 실행 시 알아서 처음에 시작 됨
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region < static Method >
            int result = Calculator.Plus(1, 2); // static은 최초 실행 시 메모리에 바로 올라가기 때문에 클래스의 객체를 만들 필요가 없음
            // static을 사용하지 않을 시 객체를 생성하지 않으면 접근이 불가능 함
            Console.WriteLine(result);

            #endregion

            #region < Call by reference, Call by value 비교 >
            int x = 5; int y = 4;
            // ref가 없으면 Call by value
            Swap(ref x, ref y); // x, y가 가지고 있는 주소를 전달하라 Call by reference == pointer   

            Console.WriteLine("x = {0}, y = {1}", x, y);

            Console.WriteLine(GetNumber());

            #endregion

            #region < out 매개변수 >

            int divid = 30;
            int divor = 2;

            int rem = 0;
            Divide(divid, divor, out result, out rem); // ref, out 결과 차이 없음
            Console.WriteLine("나누기 값 {0}, 나머지 {1}", result, rem);

            (result, rem) = Divide(20, 6);
            #endregion

            #region < 가변길이 매개변수 >
            //int reeSum = Sum(1, 3, 5, 7, 9);
            //Console.WriteLine(reeSum);
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6));
            #endregion
        }

        //static int Divide(int x, int y)
        //{
        //    return x / y;
        //}
        //static int Reminder(int x, int y)
        //{
        //    return x % y;
        //}


        // static void Divide(int x, int y, ref int val, ref int rem)
        static void Divide(int x, int y, out int val, out int rem)
        {
            val = x / y;
            rem = x % y;
        }

        static (int result, int rem) Divide(int x, int y)
        {
            return (x / y, x % y);
        }


        // 메인 메서드와 같은 레벨에 있는 메서드들은 전부 static이 되어야 함(무조건)
        public static void Swap(ref int a, ref int b) {
            int temp = 0;
            temp = a; // 5 : temp = 5
            a = b; // a = 4
            b = temp;  // 5
        }

        static int val = 100;
        public static ref int GetNumber()
        {
            return ref val; // static 메서드에 접근할 수 있는 변수는 static밖에 없음
        }

        public static int Sum(params int[] args) // Python 가변 길이 매개변수랑 비교
        {
            int sum = 0;
            foreach (var item in args)
            {
                sum += item;
            }
            return sum;
        }
    }
}
