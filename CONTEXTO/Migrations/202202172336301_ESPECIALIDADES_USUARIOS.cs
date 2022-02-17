namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ESPECIALIDADES_USUARIOS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD", c => c.Int());
            CreateIndex("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD");
            AddForeignKey("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs", "ID_ESPECIALIDAD");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs");
            DropIndex("dbo.USUARIOs", new[] { "ESPECIALIDADES_ID_ESPECIALIDAD" });
            DropColumn("dbo.USUARIOs", "ESPECIALIDADES_ID_ESPECIALIDAD");
        }
    }
}
