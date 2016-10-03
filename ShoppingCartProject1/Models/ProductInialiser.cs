using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartProject1.DAL
{
    public class Product: System.Data.Entity.DropCreateDatabaseIfModelChanges<ShoppingContext>
    {
        protected override void Seed(ShoppingContext context)
        {
            var Product = new List<tblProduct>
            {
                new tblProduct{ Pname="Black safety shoes", Price=590, Rating=5, Meta="woodland,branded, men's footwear ,sports shoes new arrival ", Discount=10, About="blahblahblah", Onstock=33 , Quality=4, Comfort=6, Review="a good one" },
                new tblProduct{ Pname="stylish Chiku slippers", Price=250, Rating=1, Meta="stylish , women's,slippers,comfort", Discount=11, About="fill inthese spaces", Onstock=2 , Quality=8, Comfort=5, Review="i dont know" },
                new tblProduct{ Pname="walk and style flat", Price=300, Rating=6, Meta="flat,black,women's,stylish,new arrival", Discount=12, About="and these spaces", Onstock=80 , Quality=2, Comfort=3, Review="not my type" },
                new tblProduct{ Pname="adidas q 1787 daily", Price=406, Rating=4, Meta="adidas,branded,daily,comfort,easy,black, offers", Discount=20, About="and them", Onstock=40 , Quality=9, Comfort=8, Review="thats super comfort" },
                new tblProduct{ Pname="casual shoes", Price=670, Rating=7, Meta="Kid's,comfort,casual", Discount=10, About="why did ya leave this?", Onstock=12 , Quality=5, Comfort=5, Review="good!!" },
            };
            Product.ForEach(s => context.tblProducts.Add(s));
            context.SaveChanges();

        }
    }
}