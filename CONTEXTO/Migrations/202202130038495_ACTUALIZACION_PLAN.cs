namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ACTUALIZACION_PLAN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PLANs", "TIPO_OBRA_SOCIAL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PLANs", "TIPO_OBRA_SOCIAL");
        }
    }
}
