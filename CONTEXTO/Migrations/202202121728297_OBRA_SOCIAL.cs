namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OBRA_SOCIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OBRA_SOCIAL",
                c => new
                    {
                        ID_OBRA_SOCIAL = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        CUIL = c.Int(nullable: false),
                        CONTACTO = c.String(),
                    })
                .PrimaryKey(t => t.ID_OBRA_SOCIAL);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OBRA_SOCIAL");
        }
    }
}
