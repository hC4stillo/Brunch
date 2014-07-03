using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Proveedores.Models
{
    public class ProveedorContext : DbContext
    {


        public ProveedorContext()
            : base("Server=tcp:qc7x619hrs.database.windows.net,1433;Database=Proveedores_db;User ID=hcastillo@qc7x619hrs;Password=Duffman123;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;")
        {

        }
        public virtual DbSet<Proveedor> Proveedores { get; set; }
        public virtual DbSet<Configuracion> Configuraciones { get; set; }
        public virtual DbSet<Soap> Soaps { get; set; }
    }
}