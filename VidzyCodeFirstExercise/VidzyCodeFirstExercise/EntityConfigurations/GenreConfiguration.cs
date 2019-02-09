using System.Data.Entity.ModelConfiguration;

namespace VidzyCodeFirstExercise.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(g => g.name)
                .IsRequired()
                .HasMaxLength(255);                
        }
        
    }
}
