namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AGREGO_PROPIEDAD_EMAIL_AUDITORIA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AUDITORIA_USUARIO", "EMAIL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AUDITORIA_USUARIO", "EMAIL");
        }
    }
}
