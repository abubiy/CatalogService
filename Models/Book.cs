using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogService.Models
{
    [Table("Books")]
    public partial class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public DateTime CopyrightDate { get; set; }
        [Key]
        public int Isbn { get; set; }
    }
}
