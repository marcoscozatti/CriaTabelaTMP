namespace CriaTabelaTMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CadAmigo",
                c => new
                    {
                        ID_CADAMIGO = c.Int(nullable: false, identity: true),
                        NOME_CADAMIGO = c.String(nullable: false),
                        CEL_CADAMIGO = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CADAMIGO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CadAmigo");
        }
    }
}
