﻿namespace ConsumeRestfulApi.Models
{
    internal class Token
    {
        public bool Authenticated { get; set; }
        public string Created {  get; set; }
        public string Expiration { get; set; }
        public string AcessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
