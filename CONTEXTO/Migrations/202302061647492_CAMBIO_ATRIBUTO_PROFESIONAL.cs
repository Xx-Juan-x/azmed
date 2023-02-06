namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CAMBIO_ATRIBUTO_PROFESIONAL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PROFESIONALs", "CONTACTO", c => c.Long(nullable: false));
            DropColumn("dbo.PROFESIONALs", "TELEFONO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PROFESIONALs", "TELEFONO", c => c.String());
            DropColumn("dbo.PROFESIONALs", "CONTACTO");
        }
    }
}
