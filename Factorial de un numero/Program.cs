using System;

namespace Factorial_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, factorial = 1;
            Console.WriteLine("Ingresa el numero para saber su factorial");
            numero = Int32.Parse(Console.ReadLine());

            while(numero != 0)
            {
                factorial *= numero;
                numero = numero -1;
            }

            Console.WriteLine("El factorial del numero que ingresaste es: {0} ", factorial);
             
        }
    }
}
