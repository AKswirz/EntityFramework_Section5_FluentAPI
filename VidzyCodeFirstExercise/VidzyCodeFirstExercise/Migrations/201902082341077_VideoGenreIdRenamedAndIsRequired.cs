namespace VidzyCodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VideoGenreIdRenamedAndIsRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genres_Id" });
            RenameColumn(table: "dbo.Videos", name: "Genres_Id", newName: "GenreId");
            AlterColumn("dbo.Videos", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Videos", "GenreId");
            AddForeignKey("dbo.Videos", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "GenreId", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "GenreId" });
            AlterColumn("dbo.Videos", "GenreId", c => c.Byte());
            RenameColumn(table: "dbo.Videos", name: "GenreId", newName: "Genres_Id");
            CreateIndex("dbo.Videos", "Genres_Id");
            AddForeignKey("dbo.Videos", "Genres_Id", "dbo.Genres", "Id");
        }
    }
}
