namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IMPORTE_ESPECIALIDAD : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ESPECIALIDADs", "IMPORTE_CONSULTA", c => c.Double(nullable: false));
            AddColumn("dbo.ESPECIALIDADs", "IMPORTE_ESTUDIO", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ESPECIALIDADs", "IMPORTE_ESTUDIO");
            DropColumn("dbo.ESPECIALIDADs", "IMPORTE_CONSULTA");
        }
    }
}
