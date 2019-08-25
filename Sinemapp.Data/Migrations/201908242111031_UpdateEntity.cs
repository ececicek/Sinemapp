namespace Sinemapp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEntity : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Casts", name: "CinemaId", newName: "FilmId");
            RenameIndex(table: "dbo.Casts", name: "IX_CinemaId", newName: "IX_FilmId");
            AddColumn("dbo.Genres", "Name", c => c.String());
            DropColumn("dbo.Genres", "GenreName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "GenreName", c => c.String());
            DropColumn("dbo.Genres", "Name");
            RenameIndex(table: "dbo.Casts", name: "IX_FilmId", newName: "IX_CinemaId");
            RenameColumn(table: "dbo.Casts", name: "FilmId", newName: "CinemaId");
        }
    }
}
