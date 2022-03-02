namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FACTURACION : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FACTURACIONs",
                c => new
                    {
                        NRO_LEGAJO = c.Int(nullable: false, identity: true),
                        FECHA = c.DateTime(nullable: false),
                        MONTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DESCUENTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PRECIO_FINAL = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OBRA_SOCIAL_ID_TURNO = c.Int(),
                        PACIENTE_ID_USUARIO = c.Int(),
                        PLAN_ID_TURNO = c.Int(),
                        PROFESIONAL_ID_TURNO = c.Int(),
                        TIPO_ID_TURNO = c.Int(),
                    })
                .PrimaryKey(t => t.NRO_LEGAJO)
                .ForeignKey("dbo.TURNOes", t => t.OBRA_SOCIAL_ID_TURNO)
                .ForeignKey("dbo.USUARIOs", t => t.PACIENTE_ID_USUARIO)
                .ForeignKey("dbo.TURNOes", t => t.PLAN_ID_TURNO)
                .ForeignKey("dbo.TURNOes", t => t.PROFESIONAL_ID_TURNO)
                .ForeignKey("dbo.TURNOes", t => t.TIPO_ID_TURNO)
                .Index(t => t.OBRA_SOCIAL_ID_TURNO)
                .Index(t => t.PACIENTE_ID_USUARIO)
                .Index(t => t.PLAN_ID_TURNO)
                .Index(t => t.PROFESIONAL_ID_TURNO)
                .Index(t => t.TIPO_ID_TURNO);
            
            AddColumn("dbo.TURNOes", "FECHA", c => c.DateTime(nullable: false));
            AddColumn("dbo.TURNOes", "TIPO", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FACTURACIONs", "TIPO_ID_TURNO", "dbo.TURNOes");
            DropForeignKey("dbo.FACTURACIONs", "PROFESIONAL_ID_TURNO", "dbo.TURNOes");
            DropForeignKey("dbo.FACTURACIONs", "PLAN_ID_TURNO", "dbo.TURNOes");
            DropForeignKey("dbo.FACTURACIONs", "PACIENTE_ID_USUARIO", "dbo.USUARIOs");
            DropForeignKey("dbo.FACTURACIONs", "OBRA_SOCIAL_ID_TURNO", "dbo.TURNOes");
            DropIndex("dbo.FACTURACIONs", new[] { "TIPO_ID_TURNO" });
            DropIndex("dbo.FACTURACIONs", new[] { "PROFESIONAL_ID_TURNO" });
            DropIndex("dbo.FACTURACIONs", new[] { "PLAN_ID_TURNO" });
            DropIndex("dbo.FACTURACIONs", new[] { "PACIENTE_ID_USUARIO" });
            DropIndex("dbo.FACTURACIONs", new[] { "OBRA_SOCIAL_ID_TURNO" });
            DropColumn("dbo.TURNOes", "TIPO");
            DropColumn("dbo.TURNOes", "FECHA");
            DropTable("dbo.FACTURACIONs");
        }
    }
}
