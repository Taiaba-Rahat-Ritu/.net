namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingnewtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        CollectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collections", t => t.CollectionId, cascadeDelete: false)
                .Index(t => t.CollectionId);
            
            CreateTable(
                "dbo.Distributions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        CollectionId = c.Int(nullable: false),
                        Restaurant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collections", t => t.CollectionId, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id)
                .Index(t => t.EmployeeId)
                .Index(t => t.CollectionId)
                .Index(t => t.Restaurant_Id);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CollectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Collections", t => t.CollectionId, cascadeDelete: false)
                .Index(t => t.CollectionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Distributions", "Restaurant_Id", "dbo.Restaurants");
            DropForeignKey("dbo.Restaurants", "CollectionId", "dbo.Collections");
            DropForeignKey("dbo.Distributions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Distributions", "CollectionId", "dbo.Collections");
            DropForeignKey("dbo.Employees", "CollectionId", "dbo.Collections");
            DropIndex("dbo.Restaurants", new[] { "CollectionId" });
            DropIndex("dbo.Distributions", new[] { "Restaurant_Id" });
            DropIndex("dbo.Distributions", new[] { "CollectionId" });
            DropIndex("dbo.Distributions", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "CollectionId" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Distributions");
            DropTable("dbo.Employees");
            DropTable("dbo.Collections");
        }
    }
}
