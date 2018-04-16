namespace IntroToEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDesignerAndHightlerToHairStyles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HairStyles", "Designer", c => c.String());
            AddColumn("dbo.HairStyles", "Highlights", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HairStyles", "Highlights");
            DropColumn("dbo.HairStyles", "Designer");
        }
    }
}
