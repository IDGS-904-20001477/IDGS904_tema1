using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class ProductoServices
    {
        public List<Productos> ObtenerProducto()
        {
            var producto1 = new Productos()
            {
                Name = "Puelque1",
                Description = "Frutos Rojos",
                Quantity = 10,
                Production = new DateTime(2023, 11, 5)
            };
            var producto2 = new Productos()
            {
                Name = "Puelque2",
                Description = "Mango piña",
                Quantity = 35,
                Production = new DateTime(2023, 6, 10)
            };
            return new List<Productos> { producto1, producto2 };
        }
    }
}