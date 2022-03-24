namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MODIFICACION_MATERIAL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MATERIALs", "STOCK", c => c.Int(nullable: false));
            DropColumn("dbo.MATERIALs", "CANTIDAD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MATERIALs", "CANTIDAD", c => c.Int(nullable: false));
            DropColumn("dbo.MATERIALs", "STOCK");
        }
    }
}
