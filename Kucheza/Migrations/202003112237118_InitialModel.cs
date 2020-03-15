namespace Kucheza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Miasto", c => c.String());
            AddColumn("dbo.AspNetUsers", "Opis", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Opis");
            DropColumn("dbo.AspNetUsers", "Miasto");
        }
    }
}
