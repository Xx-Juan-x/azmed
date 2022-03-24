namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class COTIZACION : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.COTIZACIONs",
                c => new
                    {
                        ID_COTIZACION = c.Int(nullable: false, identity: true),
                        FECHA = c.DateTime(nullable: false),
                        NOMBRE = c.String(),
                        MOTIVO = c.String(),
                        PRECIO = c.Double(nullable: false),
                        PEDIDO_ID_PEDIDO = c.Int(),
                        PROVEEDOR_ID_PROVEEDOR = c.Int(),
                    })
                .PrimaryKey(t => t.ID_COTIZACION)
                .ForeignKey("dbo.SOLICITUD_PEDIDO", t => t.PEDIDO_ID_PEDIDO)
                .ForeignKey("dbo.PROVEEDORs", t => t.PROVEEDOR_ID_PROVEEDOR)
                .Index(t => t.PEDIDO_ID_PEDIDO)
                .Index(t => t.PROVEEDOR_ID_PROVEEDOR);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.COTIZACIONs", "PROVEEDOR_ID_PROVEEDOR", "dbo.PROVEEDORs");
            DropForeignKey("dbo.COTIZACIONs", "PEDIDO_ID_PEDIDO", "dbo.SOLICITUD_PEDIDO");
            DropIndex("dbo.COTIZACIONs", new[] { "PROVEEDOR_ID_PROVEEDOR" });
            DropIndex("dbo.COTIZACIONs", new[] { "PEDIDO_ID_PEDIDO" });
            DropTable("dbo.COTIZACIONs");
        }
    }
}
