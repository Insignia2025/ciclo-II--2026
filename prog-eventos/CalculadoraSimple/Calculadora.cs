using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimple
{
    internal class Calculadora
    {
        private double num1;
        private double num2;

        //Constructor 1 (para aplicar sobrecarga)
        public Calculadora (double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Constructor 2 (para aplicar sobrecarga)
        public Calculadora (int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Método que suma
        public double Sumar()
        {
            double resultado = num1 + num2;
            return resultado;
        }

        //Método que resta
        public double Restar()
        {
            double resultado = num1 - num2;
            return resultado;
        }

        //Método que multiplica
        public double Multiplicar()
        {
            double resultado = num1 * num2;
            return resultado;
        }

        //Método que divide
        public double Dividir()
        {
            if (num2 == 0)
            {
                Console.WriteLine("No se puede realizar la división entre 0.");
                return 0;
            }
            double resultado = num1 / num2;
            return resultado;
        }
    }
}
