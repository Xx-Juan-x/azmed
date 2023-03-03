namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usuariocambios : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PROFESIONALs", "USUARIO_ID_USUARIO", "dbo.USUARIOs");
            DropIndex("dbo.PROFESIONALs", new[] { "USUARIO_ID_USUARIO" });
            AddColumn("dbo.USUARIOs", "PROFESIONAL_ID_PROFESIONAL", c => c.Int());
            CreateIndex("dbo.USUARIOs", "PROFESIONAL_ID_PROFESIONAL");
            AddForeignKey("dbo.USUARIOs", "PROFESIONAL_ID_PROFESIONAL", "dbo.PROFESIONALs", "ID_PROFESIONAL");
            DropColumn("dbo.PROFESIONALs", "USUARIO_ID_USUARIO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PROFESIONALs", "USUARIO_ID_USUARIO", c => c.Int());
            DropForeignKey("dbo.USUARIOs", "PROFESIONAL_ID_PROFESIONAL", "dbo.PROFESIONALs");
            DropIndex("dbo.USUARIOs", new[] { "PROFESIONAL_ID_PROFESIONAL" });
            DropColumn("dbo.USUARIOs", "PROFESIONAL_ID_PROFESIONAL");
            CreateIndex("dbo.PROFESIONALs", "USUARIO_ID_USUARIO");
            AddForeignKey("dbo.PROFESIONALs", "USUARIO_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
        }
    }
}
