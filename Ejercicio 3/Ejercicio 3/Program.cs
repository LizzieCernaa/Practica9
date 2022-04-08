using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;

            inicio();

            void inicio()
            {
                Console.WriteLine("Ingresa el primer numero: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());

                double suMa = numero1 + numero2;
                Console.WriteLine($"La suma de los dos numero es: {suMa}");

                double resTa = numero1 - numero2;
                Console.WriteLine($"La resta de los dos numero es: {resTa}");

            }

            Console.ReadKey();

        }


    }
}
