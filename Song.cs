

namespace ConsoleApp2
{
    public class Song
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
