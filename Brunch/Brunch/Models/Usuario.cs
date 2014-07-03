using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brunch.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public RolDeUSuario Rol { get; set; }
    }
}