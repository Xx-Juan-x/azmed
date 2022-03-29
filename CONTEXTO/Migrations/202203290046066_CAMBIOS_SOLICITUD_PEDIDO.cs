namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIOS_SOLICITUD_PEDIDO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SOLICITUD_PEDIDO", "DESCRIPCION", c => c.String());
            DropColumn("dbo.SOLICITUD_PEDIDO", "NOMBRE");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SOLICITUD_PEDIDO", "NOMBRE", c => c.String());
            DropColumn("dbo.SOLICITUD_PEDIDO", "DESCRIPCION");
        }
    }
}
