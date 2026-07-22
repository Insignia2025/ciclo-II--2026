//Guillermo Alejandro Menjívar Artiga
//Carnet: MA103625
//Este ejercicio consiste en el cálculo del área de diferentes figuras haciendo uso de conocimientos básicos de POO

using System;
namespace Figuras_Geometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int opcion = 0;

            Console.WriteLine("Cálculo de áreas");
            Console.WriteLine("Elija una opción: ");
            Console.WriteLine("1. Rectángulo.");
            Console.WriteLine("2. Cuadrado.");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Círculo.");
            opcion = Convert.ToInt16(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura: ");
                    double a = double.Parse(Console.ReadLine());
                    Rectangulo r = new Rectangulo();
                    r.InitFields(b, a);
                    Console.WriteLine("Área: " + r.CalcularArea());
                    break;

                case 2:
                    Console.WriteLine("Ingrese un lado: ");
                    double l = double.Parse(Console.ReadLine());
                    Cuadrado c = new Cuadrado();
                    c.InitFields(l);
                    Console.WriteLine("Área: " + c.CalcularArea());
                    break;

                case 3:
                    Console.WriteLine("Ingrese la base: ");
                    double ba = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura: ");
                    double al = double.Parse(Console.ReadLine());
                    Triangulo t = new Triangulo();
                    t.InitFields(ba, al);
                    Console.WriteLine("Área: " + t.CalcularArea());
                    break;

                case 4:
                    Console.WriteLine("Ingrese el radio: ");
                    double ra = double.Parse(Console.ReadLine());
                    Circulo ci = new Circulo();
                    ci.InitFields(ra);
                    Console.WriteLine("Área: " + ci.CalcularArea());
                    break;
            }
        }
    }
}