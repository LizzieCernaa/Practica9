using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String opcion = String.Empty;

            while (!opcion.Equals("d"))
            {
                Console.Clear();
                Console.WriteLine(" -----MENU----- ");
                Console.WriteLine("a. Dividir ");
                Console.WriteLine("b. Obtener Cubo ");
                Console.WriteLine("c. Calculo de IMC ");
                Console.WriteLine("d. Salir ");
                Console.WriteLine(" -----Selecicone una opcion----- ");
                opcion = Console.ReadLine();    


                if (opcion.Equals("a"))
                {
                    Console.WriteLine("Dividir");
                }
                else if (opcion.Equals("b"))
                {
                    Console.WriteLine("Obtener Cubo");
                }
                else if (opcion.Equals("c"))
                {
                    Console.WriteLine("Calculo de IMC");
                }
                else if (opcion.Equals("d"))
                {
                    Console.WriteLine("Salir");
                }

            }

            Console.Clear();
            Console.WriteLine("Feliz dia :) ");
            Console.ReadKey();
        }
    }
}
