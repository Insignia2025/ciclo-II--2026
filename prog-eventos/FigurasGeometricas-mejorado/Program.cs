namespace FigurasGeometricas_mejorado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de áreas");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Círculo");
            Console.Write("Elija una opción: ");

            static int LeerEntero()
            {
                int valor;
                while (!int.TryParse(Console.ReadLine(), out valor))
                    Console.Write("Entrada inválida, intente de nuevo: ");
                return valor;
            }

            static double LeerDouble(string mensaje)
            {
                Console.Write(mensaje);
                double valor;
                while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                    Console.Write("Valor inválido, ingrese un número positivo: ");
                return valor;
            }

            int opcion = LeerEntero();

            Figura figura;
            
            switch (opcion)
            {
                case 1:
                    double ancho = LeerDouble("Ingrese el ancho: ");
                    double altura = LeerDouble("Ingrese la altura: ");
                    figura = new Rectangulo(ancho, altura);
                    break;
                case 2:
                    double lado = LeerDouble("Ingrese un lado: ");
                    figura = new Cuadrado(lado);
                    break;
                case 3:
                    double baseT = LeerDouble("Ingresar la base: ");
                    double alturaT = LeerDouble("Ingresar la altura: ");
                    figura = new Triangulo(baseT, alturaT);
                    break;
                case 4:
                    double radio = LeerDouble("Ingrese el radio: ");
                    figura = new Circulo(radio);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine($"Área: {figura.CalcularArea():F2}");
        }
    }
}
