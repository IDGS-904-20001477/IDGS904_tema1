using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }
        public string Operacion { get; set; }
        public void Suma() { 
            this.Res = this.Num1 + this.Num2;
        }
        public void Resta()
        {
            this.Res = this.Num1 - this.Num2;
        }
        public void Dividir()
        {
            this.Res = this.Num1 / this.Num2;
        }
        public void Multiplicar()
        {
            this.Res = this.Num1 * this.Num2;
        }
        public int Calcular()
        {
            switch (this.Operacion)
            {
                case "suma":
                    this.Suma();
                    break;
                case "resta":
                    this.Resta();
                    break;
                case "dividir":
                    this.Dividir();
                    break;
                case "multiplicar":
                    this.Multiplicar();
                    break;
            }
            return this.Res;
        }
    }
}