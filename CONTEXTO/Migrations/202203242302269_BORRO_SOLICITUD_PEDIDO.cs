namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BORRO_SOLICITUD_PEDIDO : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LISTA_SOLICITUD_PEDIDO", "INSUMO_ID_MATERIAL", "dbo.MATERIALs");
            DropIndex("dbo.LISTA_SOLICITUD_PEDIDO", new[] { "INSUMO_ID_MATERIAL" });
            DropTable("dbo.LISTA_SOLICITUD_PEDIDO");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LISTA_SOLICITUD_PEDIDO",
                c => new
                    {
                        ID_PEDIDO = c.Int(nullable: false, identity: true),
                        INSUMO_ID_MATERIAL = c.Int(),
                    })
                .PrimaryKey(t => t.ID_PEDIDO);
            
            CreateIndex("dbo.LISTA_SOLICITUD_PEDIDO", "INSUMO_ID_MATERIAL");
            AddForeignKey("dbo.LISTA_SOLICITUD_PEDIDO", "INSUMO_ID_MATERIAL", "dbo.MATERIALs", "ID_MATERIAL");
        }
    }
}
