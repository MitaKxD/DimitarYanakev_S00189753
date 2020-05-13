namespace DimitarYanakev_S00189753.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Phones", "Phone_PhoneID", "dbo.Phones");
            DropIndex("dbo.Phones", new[] { "Phone_PhoneID" });
            DropColumn("dbo.Phones", "Phone_PhoneID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "Phone_PhoneID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Phones", "Phone_PhoneID");
            AddForeignKey("dbo.Phones", "Phone_PhoneID", "dbo.Phones", "PhoneID");
        }
    }
}
