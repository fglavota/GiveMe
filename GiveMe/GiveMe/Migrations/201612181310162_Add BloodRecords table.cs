namespace GiveMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBloodRecordstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTimeOffset(nullable: false, precision: 7),
                        Unusable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TotalDosages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BloodGroup = c.Int(nullable: false),
                        BloodType = c.Int(nullable: false),
                        ProductType = c.Int(nullable: false),
                        TakenCount = c.Int(nullable: false),
                        ProducedCount = c.Int(nullable: false),
                        BloodRecord_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BloodRecords", t => t.BloodRecord_Id)
                .Index(t => t.BloodRecord_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TotalDosages", "BloodRecord_Id", "dbo.BloodRecords");
            DropIndex("dbo.TotalDosages", new[] { "BloodRecord_Id" });
            DropTable("dbo.TotalDosages");
            DropTable("dbo.BloodRecords");
        }
    }
}
