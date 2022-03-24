namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SOLICITUD_PEDIDO : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.ID_PEDIDO)
                .ForeignKey("dbo.MATERIALs", t => t.INSUMO_ID_MATERIAL)
                .Index(t => t.INSUMO_ID_MATERIAL);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SOLICITUD_PEDIDO", "INSUMO_ID_MATERIAL", "dbo.MATERIALs");
            DropIndex("dbo.SOLICITUD_PEDIDO", new[] { "INSUMO_ID_MATERIAL" });
            DropTable("dbo.SOLICITUD_PEDIDO");
        }
    }
}
