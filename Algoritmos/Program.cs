using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Algoritmos
{
    class Program
    {
        static Nodo<int> lista = new Nodo<int>();
        static void Main(string[] args)
        {
            NodoRecursivo(1);

            Nodo<int> aux = lista;
            while (aux != null)
            {
                Console.WriteLine($"{aux.dado}");
                aux = aux.prox;
            }
        }

        static int NodoRecursivo(int n)
        {
            if (n == 10)
            {
                return 0;
            }
            else
            {
                Nodo<int> novo = new Nodo<int>();
                novo.dado = n;
                novo.prox = lista;
                lista = novo;
                return NodoRecursivo(n + 1);
            }
        }
    }
}
