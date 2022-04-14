namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ATENCION_ESTADO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ATENCIONs", "ESTADO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ATENCIONs", "ESTADO");
        }
    }
}
