using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brunch.Models
{
    public class Producto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Disponibilidad { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}