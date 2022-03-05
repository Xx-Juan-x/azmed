namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PLAN_OBRA_SOCIAL_PACIENTE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL", c => c.Int());
            AddColumn("dbo.USUARIOs", "PLAN_ID_PLAN", c => c.Int());
            CreateIndex("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL");
            CreateIndex("dbo.USUARIOs", "PLAN_ID_PLAN");
            AddForeignKey("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL", "ID_OBRA_SOCIAL");
            AddForeignKey("dbo.USUARIOs", "PLAN_ID_PLAN", "dbo.PLANs", "ID_PLAN");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.USUARIOs", "PLAN_ID_PLAN", "dbo.PLANs");
            DropForeignKey("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL");
            DropIndex("dbo.USUARIOs", new[] { "PLAN_ID_PLAN" });
            DropIndex("dbo.USUARIOs", new[] { "OBRA_SOCIAL_ID_OBRA_SOCIAL" });
            DropColumn("dbo.USUARIOs", "PLAN_ID_PLAN");
            DropColumn("dbo.USUARIOs", "OBRA_SOCIAL_ID_OBRA_SOCIAL");
        }
    }
}
