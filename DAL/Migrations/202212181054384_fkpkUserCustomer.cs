namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkpkUserCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "UserId", "dbo.Users");
            DropPrimaryKey("dbo.Customers");
            AddPrimaryKey("dbo.Customers", "UserId");
            AddForeignKey("dbo.Customers", "UserId", "dbo.Users", "Id");
            DropColumn("dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Customers", "UserId", "dbo.Users");
            DropPrimaryKey("dbo.Customers");
            AddPrimaryKey("dbo.Customers", "Id");
            AddForeignKey("dbo.Customers", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
