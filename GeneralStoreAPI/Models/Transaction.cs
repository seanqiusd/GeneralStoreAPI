using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Transaction
    {

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } // where foreign key is going so we went ahead and did the virutal etc
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } // wehre foreign key is so went ahead and built out
        public int ItemCount { get; set; }
        public DateTime DateOfTransaction { get; set; }


    }
}