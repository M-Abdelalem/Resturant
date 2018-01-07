namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ladkwqpojrioqw : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category_name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contact_Us_Information",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        telephone = c.Int(nullable: false),
                        facebook = c.String(),
                        twitter = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        item_name = c.String(nullable: false),
                        price = c.Int(nullable: false),
                        Fk_sub_category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sub_Category", t => t.Fk_sub_category, cascadeDelete: true)
                .Index(t => t.Fk_sub_category);
            
            CreateTable(
                "dbo.Sub_Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        sub_category_name = c.String(nullable: false),
                        Fk_category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Fk_category, cascadeDelete: true)
                .Index(t => t.Fk_category);
            
            CreateTable(
                "dbo.Order_Components",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fk_item = c.Int(nullable: false),
                        Fk_order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Fk_item, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Fk_order, cascadeDelete: true)
                .Index(t => t.Fk_item)
                .Index(t => t.Fk_order);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        situation = c.Boolean(nullable: false),
                        coste = c.Int(nullable: false),
                        time = c.DateTime(nullable: false),
                        Fk_users = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Fk_users, cascadeDelete: true)
                .Index(t => t.Fk_users);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        password = c.String(),
                        address = c.String(),
                        telephone = c.Int(nullable: false),
                        FK_Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.FK_Role, cascadeDelete: true)
                .Index(t => t.FK_Role);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role_Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        time = c.DateTime(nullable: false),
                        table_number = c.Int(nullable: false),
                        Fk_user = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Fk_user, cascadeDelete: true)
                .Index(t => t.Fk_user);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Fk_user", "dbo.Users");
            DropForeignKey("dbo.Order_Components", "Fk_order", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Fk_users", "dbo.Users");
            DropForeignKey("dbo.Users", "FK_Role", "dbo.Roles");
            DropForeignKey("dbo.Order_Components", "Fk_item", "dbo.Items");
            DropForeignKey("dbo.Items", "Fk_sub_category", "dbo.Sub_Category");
            DropForeignKey("dbo.Sub_Category", "Fk_category", "dbo.Categories");
            DropIndex("dbo.Reservations", new[] { "Fk_user" });
            DropIndex("dbo.Users", new[] { "FK_Role" });
            DropIndex("dbo.Orders", new[] { "Fk_users" });
            DropIndex("dbo.Order_Components", new[] { "Fk_order" });
            DropIndex("dbo.Order_Components", new[] { "Fk_item" });
            DropIndex("dbo.Sub_Category", new[] { "Fk_category" });
            DropIndex("dbo.Items", new[] { "Fk_sub_category" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Order_Components");
            DropTable("dbo.Sub_Category");
            DropTable("dbo.Items");
            DropTable("dbo.Contact_Us_Information");
            DropTable("dbo.Categories");
        }
    }
}
