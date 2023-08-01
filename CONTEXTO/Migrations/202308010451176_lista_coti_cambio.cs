namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lista_coti_cambio : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs");
            DropIndex("dbo.LISTA_COTIZACION", new[] { "COTIZACION_ID_COTIZACION" });
            AlterColumn("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION", c => c.Int(nullable: false));
            CreateIndex("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION");
            AddForeignKey("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs", "ID_COTIZACION", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs");
            DropIndex("dbo.LISTA_COTIZACION", new[] { "COTIZACION_ID_COTIZACION" });
            AlterColumn("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION", c => c.Int());
            CreateIndex("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION");
            AddForeignKey("dbo.LISTA_COTIZACION", "COTIZACION_ID_COTIZACION", "dbo.COTIZACIONs", "ID_COTIZACION");
        }
    }
}
