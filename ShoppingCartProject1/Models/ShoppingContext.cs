
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingCartProject1.Models
{
   
        public class ShoppingContext : DbContext
        {
            public DbSet<tblProduct> tblProducts { get; set; }
            public DbSet<tblOrder> tblOrders { get; set; }
            public DbSet<tblOrderItem> tblOrderItems { get; set; }

        }
    
}