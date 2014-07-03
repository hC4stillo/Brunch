namespace Proveedores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Configuracions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        JSON = c.String(),
                        IdProveedor = c.Guid(nullable: false),
                        Poveedor_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proveedors", t => t.Poveedor_Id)
                .Index(t => t.Poveedor_Id);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Soaps",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        JSON = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Configuracions", "Poveedor_Id", "dbo.Proveedors");
            DropIndex("dbo.Configuracions", new[] { "Poveedor_Id" });
            DropTable("dbo.Soaps");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Configuracions");
        }
    }
}
