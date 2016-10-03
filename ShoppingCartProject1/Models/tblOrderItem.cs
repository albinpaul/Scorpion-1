using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCartProject1.Models
{
    public class tblOrderItem
    {
        [Key]
        public int ItemId { get; set; }
        public int Size { get; set; }
        public int Color { get; set; }
        public int Quantity { get; set; }
        public int IPrice { get; set; }
        public int TPrice { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
       
        public virtual tblProduct tblProduct { get; set; }
        public virtual tblOrder tblOrder { get; set; }


    }
}