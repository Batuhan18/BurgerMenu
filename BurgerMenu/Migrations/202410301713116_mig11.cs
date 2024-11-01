namespace BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        CardId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CardNumber = c.String(),
                        Month = c.String(),
                        Year = c.String(),
                        Cvc = c.String(),
                    })
                .PrimaryKey(t => t.CardId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CreditCards");
        }
    }
}
