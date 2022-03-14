namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIO_VARIABLE_TURNO : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TURNOes", "DIA", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TURNOes", "DIA", c => c.Int(nullable: false));
        }
    }
}
