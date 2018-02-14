namespace AusmarP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maintenances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueCode = c.Int(nullable: false),
                        DateRaised = c.DateTime(nullable: false),
                        Category = c.String(),
                        Item = c.String(),
                        Priority = c.String(),
                        OpenStatus = c.Boolean(nullable: false),
                        Note = c.String(),
                        SiteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sites", t => t.SiteId, cascadeDelete: true)
                .Index(t => t.SiteId);
            
            CreateTable(
                "dbo.ProgressStages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stage = c.String(),
                        Value = c.Int(nullable: false),
                        DateCompleted = c.DateTime(nullable: false),
                        CompletedBy = c.String(),
                        DateApproved = c.DateTime(nullable: false),
                        ApprovedBy = c.String(),
                        PaymentStatus = c.String(),
                        DatePaid = c.DateTime(nullable: false),
                        SiteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sites", t => t.SiteId, cascadeDelete: true)
                .Index(t => t.SiteId);
            
            CreateTable(
                "dbo.Variations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        VariationCode = c.Int(nullable: false),
                        DateReleased = c.DateTime(nullable: false),
                        PostContract = c.Boolean(nullable: false),
                        Location = c.String(),
                        Description = c.String(),
                        Comment = c.String(),
                        Price = c.Int(nullable: false),
                        EOT = c.Int(nullable: false),
                        ApprovedStatus = c.Boolean(nullable: false),
                        Claimed = c.Boolean(nullable: false),
                        Paid = c.Boolean(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        SiteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sites", t => t.SiteId, cascadeDelete: true)
                .Index(t => t.SiteId);
            
            AddColumn("dbo.Issues", "Code", c => c.Int(nullable: false));
            AddColumn("dbo.Issues", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Issues", "Category", c => c.String());
            AddColumn("dbo.Issues", "Item", c => c.String());
            AddColumn("dbo.Issues", "Priority", c => c.String());
            AddColumn("dbo.Issues", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Issues", "Note", c => c.String());
            AddColumn("dbo.Sites", "HomeOwner", c => c.String());
            AddColumn("dbo.Sites", "ContactNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Sites", "ContactEmail", c => c.String());
            AddColumn("dbo.Sites", "HouseType", c => c.String());
            AddColumn("dbo.Sites", "ContractValueExGST", c => c.Int(nullable: false));
            AddColumn("dbo.Sites", "ContractValueIncGST", c => c.Int(nullable: false));
            AddColumn("dbo.Sites", "ContractDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sites", "PreContactEOT", c => c.Int(nullable: false));
            AddColumn("dbo.Sites", "DOPCDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sites", "TwelveMonthMaintenance", c => c.Int(nullable: false));
            AddColumn("dbo.Sites", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Variations", "SiteId", "dbo.Sites");
            DropForeignKey("dbo.ProgressStages", "SiteId", "dbo.Sites");
            DropForeignKey("dbo.Maintenances", "SiteId", "dbo.Sites");
            DropIndex("dbo.Variations", new[] { "SiteId" });
            DropIndex("dbo.ProgressStages", new[] { "SiteId" });
            DropIndex("dbo.Maintenances", new[] { "SiteId" });
            DropColumn("dbo.Sites", "Note");
            DropColumn("dbo.Sites", "TwelveMonthMaintenance");
            DropColumn("dbo.Sites", "DOPCDate");
            DropColumn("dbo.Sites", "PreContactEOT");
            DropColumn("dbo.Sites", "ContractDate");
            DropColumn("dbo.Sites", "ContractValueIncGST");
            DropColumn("dbo.Sites", "ContractValueExGST");
            DropColumn("dbo.Sites", "HouseType");
            DropColumn("dbo.Sites", "ContactEmail");
            DropColumn("dbo.Sites", "ContactNumber");
            DropColumn("dbo.Sites", "HomeOwner");
            DropColumn("dbo.Issues", "Note");
            DropColumn("dbo.Issues", "Status");
            DropColumn("dbo.Issues", "Priority");
            DropColumn("dbo.Issues", "Item");
            DropColumn("dbo.Issues", "Category");
            DropColumn("dbo.Issues", "Date");
            DropColumn("dbo.Issues", "Code");
            DropTable("dbo.Variations");
            DropTable("dbo.ProgressStages");
            DropTable("dbo.Maintenances");
        }
    }
}
