namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AGREGO_LISTA_Y_PEDIDO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SOLICITUD_PEDIDO",
                c => new
                    {
                        ID_SOLICITUD_PEDIDO = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        FECHA = c.DateTime(nullable: false),
                        ESTADO = c.String(),
                    })
                .PrimaryKey(t => t.ID_SOLICITUD_PEDIDO);
            
            CreateTable(
                "dbo.LISTA_PEDIDO",
                c => new
                    {
                        ID_LISTA_PEDIDO = c.Int(nullable: false, identity: true),
                        INSUMO_ID_MATERIAL = c.Int(),
                        PEDIDO_ID_SOLICITUD_PEDIDO = c.Int(),
                    })
                .PrimaryKey(t => t.ID_LISTA_PEDIDO)
                .ForeignKey("dbo.MATERIALs", t => t.INSUMO_ID_MATERIAL)
                .ForeignKey("dbo.SOLICITUD_PEDIDO", t => t.PEDIDO_ID_SOLICITUD_PEDIDO)
                .Index(t => t.INSUMO_ID_MATERIAL)
                .Index(t => t.PEDIDO_ID_SOLICITUD_PEDIDO);
            
            AddColumn("dbo.COTIZACIONs", "PEDIDO_ID_SOLICITUD_PEDIDO", c => c.Int());
            CreateIndex("dbo.COTIZACIONs", "PEDIDO_ID_SOLICITUD_PEDIDO");
            AddForeignKey("dbo.COTIZACIONs", "PEDIDO_ID_SOLICITUD_PEDIDO", "dbo.SOLICITUD_PEDIDO", "ID_SOLICITUD_PEDIDO");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LISTA_PEDIDO", "PEDIDO_ID_SOLICITUD_PEDIDO", "dbo.SOLICITUD_PEDIDO");
            DropForeignKey("dbo.LISTA_PEDIDO", "INSUMO_ID_MATERIAL", "dbo.MATERIALs");
            DropForeignKey("dbo.COTIZACIONs", "PEDIDO_ID_SOLICITUD_PEDIDO", "dbo.SOLICITUD_PEDIDO");
            DropIndex("dbo.LISTA_PEDIDO", new[] { "PEDIDO_ID_SOLICITUD_PEDIDO" });
            DropIndex("dbo.LISTA_PEDIDO", new[] { "INSUMO_ID_MATERIAL" });
            DropIndex("dbo.COTIZACIONs", new[] { "PEDIDO_ID_SOLICITUD_PEDIDO" });
            DropColumn("dbo.COTIZACIONs", "PEDIDO_ID_SOLICITUD_PEDIDO");
            DropTable("dbo.LISTA_PEDIDO");
            DropTable("dbo.SOLICITUD_PEDIDO");
        }
    }
}
