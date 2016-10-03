using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCartProject1.Models
{
    public class tblOrder
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string BillingAddr { get; set; }
        public string ShippingAddr { get; set; }
        public int Tax { get; set; }
        public int  Total { get; set; }
        public int SubTotal { get; set; }
        public int PromoCode { get; set; }
        public int CredCard { get; set; }
        public string CheckOutM { get; set; }


        public virtual ICollection<tblOrderItem> tblOrderItems { get; set; }
        
    }
}