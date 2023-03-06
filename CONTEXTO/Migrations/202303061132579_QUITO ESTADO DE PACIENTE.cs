namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QUITOESTADODEPACIENTE : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PACIENTEs", "ESTADO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PACIENTEs", "ESTADO", c => c.String());
        }
    }
}
