namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTokenRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tokens", "UserId");
            AddForeignKey("dbo.Tokens", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "UserId", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "UserId" });
            DropColumn("dbo.Tokens", "UserId");
        }
    }
}
