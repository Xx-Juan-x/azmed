namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizadoturnos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TURNOes", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL");
            DropForeignKey("dbo.TURNOes", "PLAN_ID_PLAN", "dbo.PLANs");
            DropIndex("dbo.TURNOes", new[] { "OBRA_SOCIAL_ID_OBRA_SOCIAL" });
            DropIndex("dbo.TURNOes", new[] { "PLAN_ID_PLAN" });
            DropColumn("dbo.TURNOes", "OBRA_SOCIAL_ID_OBRA_SOCIAL");
            DropColumn("dbo.TURNOes", "PLAN_ID_PLAN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TURNOes", "PLAN_ID_PLAN", c => c.Int());
            AddColumn("dbo.TURNOes", "OBRA_SOCIAL_ID_OBRA_SOCIAL", c => c.Int());
            CreateIndex("dbo.TURNOes", "PLAN_ID_PLAN");
            CreateIndex("dbo.TURNOes", "OBRA_SOCIAL_ID_OBRA_SOCIAL");
            AddForeignKey("dbo.TURNOes", "PLAN_ID_PLAN", "dbo.PLANs", "ID_PLAN");
            AddForeignKey("dbo.TURNOes", "OBRA_SOCIAL_ID_OBRA_SOCIAL", "dbo.OBRA_SOCIAL", "ID_OBRA_SOCIAL");
        }
    }
}
