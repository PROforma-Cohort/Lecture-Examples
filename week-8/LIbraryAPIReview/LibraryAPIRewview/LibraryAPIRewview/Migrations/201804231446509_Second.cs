namespace LibraryAPIRewview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "IsCheckedOut", c => c.Boolean(nullable: false));
            AddColumn("dbo.Books", "DueBackDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "DueBackDate");
            DropColumn("dbo.Books", "IsCheckedOut");
        }
    }
}
