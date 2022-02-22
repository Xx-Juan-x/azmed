namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ATENCION_USUARIO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", c => c.Int());
            CreateIndex("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO");
            AddForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
            DropColumn("dbo.ATENCIONs", "PROFESIONAL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ATENCIONs", "PROFESIONAL", c => c.String());
            DropForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs");
            DropIndex("dbo.ATENCIONs", new[] { "PROFESIONAL_ID_USUARIO" });
            DropColumn("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO");
        }
    }
}
