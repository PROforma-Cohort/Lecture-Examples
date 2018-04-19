namespace ShoeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedShoppingCart1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ShoeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shoes", t => t.ShoeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ShoeId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCarts", "UserId", "dbo.Users");
            DropForeignKey("dbo.ShoppingCarts", "ShoeId", "dbo.Shoes");
            DropIndex("dbo.ShoppingCarts", new[] { "ShoeId" });
            DropIndex("dbo.ShoppingCarts", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.ShoppingCarts");
        }
    }
}
