namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PLAN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PLANs",
                c => new
                    {
                        ID_PLAN = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        TIPO = c.Int(nullable: false),
                        OBRA_SOCIAL_ID_OBRA_SOCIAL = c.Int(),
                    })
                .PrimaryKey(t => t.ID_PLAN)
                .ForeignKey("dbo.OBRA_SOCIAL", t => t.OBRA_SOCIAL_ID_OBRA_SOCIAL)
                .Index(t => t.OBRA_SOCIAL_ID_OBRA_SOCIAL);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PLANs", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL");
            DropIndex("dbo.PLANs", new[] { "OBRA_SOCIAL_ID_OBRA_SOCIAL" });
            DropTable("dbo.PLANs");
        }
    }
}
