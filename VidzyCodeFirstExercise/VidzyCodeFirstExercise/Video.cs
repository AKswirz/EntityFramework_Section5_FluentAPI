using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirstExercise
{
    public class Video
    {
        public Video()
        {
            Tags = new HashSet<Tag>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genres { get; set; }
        public byte GenreId { get; set; }
        public Classification Classifications { get; set; }
        //public Tag Tags { get; set; }

        public virtual ICollection<Tag> Tags { get; private set; }
    }
}
