using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Temperatura
    {
        public double Grados { get; set; }
        public string Selecccionado { get; set; }
        public double Resultado { get; set; }

        public void CalcularCelcius()
        {
            if (this.Selecccionado == "Celsius")
            {
                this.Resultado = (this.Grados - 32) / 1.8;
            }
            else
            {
                this.Resultado = (this.Grados * 1.8) + 32;
            }
        }
    }
}