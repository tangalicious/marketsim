namespace Stocks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StockPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ThreeLetterAcronym = c.String(),
                        Volatility = c.Int(nullable: false),
                        UpdateSpeed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Companies");
        }
    }
}
