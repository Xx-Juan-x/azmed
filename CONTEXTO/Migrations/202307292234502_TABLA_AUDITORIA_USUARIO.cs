namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TABLA_AUDITORIA_USUARIO : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AUDITORIAs", newName: "AUDITORIA_LOGIN_LOGOUT");
            CreateTable(
                "dbo.AUDITORIA_USUARIO",
                c => new
                    {
                        ID_AUDITORIA = c.Int(nullable: false, identity: true),
                        USUARIO = c.String(),
                        USUARIO_GESTIONADO = c.String(),
                        FECHA_HORA = c.DateTime(nullable: false),
                        ACCION = c.String(),
                        DATOS_REGISTRADOS = c.String(),
                    })
                .PrimaryKey(t => t.ID_AUDITORIA);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AUDITORIA_USUARIO");
            RenameTable(name: "dbo.AUDITORIA_LOGIN_LOGOUT", newName: "AUDITORIAs");
        }
    }
}
