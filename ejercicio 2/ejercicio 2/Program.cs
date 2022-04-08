using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iVa = 13;
            int renTa = 10;
            int productoo;
            int servicio;

            ProducTo();
            Servicio();

            void ProducTo()
            {
                Console.WriteLine("Introduce el valor de producto ");
                productoo = int.Parse(Console.ReadLine());

                double tarea = productoo + iVa;
                Console.WriteLine($"Su producto con el IVA es {tarea}");

            }

            void Servicio() 
            {
                Console.WriteLine("Introduce el valor del servicio profecional ");
                servicio = int.Parse(Console.ReadLine());

                double producion = servicio + iVa + renTa;
                Console.WriteLine($"Su servicio profecional con IVA y renta es de {producion}");
            }

            Console.ReadKey();
        }
    }
}
