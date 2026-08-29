using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WninFrmsAppConversionDeTemperaturas
{
    public class Temperatura
    {
        //atributos
        private double grados;

        //constructor
        public Temperatura() 
        {
        }

        /// <summary>
        /// Convierte de Celsius a Fahrenheit
        /// </summary>
        /// <returns></returns>
        public double GetCelsiusAFahrenheit()
        {
            return (grados * 1.8) + 32;
        }

        /// <summary>
        /// Convierte de Celsius a Kelvin
        /// </summary>
        /// <returns></returns>
        public double GetCelsiusAKelvin()
        {
            return (grados + 273.15);
        }

        /// <summary>
        /// Convierte de Fahrenheit a Celsius
        /// </summary>
        /// <returns></returns>
        public double GetFahrenheitACelsius()
        {
            return ((grados - 32) / 1.8);
        }

        /// <summary>
        /// Convierte de Fahrenheit a Kelvin
        /// </summary>
        /// <returns></returns>
        public double GetFahrenheitAKelvin()
        {
            return ((grados - 32) / 1.8) + 273.15;
        }

        /// <summary>
        /// Convierte de Kelvin a Celsius
        /// </summary>
        /// <returns></returns>
        public double GetKelvinACelsius()
        {
            return (grados - 273.15);
        }

        /// <summary>
        /// Convierte de Kelvin a Fahrenheit
        /// </summary>
        /// <returns></returns>
        public double GetKelvinAFahrenheit()
        {
            return ((grados - 273.15) * 1.8) + 32;
        }

        //propiedades
        public double Grados { get { return grados; } set { grados = value; } }
    }
}
