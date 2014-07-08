using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brunch.Models
{
    public class Orden
    {
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Platillo> Platillos { get; set; }
    }
}