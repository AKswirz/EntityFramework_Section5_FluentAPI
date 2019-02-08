namespace VidzyCodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassificationTypeChangeToByte : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Videos DROP CONSTRAINT[DF__Videos__Classifi__52593CB8]");
            AlterColumn("dbo.Videos", "Classifications", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "Classifications", c => c.Int(nullable: false));
        }
    }
}
