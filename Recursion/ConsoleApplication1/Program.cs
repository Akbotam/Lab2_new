using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void emptyspace(int level)
        {
            for (int i = 0; i < level * 2; i++)
            {
                Console.WriteLine(" ");
            }
        }

        static void Ex1(string path, int level)
        {
            if (level > 2)
                return;
            try
            {
                //GetDirectories
                DirectoryInfo directory = new DirectoryInfo(path);
                DirectoryInfo[] directories = directory.GetDirectories();
                //GetFiles
                FileInfo[] files = directory.GetFiles();
                Console.WriteLine("Files:" + directory.GetFiles().Length);
                foreach (FileInfo file in files)
                {
                    emptyspace(level);
                    Console.WriteLine(file.Name);
                }
                Console.WriteLine("Directories" + directories.Length);
                foreach (DirectoryInfo dInfo in directories)
                {
                    emptyspace(level);
                    Console.WriteLine(dInfo.Name);
                }
            }
            catch (Exception e)
            {

            }
            
        }


         static void Main(string[] args)
        {
            Ex1(@"C:\Users\Андрей\Desktop\Licenses", 0);
            Console.ReadKey();
        }
    }
}
