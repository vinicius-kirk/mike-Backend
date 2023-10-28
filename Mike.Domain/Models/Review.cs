using System;

namespace Mike.Domain.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string UserName { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DatePosted { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } 
    }
}
