using System;

namespace Tercera_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Dada una lista de 10 numeros reales, introduciods por el usuario, muestre los elementos menor
            ///de dicha lista asi como la media aritmetica.


            int n = 10;//declaracion de variables
            float[] lista = new float[n];

            Console.WriteLine();
            Console.WriteLine("** EJERCICIO RESUELTO 5-5 ** ");
            Console.WriteLine();

            //Introducir los elementos de la lista
            for (int i = 0; i < n; i++)
            {

                Console.Write("Introduzcal el elemento {0} de la lista: ", i + 1);
                float elem = float.Parse(Console.ReadLine());
                lista[i] = elem;
            }

            //Mostrar la lista
            Console.Write("\nLos elementos de la lista son:");
            for (int i = 0; i < n; i++)
                Console.WriteLine(lista[i] + "\t");

            //Calculo del menor, mayor y la media
            float menor = lista[0];
            float mayor = lista[0];
            float media = 0;
            for (int i = 0; i < n; i++)
            {
                if (menor > lista[i]) menor = lista[i];
                if (mayor < lista[i]) mayor = lista[i];
                media = (media + lista[i]); // suma los elementos
            }

            media = media / n;
            // mostrar resultados
            Console.WriteLine();
            Console.WriteLine("El menor es: {0}", menor);
            Console.WriteLine("El mayor es: {0}", mayor);
            Console.WriteLine("La media es: {0}", media);

        }
    }
}
