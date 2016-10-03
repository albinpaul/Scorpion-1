using ShoppingCartProject1.DAL;
using ShoppingCartProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartProject1.Controllers
{
    public class InputmethodController : Controller
    {
        private ShoppingContext db = new ShoppingContext();
        // GET: Inputmethod
            public ActionResult InputHere()
        {
            return View();
        }

        // POST: Inputmethod/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InputHere([Bind(Include = "PId , Pname , Price , Rating , Meta , Discount , About ,Onstock , Quality ,Comfort ,Review,Quantity,Spec1,Spec2,Spec3,Image1,Image2,Image3,Image4,Image5")] tblProduct tblProduct)
        {
            if (ModelState.IsValid)
            {
                tblProduct.PId = 1;
                db.tblProducts.Add(tblProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblProduct);
        }

     
      
    }
}
