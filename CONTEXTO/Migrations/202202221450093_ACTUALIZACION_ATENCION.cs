namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ACTUALIZACION_ATENCION : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs");
            DropIndex("dbo.ATENCIONs", new[] { "PROFESIONAL_ID_USUARIO" });
            AddColumn("dbo.ATENCIONs", "PROFESIONAL", c => c.String());
            DropColumn("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", c => c.Int());
            DropColumn("dbo.ATENCIONs", "PROFESIONAL");
            CreateIndex("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO");
            AddForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
        }
    }
}
