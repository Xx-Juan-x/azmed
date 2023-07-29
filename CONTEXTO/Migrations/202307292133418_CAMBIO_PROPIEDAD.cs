namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIO_PROPIEDAD : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AUDITORIAs", "USUARIO_ID_USUARIO", c => c.Int());
            CreateIndex("dbo.AUDITORIAs", "USUARIO_ID_USUARIO");
            AddForeignKey("dbo.AUDITORIAs", "USUARIO_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
            DropColumn("dbo.AUDITORIAs", "USUARIO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AUDITORIAs", "USUARIO", c => c.String());
            DropForeignKey("dbo.AUDITORIAs", "USUARIO_ID_USUARIO", "dbo.USUARIOs");
            DropIndex("dbo.AUDITORIAs", new[] { "USUARIO_ID_USUARIO" });
            DropColumn("dbo.AUDITORIAs", "USUARIO_ID_USUARIO");
        }
    }
}
