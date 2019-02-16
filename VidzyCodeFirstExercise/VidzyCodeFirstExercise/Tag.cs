using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirstExercise
{
    public class Tag
    {
        public Tag()
        {
            Videos = new HashSet<Video>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        // public Video Videos { get; set; }

        public virtual ICollection<Video> Videos { get; private set; }
    }

}
