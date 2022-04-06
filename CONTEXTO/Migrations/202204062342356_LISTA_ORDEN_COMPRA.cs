namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LISTA_ORDEN_COMPRA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LISTA_COMPRA",
                c => new
                    {
                        ID_LISTA_COMPRA = c.Int(nullable: false, identity: true),
                        CANTIDAD = c.Int(nullable: false),
                        COMPRA_ID_ORDEN_COMPRA = c.Int(),
                        COTIZACION_ID_COTIZACION = c.Int(),
                    })
                .PrimaryKey(t => t.ID_LISTA_COMPRA)
                .ForeignKey("dbo.ORDEN_COMPRA", t => t.COMPRA_ID_ORDEN_COMPRA)
                .ForeignKey("dbo.COTIZACIONs", t => t.COTIZACION_ID_COTIZACION)
                .Index(t => t.COMPRA_ID_ORDEN_COMPRA)
                .Index(t => t.COTIZACION_ID_COTIZACION);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LISTA_COMPRA", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs");
            DropForeignKey("dbo.LISTA_COMPRA", "COMPRA_ID_ORDEN_COMPRA", "dbo.ORDEN_COMPRA");
            DropIndex("dbo.LISTA_COMPRA", new[] { "COTIZACION_ID_COTIZACION" });
            DropIndex("dbo.LISTA_COMPRA", new[] { "COMPRA_ID_ORDEN_COMPRA" });
            DropTable("dbo.LISTA_COMPRA");
        }
    }
}
