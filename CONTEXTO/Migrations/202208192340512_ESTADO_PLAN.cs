﻿namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ESTADO_PLAN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PLANs", "ESTADO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PLANs", "ESTADO");
        }
    }
}