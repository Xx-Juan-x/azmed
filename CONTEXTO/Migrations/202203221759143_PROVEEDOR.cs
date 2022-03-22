namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PROVEEDOR : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PROVEEDORs",
                c => new
                    {
                        ID_PROVEEDOR = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        APELLIDO = c.String(),
                        CUIL = c.Long(nullable: false),
                        CONTACTO = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PROVEEDOR);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PROVEEDORs");
        }
    }
}
