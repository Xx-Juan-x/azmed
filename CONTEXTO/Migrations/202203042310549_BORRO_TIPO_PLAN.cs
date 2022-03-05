namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BORRO_TIPO_PLAN : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PLANs", "TIPO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PLANs", "TIPO", c => c.Int(nullable: false));
        }
    }
}
