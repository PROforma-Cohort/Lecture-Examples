namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLedger : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookLedgers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookLedgers", "BookId", "dbo.Books");
            DropIndex("dbo.BookLedgers", new[] { "BookId" });
            DropTable("dbo.BookLedgers");
        }
    }
}
