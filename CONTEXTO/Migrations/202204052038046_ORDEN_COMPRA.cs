namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ORDEN_COMPRA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ORDEN_COMPRA",
                c => new
                    {
                        ID_ORDEN_COMPRA = c.Int(nullable: false, identity: true),
                        CANTIDAD = c.Int(nullable: false),
                        COTIZACION_ID_COTIZACION = c.Int(),
                        PEDIDO_ID_SOLICITUD_PEDIDO = c.Int(),
                    })
                .PrimaryKey(t => t.ID_ORDEN_COMPRA)
                .ForeignKey("dbo.COTIZACIONs", t => t.COTIZACION_ID_COTIZACION)
                .ForeignKey("dbo.SOLICITUD_PEDIDO", t => t.PEDIDO_ID_SOLICITUD_PEDIDO)
                .Index(t => t.COTIZACION_ID_COTIZACION)
                .Index(t => t.PEDIDO_ID_SOLICITUD_PEDIDO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ORDEN_COMPRA", "PEDIDO_ID_SOLICITUD_PEDIDO", "dbo.SOLICITUD_PEDIDO");
            DropForeignKey("dbo.ORDEN_COMPRA", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs");
            DropIndex("dbo.ORDEN_COMPRA", new[] { "PEDIDO_ID_SOLICITUD_PEDIDO" });
            DropIndex("dbo.ORDEN_COMPRA", new[] { "COTIZACION_ID_COTIZACION" });
            DropTable("dbo.ORDEN_COMPRA");
        }
    }
}
