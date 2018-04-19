namespace ShoeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedShoeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Style = c.String(),
                        Color = c.String(),
                        SizeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sizes", t => t.SizeId, cascadeDelete: true)
                .Index(t => t.SizeId);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsSize = c.Int(nullable: false),
                        EuropeanSize = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shoes", "SizeId", "dbo.Sizes");
            DropIndex("dbo.Shoes", new[] { "SizeId" });
            DropTable("dbo.Sizes");
            DropTable("dbo.Shoes");
        }
    }
}
