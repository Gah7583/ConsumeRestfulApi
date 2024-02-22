namespace ConsumeRestfulApi.Models
{
    internal class Person : ISupportsHypermedia
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Address { get; set; }
        public required string Gender { get; set; }
        public required bool Enabled { get; set; }
        public List<HyperMediaLink>? Links { get; set; }
    }
}
