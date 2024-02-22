
namespace ConsumeRestfulApi.Models
{
    internal class Book : ISupportsHypermedia
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required DateTime LaunchDate { get; set; }
        public required decimal Price { get; set; }
        public List<HyperMediaLink>? Links { get; set; }
    }
}
