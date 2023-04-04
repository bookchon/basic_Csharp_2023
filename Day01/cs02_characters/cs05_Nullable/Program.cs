using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs05_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null; // int a null 값을 담을 수 없음 c# 6.0 Nullable
            Console.WriteLine(a == null);

            int b = 0;
            Console.Write(b == null);
            Console.WriteLine(b.GetType());

            // 값 형식 byte, short, int, long, float, double, char 등은 null을 할당 x
            // null을 할당할 수 있도록 만드는 방식 = type?

            float? c = null;
            Console.WriteLine(c.HasValue);

            c = 3.14f;
            Console.WriteLine(c.HasValue);
            Console.WriteLine(c.Value);
            Console.WriteLine(c);
        }
    }
}
