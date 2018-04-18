namespace IntroToAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMonsterTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Monsters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Horns = c.Boolean(nullable: false),
                        NumberOfEyes = c.Int(nullable: false),
                        SkinType = c.String(),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Monsters");
        }
    }
}
