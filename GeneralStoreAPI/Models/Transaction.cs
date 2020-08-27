using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Customer")] // [ForeignKey(nameof(Product))] does the same thing if not better..."Customer" is tied to property name below 
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; } // where foreign key is going so we went ahead and did the virutal etc

        [Required]
        [ForeignKey("Product")]
        public string ProductSKU { get; set; }

        public virtual Product Product { get; set; } // wehre foreign key is so went ahead and built out

        [Required]
        public int ItemCount { get; set; }

        [Required]
        public DateTime DateOfTransaction { get; set; }


    }
}