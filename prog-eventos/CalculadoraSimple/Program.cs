namespace CalculadoraSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Calculadora calculadora = new Calculadora(n1, n2);
            // Menú de operaciones
            Console.WriteLine("\nElija una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Resultado: " + calculadora.Sumar());
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + calculadora.Restar());
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + calculadora.Multiplicar());
                    break;
                case 4:
                    Console.WriteLine("Resultado: " + calculadora.Dividir());
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }
        }
    }
}
