using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirstExercise
{
    public class VidzyContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>()
                .Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Video>()
                .HasRequired(v => v.Genres)
                .WithMany(g => g.Videos)
                .HasForeignKey(v => v.GenreId);

            modelBuilder.Entity<Genre>()
                .Property(g => g.name)
                .IsRequired()
                .HasMaxLength(255);

            base.OnModelCreating(modelBuilder); 
        }
    }
}
