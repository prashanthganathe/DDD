namespace CZ.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        DOB = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250, unicode: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Dispose = c.Boolean(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        SiteTypeId = c.Int(nullable: false),
                        RoleHierarchy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SiteType", t => t.SiteTypeId)
                .Index(t => t.SiteTypeId);
            
            CreateTable(
                "dbo.SiteType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 100, unicode: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        UserName = c.String(maxLength: 100, unicode: false),
                        Password = c.String(maxLength: 100, unicode: false),
                        PasswordHash = c.String(maxLength: 100, unicode: false),
                        Passcode = c.String(maxLength: 100, unicode: false),
                        SecurityStamp = c.String(maxLength: 100, unicode: false),
                        FirstName = c.String(maxLength: 100, unicode: false),
                        MiddleName = c.String(maxLength: 100, unicode: false),
                        LastName = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        EmailConfirmed = c.Boolean(),
                        PhoneNumber = c.String(maxLength: 100, unicode: false),
                        PhoneNumberConfirmed = c.Boolean(),
                        TwoFactorEnabled = c.Boolean(),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(),
                        AccessFailedCount = c.Int(),
                        UnlockAt = c.DateTime(),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 100, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        LastLoginOn = c.DateTime(),
                        LastLogoutOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Role", "SiteTypeId", "dbo.SiteType");
            DropForeignKey("dbo.Product", "ClientId", "dbo.Client");
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.Role", new[] { "SiteTypeId" });
            DropIndex("dbo.Product", new[] { "ClientId" });
            DropTable("dbo.User");
            DropTable("dbo.UserRole");
            DropTable("dbo.SiteType");
            DropTable("dbo.Role");
            DropTable("dbo.Product");
            DropTable("dbo.Client");
        }
    }
}
