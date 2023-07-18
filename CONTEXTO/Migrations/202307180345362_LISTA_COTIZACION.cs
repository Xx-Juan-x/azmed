namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LISTA_COTIZACION : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LISTA_COTIZACION",
                c => new
                    {
                        ID_LISTA_COTIZACION = c.Int(nullable: false, identity: true),
                        PRECIO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        COTIZACION_ID_COTIZACION = c.Int(),
                        MATERIAL_ID_MATERIAL = c.Int(),
                    })
                .PrimaryKey(t => t.ID_LISTA_COTIZACION)
                .ForeignKey("dbo.COTIZACIONs", t => t.COTIZACION_ID_COTIZACION)
                .ForeignKey("dbo.MATERIALs", t => t.MATERIAL_ID_MATERIAL)
                .Index(t => t.COTIZACION_ID_COTIZACION)
                .Index(t => t.MATERIAL_ID_MATERIAL);
            
            DropColumn("dbo.COTIZACIONs", "PRECIO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.COTIZACIONs", "PRECIO", c => c.Double(nullable: false));
            DropForeignKey("dbo.LISTA_COTIZACION", "MATERIAL_ID_MATERIAL", "dbo.MATERIALs");
            DropForeignKey("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs");
            DropIndex("dbo.LISTA_COTIZACION", new[] { "MATERIAL_ID_MATERIAL" });
            DropIndex("dbo.LISTA_COTIZACION", new[] { "COTIZACION_ID_COTIZACION" });
            DropTable("dbo.LISTA_COTIZACION");
        }
    }
}
