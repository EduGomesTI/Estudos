
using System;
using System.Collections.Generic;

namespace Algoritmos
{
    class InsertionSort
    {
        private List<int> Numeros = new List<int>();
        public void InserirNumerosAleatoriosLista(int quantidade, int max)
        {
            
            Random randNum = new Random();
            for (int i = 0; i <= quantidade; i++)
            {
                Numeros.Add(randNum.Next(max));
            }
        }
    }
}
