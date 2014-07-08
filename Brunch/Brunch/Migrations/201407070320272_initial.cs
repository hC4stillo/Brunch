namespace Brunch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insumos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nombre = c.String(),
                        Cantidad = c.Int(nullable: false),
                        Medida = c.Int(nullable: false),
                        Producto_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productos", t => t.Producto_Id)
                .Index(t => t.Producto_Id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Disponibilidad = c.Boolean(nullable: false),
                        PrecioCosto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Platillo_Id = c.Guid(),
                        Orden_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Platillos", t => t.Platillo_Id)
                .ForeignKey("dbo.Ordenes", t => t.Orden_Id)
                .Index(t => t.Platillo_Id)
                .Index(t => t.Orden_Id);
            
            CreateTable(
                "dbo.Ordenes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Platillos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Disponibilidad = c.Boolean(nullable: false),
                        PrecioCosto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Orden_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ordenes", t => t.Orden_Id)
                .Index(t => t.Orden_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nombre = c.String(),
                        Password = c.String(),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "Orden_Id", "dbo.Ordenes");
            DropForeignKey("dbo.Platillos", "Orden_Id", "dbo.Ordenes");
            DropForeignKey("dbo.Productos", "Platillo_Id", "dbo.Platillos");
            DropForeignKey("dbo.Insumos", "Producto_Id", "dbo.Productos");
            DropIndex("dbo.Platillos", new[] { "Orden_Id" });
            DropIndex("dbo.Productos", new[] { "Orden_Id" });
            DropIndex("dbo.Productos", new[] { "Platillo_Id" });
            DropIndex("dbo.Insumos", new[] { "Producto_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Platillos");
            DropTable("dbo.Ordenes");
            DropTable("dbo.Productos");
            DropTable("dbo.Insumos");
        }
    }
}
