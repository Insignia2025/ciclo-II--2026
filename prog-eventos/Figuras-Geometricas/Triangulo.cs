using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    internal class Triangulo
    {
        //atributos
        double baset;
        double altura;

        //constructor
        public Triangulo ()
        {
        }

        public void InitFields(double b, double a)
        {
            this.baset = b;
            this.altura = a;
        }

        public double CalcularArea ()
        {
            double area = (baset * altura) / 2;
            return area;
        }
    }
}
