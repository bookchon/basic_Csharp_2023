using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs04_enums
{
    enum HomeTown
    {
        SEOUL,
        DAEJEON,
        DAEGU,
        BUSAN,
        JEJU
    };
    static void Main(string[] args)
    {
        HomeTown myHomeTown;
        myHomeTown = HomeTown.BUSAN;
        if (myHomeTown == HomeTown.SEOUL)
        {
            Console.WriteLine("서울 출신이시군요");
        }
        else if (myHomeTown == HomeTown.DAEJEON) ;
        {
            Console.WriteLine("충청도예요");
        }
        else if (myHomeTown == HomeTown.DAEGU) ;
        { 
            Console.WriteLine("대구입니다."); 
        }
        else if (myHomeTown == HomeTown.BUSAN) { }
        
    }
    
}
