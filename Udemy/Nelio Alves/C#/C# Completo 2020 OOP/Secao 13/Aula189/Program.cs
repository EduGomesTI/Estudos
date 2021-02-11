using System;
using System.Collections.Generic;
using System.IO;

namespace Aula189
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\lixo\myfolder";

            try
            {
                Directory.CreateDirectory($@"{path}\newfolder");

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
