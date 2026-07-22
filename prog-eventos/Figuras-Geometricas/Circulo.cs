using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    internal class Circulo
    {
        //atributos
        double radio;

        //constructor
        public Circulo()
        {
        }

        //métodos
        public void InitFields (double r)
        {
            this.radio = r;
        }
            
        public double CalcularArea ()
        {
            double area = Math.PI * (radio * radio);
            return area;
        }
    }
}
