using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    internal class Cuadrado
    {
        //atributos
        double lado;

        //constructor
        public Cuadrado ()
        {
        }

        //métodos
        public void InitFields (double l)
        {
            this.lado = l;
        }

        public double CalcularArea ()
        {
            double area = lado * lado;
            return area;
        }
    }
}
