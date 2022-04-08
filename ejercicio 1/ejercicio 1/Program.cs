using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aniO;
            double actual = 2022;

            anio();


            void anio() 
            {
                Console.WriteLine("Ingresa el anio de nacimiento ");
                aniO = int.Parse(Console.ReadLine());


                double edad = actual - aniO;
                Console.WriteLine($"Tienes {edad} años de edad ");
            }

            Console.ReadKey();
        }
    }
}
