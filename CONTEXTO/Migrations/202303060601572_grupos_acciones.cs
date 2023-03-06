namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class grupos_acciones : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ACCIONES_GRUPOS", "GRUPO_ID_GRUPO", "dbo.GRUPOes");
            DropIndex("dbo.ACCIONES_GRUPOS", new[] { "GRUPO_ID_GRUPO" });
            AlterColumn("dbo.ACCIONES_GRUPOS", "GRUPO_ID_GRUPO", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ACCIONES_GRUPOS", "GRUPO_ID_GRUPO", c => c.Int());
            CreateIndex("dbo.ACCIONES_GRUPOS", "GRUPO_ID_GRUPO");
            AddForeignKey("dbo.ACCIONES_GRUPOS", "GRUPO_ID_GRUPO", "dbo.GRUPOes", "ID_GRUPO");
        }
    }
}
