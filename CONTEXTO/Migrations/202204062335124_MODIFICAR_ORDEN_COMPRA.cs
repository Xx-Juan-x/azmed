namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MODIFICAR_ORDEN_COMPRA : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ORDEN_COMPRA", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs");
            DropIndex("dbo.ORDEN_COMPRA", new[] { "COTIZACION_ID_COTIZACION" });
            AddColumn("dbo.ORDEN_COMPRA", "FECHA", c => c.DateTime(nullable: false));
            AddColumn("dbo.ORDEN_COMPRA", "ESTADO", c => c.String());
            DropColumn("dbo.ORDEN_COMPRA", "CANTIDAD");
            DropColumn("dbo.ORDEN_COMPRA", "COTIZACION_ID_COTIZACION");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ORDEN_COMPRA", "COTIZACION_ID_COTIZACION", c => c.Int());
            AddColumn("dbo.ORDEN_COMPRA", "CANTIDAD", c => c.Int(nullable: false));
            DropColumn("dbo.ORDEN_COMPRA", "ESTADO");
            DropColumn("dbo.ORDEN_COMPRA", "FECHA");
            CreateIndex("dbo.ORDEN_COMPRA", "COTIZACION_ID_COTIZACION");
            AddForeignKey("dbo.ORDEN_COMPRA", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs", "ID_COTIZACION");
        }
    }
}
