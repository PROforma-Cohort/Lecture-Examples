namespace IntroToEFJoins.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        VIN = c.String(),
                        Model = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarPersons",
                c => new
                    {
                        Car_Id = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Car_Id, t.Person_Id })
                .ForeignKey("dbo.Cars", t => t.Car_Id, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .Index(t => t.Car_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarPersons", "Person_Id", "dbo.People");
            DropForeignKey("dbo.CarPersons", "Car_Id", "dbo.Cars");
            DropIndex("dbo.CarPersons", new[] { "Person_Id" });
            DropIndex("dbo.CarPersons", new[] { "Car_Id" });
            DropTable("dbo.CarPersons");
            DropTable("dbo.Cars");
        }
    }
}
