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
            string opci;
            double num1;
            double num2;
            double peso;
            double altura;

            Console.WriteLine("Seleccione la obsion que desaea realizar del menu:");
            imprimirmenu();

            void imprimirmenu()
            {
                Console.WriteLine("a. Dividir ");
                Console.WriteLine("b. Obtener Cubo ");
                Console.WriteLine("c. Calculo de IMC ");
                Console.WriteLine("d. Salir ");
            }
             void ObtenerNombreSistema(string opcion)
            {
                string resultado = string.Empty;

                switch (opcion)
                {
                    case "a":
                        resultado = "Dividir";
                        break;
                    case "b":
                        resultado = "Obtener Cubo";
                        break;
                    case "c":
                        resultado = "Calculo de IMC";
                        break;
                    case "d":
                        resultado = "Salir";
                        break;
                    default:
                        break;
                }
             }

            void divirdir() 
            {
                Console.WriteLine("Ingresa el primer numero");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo numero");
                num2 = int.Parse(Console.ReadLine());

                double resultado = num1 / num2;
                Console.WriteLine($"El resultado de la Divicion es {resultado}");

            }

            void obtenerCubo() 
            {
                Console.WriteLine("Ingresa un numero");
                num1 = int.Parse(Console.ReadLine());

                double formula = Math.Pow(num1, 2);
                Console.WriteLine($"El resultado para obtener un cubo es {formula}");


            }

            void IMC() 
            {

            }


            Console.ReadKey();
        }
    }
}
