namespace CriaTabelaTMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Telefone",
                c => new
                    {
                        ID_TELEFONE = c.Int(nullable: false, identity: true),
                        NOME_TELEFONE = c.String(nullable: false),
                        TEL_TELEFONE = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID_TELEFONE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Telefone");
        }
    }
}
