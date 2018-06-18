namespace Stocks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTransaction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsBuy = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        ShareAmount = c.Int(nullable: false),
                        SharePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Companies", t => t.CompanyID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "UserID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Transactions", new[] { "CompanyID" });
            DropIndex("dbo.Transactions", new[] { "UserID" });
            DropTable("dbo.Transactions");
        }
    }
}
