using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Domain.Models
{
    public class Category : AuditableModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Subcategory> Subcategories { get; set; }
        public List<Product> Products { get; set; }
    }
}
