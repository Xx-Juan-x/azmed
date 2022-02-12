namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ACTUALIZACIONENTEROS : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OBRA_SOCIAL", "CUIL", c => c.Long(nullable: false));
            AlterColumn("dbo.OBRA_SOCIAL", "CONTACTO", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OBRA_SOCIAL", "CONTACTO", c => c.Int(nullable: false));
            AlterColumn("dbo.OBRA_SOCIAL", "CUIL", c => c.Int(nullable: false));
        }
    }
}
