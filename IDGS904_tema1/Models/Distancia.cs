using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Distancia
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double Y3 { get; set; }
        public double DistanciaTot1 { get; set; }
        public double DistanciaTot2 { get; set; }
        public double DistanciaTot3 { get; set; }
        public String TipoTriangulo { get; set; }

        public double Area { get; set; } 

        public string ObtenerTipoTriangulo()
        {
            this.DistanciaTot1 = Math.Sqrt(Math.Pow(this.X2 - this.X1, 2) + Math.Pow(this.Y2 - this.Y1, 2));
            this.DistanciaTot2 = Math.Sqrt(Math.Pow(this.X3 - this.X1, 2) + Math.Pow(this.Y3 - this.Y1, 2));
            this.DistanciaTot3 = Math.Sqrt(Math.Pow(this.X3 - this.X2, 2) + Math.Pow(this.Y3 - this.Y2, 2));

            this.DistanciaTot1 = Math.Round(this.DistanciaTot1, 1);  
            this.DistanciaTot2 = Math.Round(this.DistanciaTot2, 1);
            this.DistanciaTot3 = Math.Round(this.DistanciaTot3, 1);

            if (this.DistanciaTot1 + this.DistanciaTot2 <= this.DistanciaTot3 || this.DistanciaTot2 + this.DistanciaTot3 <= this.DistanciaTot1 || this.DistanciaTot3 + this.DistanciaTot1 <= this.DistanciaTot2)
            {
                this.TipoTriangulo = "No es un triángulo";
            }
            else if (this.DistanciaTot1 == this.DistanciaTot2 && this.DistanciaTot2 == this.DistanciaTot3)
            {
                this.TipoTriangulo = "Equilátero";
                Area = (Math.Sqrt(3) / 4) * (DistanciaTot1 * DistanciaTot2);

            }
            else if (this.DistanciaTot1 == this.DistanciaTot2 || this.DistanciaTot2 == this.DistanciaTot3 || this.DistanciaTot3 == this.DistanciaTot1)
            {
                this.TipoTriangulo = "Isósceles";

                double altura = Math.Sqrt((this.DistanciaTot2 * this.DistanciaTot2) - ((DistanciaTot1 * DistanciaTot1) / 4));
                Area = (DistanciaTot1 * altura) / 2;
            }
            else
            {
                this.TipoTriangulo = "Escaleno";

                double semiPerimetro = (this.DistanciaTot1 + this.DistanciaTot2 + this.DistanciaTot3) / 2;
                Area = Math.Sqrt(semiPerimetro * (semiPerimetro - this.DistanciaTot1) * (semiPerimetro - this.DistanciaTot2) * (semiPerimetro - this.DistanciaTot3));
            }

            return this.TipoTriangulo + "<br>" + "El Area es " + Area;
        }
    }
}