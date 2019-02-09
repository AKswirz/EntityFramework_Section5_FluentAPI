using System.Data.Entity.ModelConfiguration;

namespace VidzyCodeFirstExercise.EntityConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(v => v.Genres)
                .WithMany(g => g.Videos)
                .HasForeignKey(v => v.GenreId);
        }
        
    }
}
