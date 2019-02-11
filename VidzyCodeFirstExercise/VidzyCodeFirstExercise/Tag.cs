using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirstExercise
{
    public class Tag
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public Video Videos { get; set; }
    }
}
