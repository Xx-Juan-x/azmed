namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ESPECIALIDAD_ATENCION : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ATENCIONs", "ESPECIALIDAD_ID_ESPECIALIDAD", c => c.Int());
            CreateIndex("dbo.ATENCIONs", "ESPECIALIDAD_ID_ESPECIALIDAD");
            AddForeignKey("dbo.ATENCIONs", "ESPECIALIDAD_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs", "ID_ESPECIALIDAD");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ATENCIONs", "ESPECIALIDAD_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs");
            DropIndex("dbo.ATENCIONs", new[] { "ESPECIALIDAD_ID_ESPECIALIDAD" });
            DropColumn("dbo.ATENCIONs", "ESPECIALIDAD_ID_ESPECIALIDAD");
        }
    }
}
