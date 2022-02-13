namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ACTUALIZACION_PLAN3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PLANs", "TIPO_OBRA_SOCIAL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PLANs", "TIPO_OBRA_SOCIAL", c => c.String());
        }
    }
}
