namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AGREGO_TABLA_GRUPO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GRUPOes",
                c => new
                    {
                        ID_GRUPO = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        ESTADO = c.String(),
                    })
                .PrimaryKey(t => t.ID_GRUPO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GRUPOes");
        }
    }
}
