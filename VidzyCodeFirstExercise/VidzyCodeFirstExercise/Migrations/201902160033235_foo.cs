namespace VidzyCodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VideoTags",
                c => new
                    {
                        Video_Id = c.Int(nullable: false),
                        Tag_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_Id, t.Tag_Id })
                .ForeignKey("dbo.Videos", t => t.Video_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .Index(t => t.Video_Id)
                .Index(t => t.Tag_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoTags", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.VideoTags", "Video_Id", "dbo.Videos");
            DropIndex("dbo.VideoTags", new[] { "Tag_Id" });
            DropIndex("dbo.VideoTags", new[] { "Video_Id" });
            DropTable("dbo.VideoTags");
            DropTable("dbo.Tags");
        }
    }
}
