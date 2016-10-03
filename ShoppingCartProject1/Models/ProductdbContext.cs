using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingCartProject1.Models
{
    public class ProductdbContext:DbContext
    {
        public DbSet<tblProduct> tblProducts { get; set; }
        public DbSet<tblOrder> tblOrders { get; set; }
        public DbSet<tblOrderItem> tblOrderItems { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Shortspec> Shortspecs { get; set; }

    }
}