using System;
using System.IO;

namespace Aula186
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\lixo\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }               
            }
            catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
