using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co03_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object 형식
            int idata = 1024;
            Console.WriteLine(idata);
            Console.WriteLine(idata.GetType());

            Object iobj = (object)idata; // 박싱 : 데이터 타입 값을 Object로 담아라
            Console.WriteLine(iobj);
            Console.WriteLine(iobj.GetType());

            int udata = (int)iobj;
            Console.WriteLine(udata);
            Console.WriteLine(udata.GetType());

            double data = 3.141592;
            object pobject = (object)data;
            double pdata = (double)pobject;

            Console.WriteLine(pobject);
            Console.WriteLine(pobject.GetType());
            Console.WriteLine(pdata);
            Console.WriteLine(pdata.GetType());

            short sdata = 32000;
            int indata = sdata;
            Console.WriteLine(indata);

            long lndata = long.MaxValue;
            Console.WriteLine(lndata);
            indata = (int)lndata;
            Console.WriteLine(indata);

            // 실무에서 가장 많이 쓰는 예제
            int numival = 1024;
            string str1val = numival.ToString();
            Console.WriteLine(str1val.GetType());

            double numdval = 3.141592;
            string strdval = numdval.ToString();
            Console.WriteLine(strdval);

            // 문자열을 숫자로 변환
            // 문자열 내애 숫자가 아닌 특수문자나 정수인데 소수점이 있는 경우 오류가 남
            string originstr = "34567890";
            int convval = Convert.ToInt32(originstr);
            Console.WriteLine(convval);
            originstr = "1.2345";
            float convfloat = float.Parse(originstr);
            Console.WriteLine(convfloat);

            // 예외 발생하지 않도록 형변환 하는 방법
            originstr = "122.0f";
            float ffval;
            // TryParse는 예외가 발생하면 값 0 대체, 예외가 없으면 원래 값으로 나옴
            float.TryParse(originstr, out ffval);
            Console.Write(ffval);
        }
    }
}
