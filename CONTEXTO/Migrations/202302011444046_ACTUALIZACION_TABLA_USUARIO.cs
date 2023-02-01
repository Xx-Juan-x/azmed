namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ACTUALIZACION_TABLA_USUARIO : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs");
            DropForeignKey("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL");
            DropForeignKey("dbo.USUARIOs", "PLAN_ID_PLAN", "dbo.PLANs");
            DropIndex("dbo.USUARIOs", new[] { "ESPECIALIDADES_ID_ESPECIALIDAD" });
            DropIndex("dbo.USUARIOs", new[] { "OBRA_SOCIAL_ID_OBRA_SOCIAL" });
            DropIndex("dbo.USUARIOs", new[] { "PLAN_ID_PLAN" });
            DropColumn("dbo.USUARIOs", "APELLIDO");
            DropColumn("dbo.USUARIOs", "TIPO");
            DropColumn("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD");
            DropColumn("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL");
            DropColumn("dbo.USUARIOs", "PLAN_ID_PLAN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.USUARIOs", "PLAN_ID_PLAN", c => c.Int());
            AddColumn("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL", c => c.Int());
            AddColumn("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD", c => c.Int());
            AddColumn("dbo.USUARIOs", "TIPO", c => c.String());
            AddColumn("dbo.USUARIOs", "APELLIDO", c => c.String());
            CreateIndex("dbo.USUARIOs", "PLAN_ID_PLAN");
            CreateIndex("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL");
            CreateIndex("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD");
            AddForeignKey("dbo.USUARIOs", "PLAN_ID_PLAN", "dbo.PLANs", "ID_PLAN");
            AddForeignKey("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL", "ID_OBRA_SOCIAL");
            AddForeignKey("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs", "ID_ESPECIALIDAD");
        }
    }
}
