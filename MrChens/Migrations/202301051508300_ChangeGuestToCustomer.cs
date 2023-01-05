namespace MrChens.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGuestToCustomer : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Guests", newName: "Customers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Customers", newName: "Guests");
        }
    }
}
