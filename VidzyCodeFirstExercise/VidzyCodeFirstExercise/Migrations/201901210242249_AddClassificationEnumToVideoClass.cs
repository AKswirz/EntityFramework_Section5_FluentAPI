namespace VidzyCodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassificationEnumToVideoClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classifications", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Classifications");
        }
    }
}
