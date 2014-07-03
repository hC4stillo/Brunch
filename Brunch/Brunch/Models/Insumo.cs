using Brunch.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brunch.Models
{
    public class Insumo
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public Medida Medida { get; set; }
    }
}