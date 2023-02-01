namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AGREGO_ATRIBUTO_GRUPO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.USUARIOs", "ROL_ID_GRUPO", c => c.Int());
            CreateIndex("dbo.USUARIOs", "ROL_ID_GRUPO");
            AddForeignKey("dbo.USUARIOs", "ROL_ID_GRUPO", "dbo.GRUPOes", "ID_GRUPO");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.USUARIOs", "ROL_ID_GRUPO", "dbo.GRUPOes");
            DropIndex("dbo.USUARIOs", new[] { "ROL_ID_GRUPO" });
            DropColumn("dbo.USUARIOs", "ROL_ID_GRUPO");
        }
    }
}
