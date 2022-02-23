namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DATETIME_ATENCION : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ATENCIONs", "HORA_INICIO", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ATENCIONs", "HORA_FIN", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ATENCIONs", "HORA_FIN", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.ATENCIONs", "HORA_INICIO", c => c.Time(nullable: false, precision: 7));
        }
    }
}
