namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BORRO_ESPECIALIDAD_ATRIBUTO : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ATENCIONs", "ESPECIALIDADES_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs");
            DropIndex("dbo.ATENCIONs", new[] { "ESPECIALIDADES_ID_ESPECIALIDAD" });
            DropColumn("dbo.ATENCIONs", "ESPECIALIDADES_ID_ESPECIALIDAD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ATENCIONs", "ESPECIALIDADES_ID_ESPECIALIDAD", c => c.Int());
            CreateIndex("dbo.ATENCIONs", "ESPECIALIDADES_ID_ESPECIALIDAD");
            AddForeignKey("dbo.ATENCIONs", "ESPECIALIDADES_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs", "ID_ESPECIALIDAD");
        }
    }
}
