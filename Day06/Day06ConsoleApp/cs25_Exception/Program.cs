using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3};

            try
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                /* 예외가 발생하더라도 무조건 처리해야 되는 로직
                 * file 객체 close
                 * db 연결 close
                 * 네트워크 소켓 close
                 */
                Console.WriteLine("계속");
            }

            try
            {
                DivideTest(array[2], 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("프로그램 종료");

            /*
            try
            {
                Console.WriteLine("Test");
                throw new Exception("커스텀 예외");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
        }

        private static void DivideTest(int v1, int v2)
        {
            try
            {
                Console.WriteLine(v1 / v2);
            }
            catch (Exception)
            {
                // 현재 메서드에 예외처리를 하는 것이 아닌, 메서드를 호출하는 곳에서 예외 처리
                throw new Exception("DivideTest 메서드에서 예외 발생");
            }

        }
    }
}
