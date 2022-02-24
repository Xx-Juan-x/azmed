namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ELIMINO_HORAS : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ATENCIONs", "HORA_INICIO");
            DropColumn("dbo.ATENCIONs", "HORA_FIN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ATENCIONs", "HORA_FIN", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.ATENCIONs", "HORA_INICIO", c => c.Time(nullable: false, precision: 7));
        }
    }
}
