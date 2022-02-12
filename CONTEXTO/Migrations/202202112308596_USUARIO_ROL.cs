namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class USUARIO_ROL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ROLs",
                c => new
                    {
                        ID_ROL = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                    })
                .PrimaryKey(t => t.ID_ROL);
            
            CreateTable(
                "dbo.USUARIOs",
                c => new
                    {
                        ID_USUARIO = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        APELLIDO = c.String(),
                        EMAIL = c.String(),
                        CLAVE = c.String(),
                        FECHA = c.DateTime(nullable: false),
                        ROL_ID_ROL = c.Int(),
                    })
                .PrimaryKey(t => t.ID_USUARIO)
                .ForeignKey("dbo.ROLs", t => t.ROL_ID_ROL)
                .Index(t => t.ROL_ID_ROL);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.USUARIOs", "ROL_ID_ROL", "dbo.ROLs");
            DropIndex("dbo.USUARIOs", new[] { "ROL_ID_ROL" });
            DropTable("dbo.USUARIOs");
            DropTable("dbo.ROLs");
        }
    }
}
