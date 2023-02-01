namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ELIMINO_REFERENCIA_ATENCION_TURNO : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs");
            DropForeignKey("dbo.TURNOes", "PACIENTE_ID_USUARIO", "dbo.USUARIOs");
            DropForeignKey("dbo.TURNOes", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs");
            DropIndex("dbo.ATENCIONs", new[] { "PROFESIONAL_ID_USUARIO" });
            DropIndex("dbo.TURNOes", new[] { "PACIENTE_ID_USUARIO" });
            DropIndex("dbo.TURNOes", new[] { "PROFESIONAL_ID_USUARIO" });
            DropColumn("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO");
            DropColumn("dbo.TURNOes", "PACIENTE_ID_USUARIO");
            DropColumn("dbo.TURNOes", "PROFESIONAL_ID_USUARIO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TURNOes", "PROFESIONAL_ID_USUARIO", c => c.Int());
            AddColumn("dbo.TURNOes", "PACIENTE_ID_USUARIO", c => c.Int());
            AddColumn("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", c => c.Int());
            CreateIndex("dbo.TURNOes", "PROFESIONAL_ID_USUARIO");
            CreateIndex("dbo.TURNOes", "PACIENTE_ID_USUARIO");
            CreateIndex("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO");
            AddForeignKey("dbo.TURNOes", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
            AddForeignKey("dbo.TURNOes", "PACIENTE_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
            AddForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
        }
    }
}
