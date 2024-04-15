using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion2024
{
    internal class Ejercicio_8
    {
        static void Main()
        {
            Console.Write("Ingrese la longitud del primer lado del triángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del segundo lado del triángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del tercer lado del triángulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            double perimetro = lado1 + lado2 + lado3;

            Console.WriteLine("El perímetro del triángulo es: " + perimetro);
        }
    }
}
