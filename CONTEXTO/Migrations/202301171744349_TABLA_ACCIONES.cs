namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TABLA_ACCIONES : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ACCIONES",
                c => new
                    {
                        ID_ACCIONES = c.Int(nullable: false, identity: true),
                        ACCION = c.String(),
                        DESCRIPCION = c.String(),
                    })
                .PrimaryKey(t => t.ID_ACCIONES);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ACCIONES");
        }
    }
}
