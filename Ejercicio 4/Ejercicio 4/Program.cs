using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double resultadoF = 0;
            double resultado = 0;
            double i = 0;

            Console.WriteLine("Intresa un número para sustituir X ");
            double x = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un número entero para finalizar la progresión");
            int n = Int32.Parse(Console.ReadLine());

            void progresion()
            {
                for (i = 1; i <= n; i++)
                {
                    resultado = resultado + i * x;
                   resultadoF += resultado;



                    if (i == n)
                    {
                        resultadoF += +1;
                        Console.WriteLine($"El resultado de la progresión es: {resultadoF}");

                    }

                }
            }

            progresion();

            Console.ReadKey();
        }
    }
}
