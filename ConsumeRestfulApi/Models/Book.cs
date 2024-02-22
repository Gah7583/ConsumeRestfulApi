
namespace ConsumeRestfulApi.Models
{
    internal class Book : ISupportsHypermedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LaunchDate { get; set; }
        public decimal Price { get; set; }
        public List<HyperMediaLink> Links { get; set; }
    }
}
