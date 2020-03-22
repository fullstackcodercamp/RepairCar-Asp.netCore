using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRepairShop.Models
{
    public class CustomerService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerServiceId { get; set; }

        public double TotalCost { get; set; }
        public double TotalPaid { get; set; }
        public double Discount { get; set; }
        public string Status { get; set; } = "InProgress";
        public bool IsPaid { get; set; } = false;

        public Guid? ServiceId { get; set; }
        public Service Service { get; set; }

        public Guid? CustomerId { get; set; }
        public Customer  Customer { get; set; }



    }
}
