namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TABLA_ACCIONES_GRUPOS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ACCIONES_GRUPOS",
                c => new
                    {
                        ID_ACCION_GRUPO = c.Int(nullable: false, identity: true),
                        ACCION_ID_ACCIONES = c.Int(),
                        GRUPO_ID_GRUPO = c.Int(),
                    })
                .PrimaryKey(t => t.ID_ACCION_GRUPO)
                .ForeignKey("dbo.ACCIONES", t => t.ACCION_ID_ACCIONES)
                .ForeignKey("dbo.GRUPOes", t => t.GRUPO_ID_GRUPO)
                .Index(t => t.ACCION_ID_ACCIONES)
                .Index(t => t.GRUPO_ID_GRUPO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ACCIONES_GRUPOS", "GRUPO_ID_GRUPO", "dbo.GRUPOes");
            DropForeignKey("dbo.ACCIONES_GRUPOS", "ACCION_ID_ACCIONES", "dbo.ACCIONES");
            DropIndex("dbo.ACCIONES_GRUPOS", new[] { "GRUPO_ID_GRUPO" });
            DropIndex("dbo.ACCIONES_GRUPOS", new[] { "ACCION_ID_ACCIONES" });
            DropTable("dbo.ACCIONES_GRUPOS");
        }
    }
}
