namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ESTADO_USUARIO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.USUARIOs", "ESTADO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.USUARIOs", "ESTADO");
        }
    }
}
