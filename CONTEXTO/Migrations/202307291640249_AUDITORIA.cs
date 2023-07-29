namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AUDITORIA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AUDITORIAs",
                c => new
                    {
                        ID_AUDITORIA = c.Int(nullable: false, identity: true),
                        FECHA_HORA = c.DateTime(nullable: false),
                        ACCION = c.String(),
                        DATOS_REGISTRADOS = c.String(),
                        USUARIO_ID_USUARIO = c.Int(),
                    })
                .PrimaryKey(t => t.ID_AUDITORIA)
                .ForeignKey("dbo.USUARIOs", t => t.USUARIO_ID_USUARIO)
                .Index(t => t.USUARIO_ID_USUARIO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AUDITORIAs", "USUARIO_ID_USUARIO", "dbo.USUARIOs");
            DropIndex("dbo.AUDITORIAs", new[] { "USUARIO_ID_USUARIO" });
            DropTable("dbo.AUDITORIAs");
        }
    }
}
