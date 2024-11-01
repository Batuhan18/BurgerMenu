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


        }

        public override void Down()
        {


            DropTable("dbo.Communucations");
        }
    }
}
