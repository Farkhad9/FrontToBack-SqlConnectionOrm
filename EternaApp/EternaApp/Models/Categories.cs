using System.Reflection.Metadata.Ecma335;

namespace EternaApp.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
