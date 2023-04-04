using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte bdata = byte.MaxValue;
            Console.WriteLine(bdata);
            bdata = byte.MinValue;
            Console.Write(bdata);

            long ldata = long.MaxValue;
            Console.WriteLine(ldata);
            ldata = long.MinValue;
            Console.Write(ldata);

            ldata--;
            Console.WriteLine(ldata);

            int binVal = 0b1111111;
            Console.WriteLine(binVal);
        }
    }
}
