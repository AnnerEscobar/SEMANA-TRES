using System;

namespace Ejercicio_5_6_pagina_110
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine();
            Console.WriteLine("** EJERCICIO RESUELTO 5-6 ** ");
            Console.WriteLine();

            Console.Write("Introduzca la dimension de la matriz: ");
            int dim = Int32.Parse(Console.ReadLine());
            int[,] matriz = new int[dim, dim];
            for (i = 0; i < dim; i++)
                for (j = 0; j < dim; j++)
                    if (i == j)
                        matriz[i, j] = 1;
                    else
                        matriz[i, j] = 0;

            // Muestra la matriz
            Console.WriteLine("La matriz id. de dimension {0} es :", dim);
            for (i = 0; i < dim; i++)
            {
                for (j = 0; j < dim; j++)
                    Console.Write(" {0,3}", matriz[i, j]);
                Console.WriteLine();

            }

        }
    }
}
