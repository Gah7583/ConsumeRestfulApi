namespace ConsumeRestfulApi.Models
{
    interface ISupportsHypermedia
    {
        List<HyperMediaLink>? Links { get; set; }
    }
}
