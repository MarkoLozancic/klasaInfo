using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace klasaInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\");
            Console.WriteLine("\n Poddirektorij: ");
            
            foreach(DirectoryInfo diInfo in di.GetDirectories())
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    diInfo.Name, diInfo.CreationTime, diInfo.LastAccessTime);
            }
            Console.ReadKey();
        }
    }
}
