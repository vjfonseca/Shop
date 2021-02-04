using System;

namespace Shop.App.DTO
{
    public class BookRead
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? PageCount { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Isbn{ get; set; }
    }
}