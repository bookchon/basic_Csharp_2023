using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs26_delegate
{
    // 대리자 사용 선언
    delegate int CalcDelegate(int a, int b);

    delegate int Compare(int a, int b); // a, b중 뭐가 크고 작은지 비교하기 위한 대리자

    #region < 대리자 학습 기본 >
    class Calc
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        // 정적인 메서드는 static이 붙으면 무조건 실행될 때 최초 메모리에 장착
        // 프로그램 실행 중에는 언제든지 접근 가능
        public static int Minus(int a, int b) 
        {
            return a - b;
        }
    }

    #endregion
    internal class Program
    {
        // 오름차순 비교
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        // 내림차순 비교
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int i = 0, j = 0, temp = 0;

            for (i = 0; i < DataSet.Length-1; i++)
            {
                for (j=0; j<DataSet.Length - (i+1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j+1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp; // Swap
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            #region < 대리자 기본 예 >
            // 일반 클래스 사용 방식 - 직접 호출
            Calc normalCalc = new Calc();
            int x = 10, y = 25;
            int res = normalCalc.Plus(x, y);
            Console.WriteLine(res);

            Console.WriteLine(normalCalc.Plus(x, y));

            res = Calc.Minus(x, y);

            // 대리자를 사용하는 방식 - 대리자 호출
            x = 30; y = 20;
            Calc delCalc = new Calc();
            CalcDelegate CallBack;

            CallBack = new CalcDelegate(delCalc.Plus);
            int res2 = CallBack(x, y); // = Calc.Plus() 대신 호출
            Console.WriteLine(res2); // 50

            CallBack = new CalcDelegate(Calc.Minus);
            res2 = CallBack(x, y);
            Console.WriteLine(res2); // 10
            #endregion

            int[] origin = { 4, 7, 8, 2, 9, 1 };

            Console.WriteLine("오름차순 버블정렬");
            BubbleSort(origin, new Compare(AscendCompare));

            foreach (var item in origin)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine("내림차순 버블정렬");
            BubbleSort(origin, new Compare(DescendCompare));
            
            foreach (var item in origin)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine();
        }

    }
}
