using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트 연산
            int firstval = 15; // 15 = 0x1111
            int secondval = firstval << 1; // 11110 16 + 8 + 4 + 2 = 30
            Console.WriteLine(secondval);

            firstval = 15;
            secondval = 13;
            Console.WriteLine(firstval & secondval);

            firstval = 10;
            secondval = 5;
            Console.WriteLine(firstval | secondval);

            // Null 병합 연산자
            int? checkval = null;
            Console.WriteLine(checkval == null ? 0 : checkval); // 3항 연산자
            Console.WriteLine(checkval ?? 0);

            checkval = 25;
            Console.WriteLine(checkval == null ? 0 : checkval);
            Console.WriteLine(checkval ?? 0);
        }
    }
}
