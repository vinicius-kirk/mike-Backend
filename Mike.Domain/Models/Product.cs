using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Domain.Models
{
    public class Product : AuditableModel
    {
        public string Name { get; set; }
 
    }
}
