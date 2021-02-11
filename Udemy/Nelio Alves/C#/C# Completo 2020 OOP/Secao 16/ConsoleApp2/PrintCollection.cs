using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class PrintCollection
    {
        public void Print<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                System.Console.WriteLine(obj);
            }
            System.Console.WriteLine();
        }
    }
}
