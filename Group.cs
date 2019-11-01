
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Group
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
