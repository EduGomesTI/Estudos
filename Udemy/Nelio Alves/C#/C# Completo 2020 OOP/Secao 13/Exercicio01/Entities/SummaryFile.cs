using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Exercicio01.Entities
{
    class SummaryFile
    {
        public string NamePath { get; set; }
        public string NameOriginalFile { get; set; }
        public string NameNewFile { get; set; }

        public SummaryFile()
        {
        }

        public SummaryFile(string namePath, string nameOriginalFile, string nameNewFile)
        {
            NamePath = namePath;
            NameOriginalFile = nameOriginalFile;
            NameNewFile = nameNewFile;
        }

        private string MessageError(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ocorreu um erro");
            sb.AppendLine(message);
            return sb.ToString();
        }

        public void CreateDir(string path)
        {
            try 
            {
                Directory.CreateDirectory(path);
            }
            catch (IOException e)
            {
                MessageError(e.Message);
            }
        }

        public void CreateSummaryFile(string oldFilePath, string newFilePath)
        {
           try
            {
               using(FileStream fs = new FileStream(oldFilePath, FileMode.Open))
                {
                    using(StreamReader sr = new StreamReader(fs))
                    {
                        using (FileStream fs1 = File.Create(newFilePath))
                        {
                            using (StreamWriter sw = new StreamWriter(fs1))
                            {
                                Products product = new Products();
                                while (!sr.EndOfStream)
                                {
                                    string[] line = sr.ReadLine().Split(',');

                                    product.Name = line[0];
                                    product.Value = double.Parse(line[1], CultureInfo.InvariantCulture);
                                    product.Quantity = int.Parse(line[2]);

                                    sw.WriteLine($"{product.Name}, {product.TotalValue(product.Value, product.Quantity).ToString("F2", CultureInfo.InvariantCulture)}");   
                                }
                            }
                        }
                    }
                }             
            }
            catch (IOException e)
            {
                MessageError(e.Message);
            }
           
        }
    }
}
