using System.Reflection.Metadata.Ecma335;

namespace Mentor_App.Models
{
    public class Slider
    {
        public int id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string Desc { get; set; } = null!;
        public string Title { get; set; } = null!;  
        public string ButtonLink { get; set; } = null!;

    }
}
