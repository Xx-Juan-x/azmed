namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ATENCION : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ATENCIONs",
                c => new
                    {
                        ID_ATENCION = c.Int(nullable: false, identity: true),
                        HORA_INICIO = c.DateTime(nullable: false),
                        HORA_FIN = c.DateTime(nullable: false),
                        DIA_LABORAL = c.String(),
                        ESPECIALIDADES_ID_ESPECIALIDAD = c.Int(),
                        PROFESIONAL_ID_USUARIO = c.Int(),
                    })
                .PrimaryKey(t => t.ID_ATENCION)
                .ForeignKey("dbo.ESPECIALIDADs", t => t.ESPECIALIDADES_ID_ESPECIALIDAD)
                .ForeignKey("dbo.USUARIOs", t => t.PROFESIONAL_ID_USUARIO)
                .Index(t => t.ESPECIALIDADES_ID_ESPECIALIDAD)
                .Index(t => t.PROFESIONAL_ID_USUARIO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs");
            DropForeignKey("dbo.ATENCIONs", "ESPECIALIDADES_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs");
            DropIndex("dbo.ATENCIONs", new[] { "PROFESIONAL_ID_USUARIO" });
            DropIndex("dbo.ATENCIONs", new[] { "ESPECIALIDADES_ID_ESPECIALIDAD" });
            DropTable("dbo.ATENCIONs");
        }
    }
}
