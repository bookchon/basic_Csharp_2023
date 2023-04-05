using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs11_logiccondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            if (a == 20)
            {
                Console.WriteLine("20입니다.");
                Console.WriteLine("두번째 줄입니다.");
            }
            if (a == 30) return; // 메서드를 완전히 빠져나가는 구문은 한 줄로


            #region <switch 및 if구문>
            // 데이터 타입 비교 switch문 (C# 7.0부터 .NET framework 4.7 / 4.8)
            object obj = null;

            string inputs = Console.ReadLine(); // 콘솔에서 입력
            if (int.TryParse(inputs, out int iouput))
            {
                obj = iouput; // 입력값이 정수라서 문자열을 정수로 변환
            }
            else if(float.TryParse(inputs, out float foutput))
            { 
                obj = foutput;
            }

            Console.WriteLine(obj);
            switch (obj)
            {
                case int i: // 정수라면
                    Console.WriteLine("{0}은 int 형식입니다.");
                    break;
                case float f: // 실수라면
                    Console.WriteLine("{0}은 float 형식입니다.");
                    break;
                case string s:
                    Console.WriteLine("{0}은 string 형식입니다");
                    break;
                default:
                    Console.WriteLine("타입이 불분명 합니다.");
                    break;
            }
            #endregion

            #region <2중 FOR문>

            for (int x = 2; x <= 9; x++)
            {
                { for (int y = 2; y <=9; y++)
                    { 
                        Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
                    }
                }
            }

            #endregion

            #region < Foreach문>
            int[] ary = { 2, 4, 6, 8, 10 }; // 배열이나 컬렉션(리스트)

            foreach (int i in ary) {
                Console.WriteLine("{0}^2 = {1}", i, i ^ 2);
            }

            #endregion


        }
    }
}
