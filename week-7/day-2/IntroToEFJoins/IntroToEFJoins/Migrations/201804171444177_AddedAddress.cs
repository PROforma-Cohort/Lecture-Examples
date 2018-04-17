namespace IntroToEFJoins.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullAddress = c.String(),
                        Zip = c.String(),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "AddressId", c => c.Int());
            CreateIndex("dbo.People", "AddressId");
            AddForeignKey("dbo.People", "AddressId", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "AddressId", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "AddressId" });
            DropColumn("dbo.People", "AddressId");
            DropTable("dbo.Addresses");
        }
    }
}
