using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Aula204
{
    class DiferencaDatas
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public DiferencaDatas()
        {
        }

        public DiferencaDatas(DateTime dataInicial, DateTime dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }

        //As funções retornam a diferença em minutos, horas ou dias.

        //Mostra a diferença de datas entre uma data qualquer e a data atual
        public string DifDataAtual()
        {
            TimeSpan diferenca = DateTime.Now.Subtract(DataInicial);

            if (diferenca.TotalMinutes < 60)
            {
                return $"{diferenca.TotalMinutes.ToString()} Minutos.";
            }
            else if (diferenca.TotalHours < 24)
            {
                return $"{diferenca.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} Horas.";
            }
            else
            {
                return $"{diferenca.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} Dias.";
            }   
        }

        //Mostra a diferfença entre duas datas qualquer
        public string DifDuasDatas()
        {
            TimeSpan diferenca = DataFinal.Subtract(DataInicial);

            if (diferenca.TotalMinutes < 60)
            {
                return $"{diferenca.TotalMinutes.ToString()} Minutos.";
            }
            else if (diferenca.TotalHours < 24)
            {
                return $"{diferenca.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} Horas.";
            }
            else
            {
                return $"{diferenca.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} Dias.";
            }
        }
    }
}
