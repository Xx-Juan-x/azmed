namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class profesionalyusuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PROFESIONALs", "USUARIO_ID_USUARIO", c => c.Int());
            CreateIndex("dbo.PROFESIONALs", "USUARIO_ID_USUARIO");
            AddForeignKey("dbo.PROFESIONALs", "USUARIO_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PROFESIONALs", "USUARIO_ID_USUARIO", "dbo.USUARIOs");
            DropIndex("dbo.PROFESIONALs", new[] { "USUARIO_ID_USUARIO" });
            DropColumn("dbo.PROFESIONALs", "USUARIO_ID_USUARIO");
        }
    }
}
