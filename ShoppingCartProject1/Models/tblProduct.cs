using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCartProject1.Models
{
    public class tblProduct:IEnumerable<tblProduct>
    {
        [Key]
        public int PId { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public string Meta { get; set; }
        public int Discount { get; set; }
        public string About { get; set; }
        public int Onstock { get; set; }
        public int Quality { get; set; }
        public int Comfort { get; set; }
        public string Review { get; set; }
        public int Quantity { get; set; }

        public string Spec1 { get; set; }
        public string Spec2 { get; set; }
        public string Spec3 { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }

        List<tblProduct> mylist = new List<tblProduct>();
        public IEnumerator<tblProduct> GetEnumerator()
        {
            return mylist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public tblProduct this[int index]
        {
            get { return mylist[index]; }
            set { mylist.Insert(index, value); }
        }


    }
}