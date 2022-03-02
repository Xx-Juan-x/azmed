namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TURNOS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TURNOes",
                c => new
                    {
                        ID_TURNO = c.Int(nullable: false, identity: true),
                        HORA_TURNO = c.Int(nullable: false),
                        DIA = c.Int(nullable: false),
                        ESPECIALIDAD_ID_ESPECIALIDAD = c.Int(),
                        OBRA_SOCIAL_ID_OBRA_SOCIAL = c.Int(),
                        PACIENTE_ID_USUARIO = c.Int(),
                        PLAN_ID_PLAN = c.Int(),
                        PROFESIONAL_ID_USUARIO = c.Int(),
                    })
                .PrimaryKey(t => t.ID_TURNO)
                .ForeignKey("dbo.ESPECIALIDADs", t => t.ESPECIALIDAD_ID_ESPECIALIDAD)
                .ForeignKey("dbo.OBRA_SOCIAL", t => t.OBRA_SOCIAL_ID_OBRA_SOCIAL)
                .ForeignKey("dbo.USUARIOs", t => t.PACIENTE_ID_USUARIO)
                .ForeignKey("dbo.PLANs", t => t.PLAN_ID_PLAN)
                .ForeignKey("dbo.USUARIOs", t => t.PROFESIONAL_ID_USUARIO)
                .Index(t => t.ESPECIALIDAD_ID_ESPECIALIDAD)
                .Index(t => t.OBRA_SOCIAL_ID_OBRA_SOCIAL)
                .Index(t => t.PACIENTE_ID_USUARIO)
                .Index(t => t.PLAN_ID_PLAN)
                .Index(t => t.PROFESIONAL_ID_USUARIO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TURNOes", "PROFESIONAL_ID_USUARIO", "dbo.USUARIOs");
            DropForeignKey("dbo.TURNOes", "PLAN_ID_PLAN", "dbo.PLANs");
            DropForeignKey("dbo.TURNOes", "PACIENTE_ID_USUARIO", "dbo.USUARIOs");
            DropForeignKey("dbo.TURNOes", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL");
            DropForeignKey("dbo.TURNOes", "ESPECIALIDAD_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs");
            DropIndex("dbo.TURNOes", new[] { "PROFESIONAL_ID_USUARIO" });
            DropIndex("dbo.TURNOes", new[] { "PLAN_ID_PLAN" });
            DropIndex("dbo.TURNOes", new[] { "PACIENTE_ID_USUARIO" });
            DropIndex("dbo.TURNOes", new[] { "OBRA_SOCIAL_ID_OBRA_SOCIAL" });
            DropIndex("dbo.TURNOes", new[] { "ESPECIALIDAD_ID_ESPECIALIDAD" });
            DropTable("dbo.TURNOes");
        }
    }
}
