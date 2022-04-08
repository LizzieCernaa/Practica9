using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            double b = 0;
            double h = 0;
            double area = 0;
            int menu;

            Console.WriteLine("Ingrese el número correspondiente a la forma de la cual desea encontrar su área");
            Console.WriteLine("Circulo: 1  Cuadrado: 2  Rectángulo: 3  Triángulo: 4 ");
            menu = Int32.Parse(Console.ReadLine());

            switch (menu)
            { 
                case 1:
                    areaCirculo();
                    break;

                case 2:
                    areaCuadrado();
                    break;

                case 3:
                    areaRectángulo();
                    break;

                case 4:
                    areaTriángulo();
                    break;

                default:

                    Console.WriteLine("Parámetro equivocado");
                    break;


            }


            void areaCirculo()
            {
                Console.WriteLine("Ingrese el valor del radio");
                r = double.Parse(Console.ReadLine());

                area = System.Math.PI * Math.Pow(r, 2);

                Console.WriteLine($"área del circulo = {area}");
            }


            void areaCuadrado()
            {

                Console.WriteLine("Ingrese el valor del lado");
                b = double.Parse(Console.ReadLine());
                area = b * b;
                Console.WriteLine($"área del cuadrado = {area}");
            }

            void areaRectángulo()
            {

                Console.WriteLine("Ingrese el valor de la base");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de la áltura");
                h = double.Parse(Console.ReadLine());

                area = b * h;
                Console.WriteLine($"área del rectángulo = {area}");
            }

            void areaTriángulo()
            {
                Console.WriteLine("Ingrese el valor de la base");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de la áltura");
                h = double.Parse(Console.ReadLine());

                area = (b * h) / 2;
                Console.WriteLine($"área del triángulo = {area}");
            }


            Console.ReadKey();
        }
    }
}
