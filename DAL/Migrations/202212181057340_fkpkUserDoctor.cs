namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkpkUserDoctor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "UserId", "dbo.Users");
            DropPrimaryKey("dbo.Doctors");
            AddPrimaryKey("dbo.Doctors", "UserId");
            AddForeignKey("dbo.Doctors", "UserId", "dbo.Users", "Id");
            DropColumn("dbo.Doctors", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Doctors", "UserId", "dbo.Users");
            DropPrimaryKey("dbo.Doctors");
            AddPrimaryKey("dbo.Doctors", "Id");
            AddForeignKey("dbo.Doctors", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
