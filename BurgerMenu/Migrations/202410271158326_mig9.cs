namespace BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Communucations",
                c => new
                    {
                        CommunucationId = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CommunucationId);
            
            DropTable("dbo.Contacts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        OurEmail = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        Map = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
            DropTable("dbo.Communucations");
        }
    }
}
