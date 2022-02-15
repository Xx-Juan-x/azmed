namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ELIMINAR_ROL : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ROLs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ROLs",
                c => new
                    {
                        ID_ROL = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                    })
                .PrimaryKey(t => t.ID_ROL);
            
        }
    }
}
