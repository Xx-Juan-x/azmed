namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CORRECCION_ATRIBUTO_GRUPO : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.USUARIOs", name: "ROL_ID_GRUPO", newName: "GRUPO_ID_GRUPO");
            RenameIndex(table: "dbo.USUARIOs", name: "IX_ROL_ID_GRUPO", newName: "IX_GRUPO_ID_GRUPO");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.USUARIOs", name: "IX_GRUPO_ID_GRUPO", newName: "IX_ROL_ID_GRUPO");
            RenameColumn(table: "dbo.USUARIOs", name: "GRUPO_ID_GRUPO", newName: "ROL_ID_GRUPO");
        }
    }
}
