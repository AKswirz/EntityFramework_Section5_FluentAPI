namespace VidzyCodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenresToGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES ('Fantasy')");
            Sql("INSERT INTO Genres VALUES ('Sci-Fi')");
            Sql("INSERT INTO Genres VALUES ('Drama')");
            Sql("INSERT INTO Genres VALUES ('Comedy')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id >= 1");
        }
    }
}
