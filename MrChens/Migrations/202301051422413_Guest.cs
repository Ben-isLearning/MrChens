namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Guest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Likes = c.String(),
                        Dislikes = c.String(),
                    })
                .PrimaryKey(t => t.GuestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Guests");
        }
    }
}
