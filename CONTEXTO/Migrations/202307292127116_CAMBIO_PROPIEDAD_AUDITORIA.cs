namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIO_PROPIEDAD_AUDITORIA : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AUDITORIAs", "USUARIO_ID_USUARIO", "dbo.USUARIOs");
            DropIndex("dbo.AUDITORIAs", new[] { "USUARIO_ID_USUARIO" });
            AddColumn("dbo.AUDITORIAs", "USUARIO", c => c.String());
            DropColumn("dbo.AUDITORIAs", "USUARIO_ID_USUARIO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AUDITORIAs", "USUARIO_ID_USUARIO", c => c.Int());
            DropColumn("dbo.AUDITORIAs", "USUARIO");
            CreateIndex("dbo.AUDITORIAs", "USUARIO_ID_USUARIO");
            AddForeignKey("dbo.AUDITORIAs", "USUARIO_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
        }
    }
}
