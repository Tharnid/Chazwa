namespace MasterDetail.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Identity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(maxLength: 15));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(maxLength: 15));
            AddColumn("dbo.AspNetUsers", "Address", c => c.String(maxLength: 30));
            AddColumn("dbo.AspNetUsers", "City", c => c.String(maxLength: 20));
            AddColumn("dbo.AspNetUsers", "State", c => c.String(maxLength: 2));
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.String(maxLength: 10));
            CreateIndex("dbo.Customers", "CompanyName", unique: true, name: "AK_Customer_CompanyName");
            CreateIndex("dbo.WorkOrders", "ApplicationUser_Id");
            AddForeignKey("dbo.WorkOrders", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkOrders", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.WorkOrders", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Customers", "AK_Customer_CompanyName");
            DropColumn("dbo.AspNetUsers", "ZipCode");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetRoles", "Discriminator");
            DropColumn("dbo.WorkOrders", "ApplicationUser_Id");
        }
    }
}
