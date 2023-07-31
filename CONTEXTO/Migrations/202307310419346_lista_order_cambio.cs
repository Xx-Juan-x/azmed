namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lista_order_cambio : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LISTA_COMPRA", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs");
            DropIndex("dbo.LISTA_COMPRA", new[] { "COTIZACION_ID_COTIZACION" });
            AddColumn("dbo.LISTA_COMPRA", "LISTA_COTIZACION_ID_LISTA_COTIZACION", c => c.Int());
            CreateIndex("dbo.LISTA_COMPRA", "LISTA_COTIZACION_ID_LISTA_COTIZACION");
            AddForeignKey("dbo.LISTA_COMPRA", "LISTA_COTIZACION_ID_LISTA_COTIZACION", "dbo.LISTA_COTIZACION", "ID_LISTA_COTIZACION");
            DropColumn("dbo.LISTA_COMPRA", "COTIZACION_ID_COTIZACION");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LISTA_COMPRA", "COTIZACION_ID_COTIZACION", c => c.Int());
            DropForeignKey("dbo.LISTA_COMPRA", "LISTA_COTIZACION_ID_LISTA_COTIZACION", "dbo.LISTA_COTIZACION");
            DropIndex("dbo.LISTA_COMPRA", new[] { "LISTA_COTIZACION_ID_LISTA_COTIZACION" });
            DropColumn("dbo.LISTA_COMPRA", "LISTA_COTIZACION_ID_LISTA_COTIZACION");
            CreateIndex("dbo.LISTA_COMPRA", "COTIZACION_ID_COTIZACION");
            AddForeignKey("dbo.LISTA_COMPRA", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs", "ID_COTIZACION");
        }
    }
}
