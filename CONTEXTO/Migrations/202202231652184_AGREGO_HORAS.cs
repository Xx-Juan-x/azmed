namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AGREGO_HORAS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ATENCIONs", "HORA_INICIO", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ATENCIONs", "HORA_FIN", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ATENCIONs", "HORA_FIN");
            DropColumn("dbo.ATENCIONs", "HORA_INICIO");
        }
    }
}
