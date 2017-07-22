using System;

namespace NetCrud.Models
{
    public class Snippet
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Snippet { get; set; }
    }
}