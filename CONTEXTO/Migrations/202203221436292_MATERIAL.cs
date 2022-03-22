namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MATERIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MATERIALs",
                c => new
                    {
                        ID_MATERIAL = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        DESCRIPCION = c.String(),
                        CANTIDAD = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_MATERIAL);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MATERIALs");
        }
    }
}
