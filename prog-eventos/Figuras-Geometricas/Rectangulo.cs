using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    internal class Rectangulo
    {
        //atributos
        double ancho;
        double altura;

        //constructor
        public Rectangulo()
        {
        }

        //métodos
        public void InitFields (double a, double aa)
        {
            this.ancho = a;
            this.altura = aa;
        }

        public double CalcularArea ()
        {
            double area = ancho * altura;
            return area;
        }
    }
}
