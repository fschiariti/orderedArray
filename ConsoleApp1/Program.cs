using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int tmp = 0;
            int[] arreglo = { 99, 98, 1, 3, 2, 12, 6 };

            for (int i = 0; i < arreglo.Count(); i++)
            {

                for (int j = 0; j < arreglo.Count()-1; j++)
                {
                    if ( arreglo[j] > arreglo[j + 1])
                    {
                        tmp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = tmp;

                    }

                }

            }


            for (int i = 0; i < arreglo.Length ; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

        }
    }
}
