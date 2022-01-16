using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Book
    {   
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public List<Genre> Genres { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public int PublishDate { get; set; }

    }
}
