using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WninFrmsAppConversionDeTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDesdeCelsius_Click(object sender, EventArgs e)
        {
            Temperatura temp = new Temperatura();
            temp.Grados = Convert.ToDouble(txtCelsius.Text);
            txtFahrenheit.Text = temp.GetCelsiusAFahrenheit().ToString();
            txtKelvin.Text = temp.GetCelsiusAKelvin().ToString();
        }

        private void btnDesdeFahrenheit_Click(object sender, EventArgs e)
        {
            Temperatura temp = new Temperatura();
            temp.Grados = Convert.ToDouble(txtFahrenheit.Text);
            txtCelsius.Text = temp.GetFahrenheitACelsius().ToString();
            txtKelvin.Text = temp.GetFahrenheitAKelvin().ToString();
        }

        private void btnDesdeKelvin_Click(object sender, EventArgs e)
        {
            Temperatura temp = new Temperatura();
            temp.Grados = Convert.ToDouble(txtKelvin.Text);
            txtCelsius.Text = temp.GetKelvinACelsius().ToString();
            txtFahrenheit.Text = temp.GetKelvinAFahrenheit().ToString();
        }
    }
}
