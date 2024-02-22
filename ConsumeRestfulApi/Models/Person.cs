﻿namespace ConsumeRestfulApi.Models
{
    internal class Person : ISupportsHypermedia
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public bool Enabled { get; set; }
        public List<HyperMediaLink>? Links { get; set; }
    }
}