using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.App.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Range(1, int.MaxValue)]
        public int? PageCount { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Isbn { get; set; }
    }
}