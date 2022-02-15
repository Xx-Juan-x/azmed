namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ELIMINAR_IDROL : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.USUARIOs", "ROL_ID_ROL", "dbo.ROLs");
            DropIndex("dbo.USUARIOs", new[] { "ROL_ID_ROL" });
            DropColumn("dbo.USUARIOs", "ROL_ID_ROL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.USUARIOs", "ROL_ID_ROL", c => c.Int());
            CreateIndex("dbo.USUARIOs", "ROL_ID_ROL");
            AddForeignKey("dbo.USUARIOs", "ROL_ID_ROL", "dbo.ROLs", "ID_ROL");
        }
    }
}
