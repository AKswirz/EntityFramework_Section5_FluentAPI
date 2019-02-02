using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            /* Mosh's personal convention for organizing these specific configurations:
             * 1st: Table overrides at the beginning (e.g. change name of table - ToTable("tbl_Course");)
             * 2nd: Primary Keys (e.g. HasKey(c => c.Id);)
             * 3rd: Property configurations (sorted alphabetically)
             * 4th: Relationships (sorted alphabetically)
             */


            //3rd: Property configurations(sorted alphabetically)
            Property(c => c.Description)
            .IsRequired()
            .HasMaxLength(2000);

            Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(255);

            // 4th: Relationships (sorted alphabetically)
            HasRequired(c => c.Author)
            .WithMany(a => a.Courses)
            .HasForeignKey(c => c.AuthorId)
            .WillCascadeOnDelete(false);

            HasRequired(c => c.Cover)
            .WithRequiredPrincipal(c => c.Course);

            HasMany(c => c.Tags)
            .WithMany(t => t.Courses)
            .Map(m =>
            {
                m.ToTable("CourseTags");
                m.MapLeftKey("CourseId");
                m.MapRightKey("TagId");
            });  
        }
    }
}
