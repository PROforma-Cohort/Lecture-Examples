namespace IntroToEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHairStyles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HairStyles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HairLength = c.String(),
                        Color = c.String(),
                        Bangs = c.Boolean(nullable: false),
                        TiedUp = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Texture = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HairStyles");
        }
    }
}
