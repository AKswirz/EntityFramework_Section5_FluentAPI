namespace VidzyCodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreNameIsRequiredAndHasSpecifiedLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "name", c => c.String());
        }
    }
}
