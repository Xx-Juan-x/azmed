namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ESPECIALIDADs",
                c => new
                    {
                        ID_ESPECIALIDAD = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        PRECIO = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID_ESPECIALIDAD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ESPECIALIDADs");
        }
    }
}
