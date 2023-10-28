using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Domain.Models
{
    public class Discount : AuditableModel
    {
        public int DiscountId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; } // Valor do desconto (porcentagem ou valor fixo)
        public DateTime StartDate { get; set; } // Data de início do desconto
        public DateTime EndDate { get; set; } // Data de término do desconto
    }
}
