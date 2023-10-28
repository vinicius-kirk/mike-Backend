using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Domain.Models
{
    public class Product : AuditableModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int StockQuantity { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime LastRestockDate { get; set; }
        public string Material { get; set; }
        public string Style { get; set; }
        public string Gender { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsOnSale { get; set; }
        public double AverageRating { get; set; }
        public int CategoryId { get; set; }
        public int? SubcategoryId { get; set; }
        public int? DiscountId { get; set; }
        public Category Category { get; set; }
        public Subcategory Subcategory { get; set; }
        public Discount Discount { get; set; }
        public List<Review> Reviews { get; set; }

    }
}
