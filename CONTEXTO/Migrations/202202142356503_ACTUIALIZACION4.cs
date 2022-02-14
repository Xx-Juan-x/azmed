namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ACTUIALIZACION4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.USUARIOs", "FECHA", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.USUARIOs", "FECHA");
        }
    }
}
