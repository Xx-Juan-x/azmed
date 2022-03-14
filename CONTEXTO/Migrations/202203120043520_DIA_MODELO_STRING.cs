namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DIA_MODELO_STRING : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TURNOes", "DIA", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TURNOes", "DIA", c => c.DateTime(nullable: false));
        }
    }
}
