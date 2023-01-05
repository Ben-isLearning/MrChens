namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBlogsToFinance : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "BlogId" });
            CreateTable(
                "dbo.Finances",
                c => new
                    {
                        FinanceId = c.Int(nullable: false, identity: true),
                        TransactionType = c.String(),
                        Amount = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.FinanceId);
            
            DropTable("dbo.Blogs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
            DropTable("dbo.Finances");
            CreateIndex("dbo.Posts", "BlogId");
            AddForeignKey("dbo.Posts", "BlogId", "dbo.Blogs", "BlogId", cascadeDelete: true);
        }
    }
}
