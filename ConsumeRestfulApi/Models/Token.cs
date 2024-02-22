namespace ConsumeRestfulApi.Models
{
    internal class Token
    {
        public required bool Authenticated { get; set; }
        public required string Created {  get; set; }
        public required string Expiration { get; set; }
        public required string AcessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}
