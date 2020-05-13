namespace DimitarYanakev_S00189753.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Operating_System = c.String(),
                        OS_Image = c.String(),
                        Phone_Image = c.String(),
                        Phone_PhoneID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PhoneID)
                .ForeignKey("dbo.Phones", t => t.Phone_PhoneID)
                .Index(t => t.Phone_PhoneID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Phone_PhoneID", "dbo.Phones");
            DropIndex("dbo.Phones", new[] { "Phone_PhoneID" });
            DropTable("dbo.Phones");
        }
    }
}
