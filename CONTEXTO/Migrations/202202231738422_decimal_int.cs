namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class decimal_int : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ATENCIONs", "HORA_INICIO", c => c.Int(nullable: false));
            AlterColumn("dbo.ATENCIONs", "HORA_FIN", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ATENCIONs", "HORA_FIN", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ATENCIONs", "HORA_INICIO", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
