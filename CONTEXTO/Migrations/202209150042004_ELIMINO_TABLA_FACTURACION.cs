namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ELIMINO_TABLA_FACTURACION : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FACTURACIONs", "OBRA_SOCIAL_ID_TURNO", "dbo.TURNOes");
            DropForeignKey("dbo.FACTURACIONs", "PACIENTE_ID_USUARIO", "dbo.USUARIOs");
            DropForeignKey("dbo.FACTURACIONs", "PLAN_ID_TURNO", "dbo.TURNOes");
            DropForeignKey("dbo.FACTURACIONs", "PROFESIONAL_ID_TURNO", "dbo.TURNOes");
            DropForeignKey("dbo.FACTURACIONs", "TIPO_ID_TURNO", "dbo.TURNOes");
            DropIndex("dbo.FACTURACIONs", new[] { "OBRA_SOCIAL_ID_TURNO" });
            DropIndex("dbo.FACTURACIONs", new[] { "PACIENTE_ID_USUARIO" });
            DropIndex("dbo.FACTURACIONs", new[] { "PLAN_ID_TURNO" });
            DropIndex("dbo.FACTURACIONs", new[] { "PROFESIONAL_ID_TURNO" });
            DropIndex("dbo.FACTURACIONs", new[] { "TIPO_ID_TURNO" });
            DropTable("dbo.FACTURACIONs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FACTURACIONs",
                c => new
                    {
                        NRO_LEGAJO = c.Int(nullable: false, identity: true),
                        FECHA = c.DateTime(nullable: false),
                        MONTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DESCUENTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ESTADO = c.String(),
                        PRECIO_FINAL = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OBRA_SOCIAL_ID_TURNO = c.Int(),
                        PACIENTE_ID_USUARIO = c.Int(),
                        PLAN_ID_TURNO = c.Int(),
                        PROFESIONAL_ID_TURNO = c.Int(),
                        TIPO_ID_TURNO = c.Int(),
                    })
                .PrimaryKey(t => t.NRO_LEGAJO);
            
            CreateIndex("dbo.FACTURACIONs", "TIPO_ID_TURNO");
            CreateIndex("dbo.FACTURACIONs", "PROFESIONAL_ID_TURNO");
            CreateIndex("dbo.FACTURACIONs", "PLAN_ID_TURNO");
            CreateIndex("dbo.FACTURACIONs", "PACIENTE_ID_USUARIO");
            CreateIndex("dbo.FACTURACIONs", "OBRA_SOCIAL_ID_TURNO");
            AddForeignKey("dbo.FACTURACIONs", "TIPO_ID_TURNO", "dbo.TURNOes", "ID_TURNO");
            AddForeignKey("dbo.FACTURACIONs", "PROFESIONAL_ID_TURNO", "dbo.TURNOes", "ID_TURNO");
            AddForeignKey("dbo.FACTURACIONs", "PLAN_ID_TURNO", "dbo.TURNOes", "ID_TURNO");
            AddForeignKey("dbo.FACTURACIONs", "PACIENTE_ID_USUARIO", "dbo.USUARIOs", "ID_USUARIO");
            AddForeignKey("dbo.FACTURACIONs", "OBRA_SOCIAL_ID_TURNO", "dbo.TURNOes", "ID_TURNO");
        }
    }
}
