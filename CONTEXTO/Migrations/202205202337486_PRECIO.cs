﻿namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PRECIO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TURNOes", "PRECIO", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TURNOes", "PRECIO");
        }
    }
}