namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PRECIO_COMPRA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LISTA_COMPRA", "PRECIO", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LISTA_COMPRA", "PRECIO");
        }
    }
}
