namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AGREGO_TABLAS_PACIENTE_PROFESIONAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PROFESIONALs",
                c => new
                    {
                        ID_PROFESIONAL = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        APELLIDO = c.String(),
                        TELEFONO = c.String(),
                        EMAIL = c.String(),
                        FECHA = c.DateTime(nullable: false),
                        ESTADO = c.String(),
                        ESPECIALIDAD_ID_ESPECIALIDAD = c.Int(),
                    })
                .PrimaryKey(t => t.ID_PROFESIONAL)
                .ForeignKey("dbo.ESPECIALIDADs", t => t.ESPECIALIDAD_ID_ESPECIALIDAD)
                .Index(t => t.ESPECIALIDAD_ID_ESPECIALIDAD);
            
            CreateTable(
                "dbo.PACIENTEs",
                c => new
                    {
                        ID_PACIENTE = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        APELLIDO = c.String(),
                        TELEFONO = c.String(),
                        EMAIL = c.String(),
                        FECHA = c.DateTime(nullable: false),
                        ESTADO = c.String(),
                        OBRA_SOCIAL_ID_OBRA_SOCIAL = c.Int(),
                        PLAN_ID_PLAN = c.Int(),
                    })
                .PrimaryKey(t => t.ID_PACIENTE)
                .ForeignKey("dbo.OBRA_SOCIAL", t => t.OBRA_SOCIAL_ID_OBRA_SOCIAL)
                .ForeignKey("dbo.PLANs", t => t.PLAN_ID_PLAN)
                .Index(t => t.OBRA_SOCIAL_ID_OBRA_SOCIAL)
                .Index(t => t.PLAN_ID_PLAN);
            
            AddColumn("dbo.ATENCIONs", "PROFESIONAL_ID_PROFESIONAL", c => c.Int());
            AddColumn("dbo.TURNOes", "PACIENTE_ID_PACIENTE", c => c.Int());
            AddColumn("dbo.TURNOes", "PROFESIONAL_ID_PROFESIONAL", c => c.Int());
            CreateIndex("dbo.ATENCIONs", "PROFESIONAL_ID_PROFESIONAL");
            CreateIndex("dbo.TURNOes", "PACIENTE_ID_PACIENTE");
            CreateIndex("dbo.TURNOes", "PROFESIONAL_ID_PROFESIONAL");
            AddForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_PROFESIONAL", "dbo.PROFESIONALs", "ID_PROFESIONAL");
            AddForeignKey("dbo.TURNOes", "PACIENTE_ID_PACIENTE", "dbo.PACIENTEs", "ID_PACIENTE");
            AddForeignKey("dbo.TURNOes", "PROFESIONAL_ID_PROFESIONAL", "dbo.PROFESIONALs", "ID_PROFESIONAL");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TURNOes", "PROFESIONAL_ID_PROFESIONAL", "dbo.PROFESIONALs");
            DropForeignKey("dbo.TURNOes", "PACIENTE_ID_PACIENTE", "dbo.PACIENTEs");
            DropForeignKey("dbo.PACIENTEs", "PLAN_ID_PLAN", "dbo.PLANs");
            DropForeignKey("dbo.PACIENTEs", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL");
            DropForeignKey("dbo.ATENCIONs", "PROFESIONAL_ID_PROFESIONAL", "dbo.PROFESIONALs");
            DropForeignKey("dbo.PROFESIONALs", "ESPECIALIDAD_ID_ESPECIALIDAD", "dbo.ESPECIALIDADs");
            DropIndex("dbo.TURNOes", new[] { "PROFESIONAL_ID_PROFESIONAL" });
            DropIndex("dbo.TURNOes", new[] { "PACIENTE_ID_PACIENTE" });
            DropIndex("dbo.PACIENTEs", new[] { "PLAN_ID_PLAN" });
            DropIndex("dbo.PACIENTEs", new[] { "OBRA_SOCIAL_ID_OBRA_SOCIAL" });
            DropIndex("dbo.PROFESIONALs", new[] { "ESPECIALIDAD_ID_ESPECIALIDAD" });
            DropIndex("dbo.ATENCIONs", new[] { "PROFESIONAL_ID_PROFESIONAL" });
            DropColumn("dbo.TURNOes", "PROFESIONAL_ID_PROFESIONAL");
            DropColumn("dbo.TURNOes", "PACIENTE_ID_PACIENTE");
            DropColumn("dbo.ATENCIONs", "PROFESIONAL_ID_PROFESIONAL");
            DropTable("dbo.PACIENTEs");
            DropTable("dbo.PROFESIONALs");
        }
    }
}
