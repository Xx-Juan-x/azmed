namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DESCUENTO_PLAN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PLANs", "DESCUENTO_CONSULTA", c => c.Double(nullable: false));
            AddColumn("dbo.PLANs", "DESCUENTO_ESTUDIO", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PLANs", "DESCUENTO_ESTUDIO");
            DropColumn("dbo.PLANs", "DESCUENTO_CONSULTA");
        }
    }
}
