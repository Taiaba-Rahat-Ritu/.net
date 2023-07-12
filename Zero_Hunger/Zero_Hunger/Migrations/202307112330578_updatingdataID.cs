namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingdataID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Distributions");
            AlterColumn("dbo.Distributions", "id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Distributions", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Distributions");
            AlterColumn("dbo.Distributions", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Distributions", "Id");
        }
    }
}
