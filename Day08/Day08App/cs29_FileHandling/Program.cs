using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = "."; // 현재 디렉토리(상대경로)
            Console.WriteLine("현재 디렉토리 정보");
            string curDirectory = @"C:\Temp"; // C:/Dev 절대경로 / . 현재 디렉토리(상대경로) .. 부모디렉토리

            var dirs = Directory.GetDirectories(dir);
            foreach (var d in dirs) 
            { 
                var dirInfo = new DirectoryInfo(d);

                Console.WriteLine(dirInfo.Name);
                Console.WriteLine("[{0}]", dirInfo.Attributes);
            }

            var files = Directory.GetFiles(curDirectory);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                Console.WriteLine(fileInfo.Name);
                Console.WriteLine("[{0}]", fileInfo.Attributes);
            }

            // 특정 경로에 하위폴더/하위파일 조회

            string path = @"C:\Temp\Csharp_Bank"; // 만들고자 하는 폴더
            string sfile = "Test2.log"; // 생성할 파일

            if (Directory.Exists(path))
            {
                Console.WriteLine("경로가 존재하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile); // C:\Temp\Csharp_bank\Test.log
            }

            else
            {
                Console.WriteLine($"해당 경로가 없습니다 {path}, 만듭니다.");
                Directory.CreateDirectory(path);

                Console.WriteLine("경로를 생성하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile);
            }
        }
    }
}
