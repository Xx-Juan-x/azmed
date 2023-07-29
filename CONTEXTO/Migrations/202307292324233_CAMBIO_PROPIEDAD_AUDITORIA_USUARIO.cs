namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIO_PROPIEDAD_AUDITORIA_USUARIO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AUDITORIA_USUARIO", "NOMBRE", c => c.String());
            DropColumn("dbo.AUDITORIA_USUARIO", "USUARIO_GESTIONADO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AUDITORIA_USUARIO", "USUARIO_GESTIONADO", c => c.String());
            DropColumn("dbo.AUDITORIA_USUARIO", "NOMBRE");
        }
    }
}
