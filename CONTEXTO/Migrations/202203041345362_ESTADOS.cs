namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ESTADOS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FACTURACIONs", "ESTADO", c => c.String());
            AddColumn("dbo.TURNOes", "ESTADO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TURNOes", "ESTADO");
            DropColumn("dbo.FACTURACIONs", "ESTADO");
        }
    }
}
