using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Brunch.Models
{
    public class BrunchEntity : DbContext
    {
        public BrunchEntity()
            : base()
        {

        }
        public virtual DbSet<Insumo> Insumos { get; set; }
        public virtual DbSet<Orden> Ordenes { get; set; }
        public virtual DbSet<Platillo> Platillos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
    }
}