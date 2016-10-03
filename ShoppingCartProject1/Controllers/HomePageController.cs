using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartProject1.Models;
using System.Net;
using System.Threading.Tasks;

namespace ShoppingCartProject1.Controllers
{
    public class HomePageController : Controller
    {
        private ShoppingContext db = new ShoppingContext();
        // GET: HomePage
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Billing()
        {
            return View();
        }
        public ActionResult Thanks()
        {
            return View();
        }
        public ActionResult LandingPage1()
        {
            return View();
        }
        
        public ActionResult Checkout()
        {
            return View();
        }
      public ActionResult Singlenew()
        {
            return View();
        }
        public ActionResult Nosuch()
        {
            return View();
        }
        public ActionResult SearchResult(string searched)
        {
            if (searched== null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            string query = "select * from tblProducts where FREETEXT(Meta, '"+searched+"')";
            IEnumerable<tblProduct> data = db.Database.SqlQuery<tblProduct>(query);

            if (data == null)
            {
                return RedirectToAction("Nosuch");
            }
            return View(data.ToList());
        }
      
        

        public ActionResult Single()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Single(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Commenting out original code to show how to use a raw SQL query.
            //Department department = await db.Departments.FindAsync(id);

            // Create and execute raw SQL query.
            string query = "SELECT * FROM tblProducts WHERE PId = @p0";
            tblProduct data = await db.tblProducts.SqlQuery(query, id).SingleOrDefaultAsync();

            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }
    }
    }
