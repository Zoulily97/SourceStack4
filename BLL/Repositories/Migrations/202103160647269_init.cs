namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        IsMale = c.Boolean(nullable: false),
                        InvitedBy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.InvitedBy_Id)
                .Index(t => t.InvitedBy_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "InvitedBy_Id", "dbo.Users");
            DropIndex("dbo.Users", new[] { "InvitedBy_Id" });
            DropTable("dbo.Users");
        }
    }
}
