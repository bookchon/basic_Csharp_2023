using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09_nullcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo Myfoo = null;
            /*
            int? bar;
            if (Myfoo != null)
            {
                bar = Myfoo.member;
            }
            else
            {
                bar = null;
            }
            */ 
            // 위의 아홉 줄을 모두 축약시킴
            int? bar = Myfoo?.member;
        }
    }

    class Foo 
    {
        public int member;
    }
}
