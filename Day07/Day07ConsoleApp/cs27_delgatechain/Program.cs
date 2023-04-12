using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_delgatechain
{
    delegate void ThereIsAFire(string location); // 불 났을 때 대신해주는 대리자


    class Sample
    {
        public int valueA;  // 멤버 변수

        private int ValueA
        {
            /*
            get { return valueA; }
            set { ValueA = value; }
            */
            get => valueA; set => valueA = value;
        }
    }
    delegate string Concatenate(string[] args);
    internal class Program
    {
        static void Call119(String location)
        {
            Console.WriteLine("119죠, {0}에 불났어요", location);
        }

        static void ShoutOut(string location)
        {
            Console.WriteLine("{0}에 불났어요", location);
        }

        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 탈출합니다", location);
        }

        static string ProcConcate(string[] args)
            {
                string result = string.Empty; // == "";
                foreach (string s in args)
                {
                    result += s + "/";
                }
                return result;
            }

        static void Main(string[] args)
        {
            #region < 대리자 체인 >
            var loc = "우리집";
            Call119("우리집");
            ShoutOut(loc);
            Escape(loc);


            // 불이 날 수도 있으니 준비
            var otherloc = "경찰서";
            ThereIsAFire fire = new ThereIsAFire(Call119);
            fire += new ThereIsAFire(ShoutOut);
            fire += new ThereIsAFire(Escape);

            fire(otherloc);

            fire -= new ThereIsAFire(ShoutOut); // 대리자에서 메서드를 삭제

            fire("다른집");
            #endregion

            Concatenate concat = new Concatenate(ProcConcate);
            var result = concat(args);

            Console.WriteLine(result);
        }
    }
}
