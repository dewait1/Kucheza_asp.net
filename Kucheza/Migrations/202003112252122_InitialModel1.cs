namespace Kucheza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "wiek", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "dzienUrodzin", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "miesiacUrodzin", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "rokUrodzin", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "aktualnaPraca", c => c.String());
            AddColumn("dbo.AspNetUsers", "plec", c => c.String());
            AddColumn("dbo.AspNetUsers", "religia", c => c.String());
            AddColumn("dbo.AspNetUsers", "opcjaPolityczna", c => c.String());
            AddColumn("dbo.AspNetUsers", "ulubionyCytat", c => c.String());
            AddColumn("dbo.AspNetUsers", "wyksztalcenie", c => c.String());
            AddColumn("dbo.AspNetUsers", "zdjecieProfilowe", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "zdjecieProfilowe");
            DropColumn("dbo.AspNetUsers", "wyksztalcenie");
            DropColumn("dbo.AspNetUsers", "ulubionyCytat");
            DropColumn("dbo.AspNetUsers", "opcjaPolityczna");
            DropColumn("dbo.AspNetUsers", "religia");
            DropColumn("dbo.AspNetUsers", "plec");
            DropColumn("dbo.AspNetUsers", "aktualnaPraca");
            DropColumn("dbo.AspNetUsers", "rokUrodzin");
            DropColumn("dbo.AspNetUsers", "miesiacUrodzin");
            DropColumn("dbo.AspNetUsers", "dzienUrodzin");
            DropColumn("dbo.AspNetUsers", "wiek");
        }
    }
}
