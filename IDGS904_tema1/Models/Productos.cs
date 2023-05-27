using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Productos
    {
        public string Name { get; set;}
        public string Description { get; set;}
        public int Quantity { get; set; }
        public DateTime Production { get; set;}
    }
}