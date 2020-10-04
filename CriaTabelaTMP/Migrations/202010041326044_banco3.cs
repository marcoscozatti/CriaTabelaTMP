namespace CriaTabelaTMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CadAmigo", "TEL_CADAMIGO", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CadAmigo", "TEL_CADAMIGO");
        }
    }
}
