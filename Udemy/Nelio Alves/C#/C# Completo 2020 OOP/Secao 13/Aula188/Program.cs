using System;
using System.IO;

namespace Aula188
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\lixo\file1.txt";
            string targetpath = @"c:\lixo\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);
                
                using(StreamWriter sw = File.AppendText(targetpath))
                {
                   foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
