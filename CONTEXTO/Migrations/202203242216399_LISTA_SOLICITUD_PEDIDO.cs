namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LISTA_SOLICITUD_PEDIDO : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SOLICITUD_PEDIDO", "INSUMO_ID_MATERIAL", "dbo.MATERIALs");
            DropForeignKey("dbo.COTIZACIONs", "PEDIDO_ID_PEDIDO", "dbo.SOLICITUD_PEDIDO");
            DropIndex("dbo.COTIZACIONs", new[] { "PEDIDO_ID_PEDIDO" });
            DropIndex("dbo.SOLICITUD_PEDIDO", new[] { "INSUMO_ID_MATERIAL" });
            CreateTable(
                "dbo.LISTA_SOLICITUD_PEDIDO",
                c => new
                    {
                        ID_PEDIDO = c.Int(nullable: false, identity: true),
                        INSUMO_ID_MATERIAL = c.Int(),
                    })
                .PrimaryKey(t => t.ID_PEDIDO)
                .ForeignKey("dbo.MATERIALs", t => t.INSUMO_ID_MATERIAL)
                .Index(t => t.INSUMO_ID_MATERIAL);
            
            DropColumn("dbo.COTIZACIONs", "PEDIDO_ID_PEDIDO");
            DropTable("dbo.SOLICITUD_PEDIDO");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SOLICITUD_PEDIDO",
                c => new
                    {
                        ID_PEDIDO = c.Int(nullable: false, identity: true),
                        FECHA = c.DateTime(nullable: false),
                        ESTADO = c.String(),
                        CANTIDAD = c.Int(nullable: false),
                        INSUMO_ID_MATERIAL = c.Int(),
                    })
                .PrimaryKey(t => t.ID_PEDIDO);
            
            AddColumn("dbo.COTIZACIONs", "PEDIDO_ID_PEDIDO", c => c.Int());
            DropForeignKey("dbo.LISTA_SOLICITUD_PEDIDO", "INSUMO_ID_MATERIAL", "dbo.MATERIALs");
            DropIndex("dbo.LISTA_SOLICITUD_PEDIDO", new[] { "INSUMO_ID_MATERIAL" });
            DropTable("dbo.LISTA_SOLICITUD_PEDIDO");
            CreateIndex("dbo.SOLICITUD_PEDIDO", "INSUMO_ID_MATERIAL");
            CreateIndex("dbo.COTIZACIONs", "PEDIDO_ID_PEDIDO");
            AddForeignKey("dbo.COTIZACIONs", "PEDIDO_ID_PEDIDO", "dbo.SOLICITUD_PEDIDO", "ID_PEDIDO");
            AddForeignKey("dbo.SOLICITUD_PEDIDO", "INSUMO_ID_MATERIAL", "dbo.MATERIALs", "ID_MATERIAL");
        }
    }
}
