using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class GetProductController : Controller
    {
        // GET: GetProduct
        public ActionResult GetProduct()
        {
            GetProductDB db = new GetProductDB();
            List<GetProduct> obj = db.getProducts();

            return View(obj);
        }

        public ActionResult AddProduct()
        {


            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(GetProduct prr)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    GetProductDB contex = new GetProductDB();
                    bool check = contex.AddProduct(prr);
                    if (check)
                    {
                        TempData["InsertMessage"] = "Data has been inserted sucessfully";
                        ModelState.Clear();
                        return RedirectToAction("GetProduct");
                    }
                    else
                    {
                        TempData["InsertMessage"] = "ID is already Existed";
                        
                        return View("AddProduct");
                    }
                }
            }
            catch 
            {
                TempData["InsertMessage"] = "ID is too long it should be 3 digits long.";
                return View();
            }



            return View();
        }

    }
}