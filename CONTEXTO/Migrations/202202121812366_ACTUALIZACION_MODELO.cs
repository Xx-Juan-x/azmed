namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ACTUALIZACION_MODELO : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OBRA_SOCIAL", "CONTACTO", c => c.Int(nullable: false));
            DropColumn("dbo.ESPECIALIDADs", "PRECIO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ESPECIALIDADs", "PRECIO", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.OBRA_SOCIAL", "CONTACTO", c => c.String());
        }
    }
}
