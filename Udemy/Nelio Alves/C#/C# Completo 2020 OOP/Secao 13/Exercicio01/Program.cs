using Exercicio01.Entities;
using System;
using System.Reflection.Metadata;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFolder = @"c:\lixo\myfolder\out";
            string sourcePatch = @"c:\lixo\myfolder\File1.csv";
            string destinyPath = @"c:\lixo\myfolder\out\summary.csv";

            SummaryFile file = new SummaryFile(sourceFolder, sourcePatch, destinyPath);

            file.CreateDir(file.NamePath);

            file.CreateSummaryFile(file.NameOriginalFile, file.NameNewFile);

        }
    }
}
