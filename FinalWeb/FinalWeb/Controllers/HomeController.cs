using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;
using FinalWeb.Models;
namespace FinalWeb.Controllers
{
    public class HomeController : Controller
    {
        FinalDBContext db = new FinalDBContext();
        
        public ActionResult Index()
        {

            int selectedIndex = 1;
            SelectList reg = new SelectList(db.Regions, "Region_id", "Name_region", selectedIndex);
            
            ViewBag.Regions = reg;
            
        
            SelectList cit = new SelectList(db.Cities.Where(c => c.Region_id == selectedIndex), "Id", "Region_id", "Name_city");
            ViewBag.Cities = cit;
           return View();
            
        }

        [HttpPost]
        public JsonResult TestRC(Test_RegCit test)
        {

            db.Test_ReqCitys.Add(test);
            db.SaveChanges();
            return Json(test);
        }
        
        [HttpPost]
        public PartialViewResult Address(Address address)
        {
                db.Addresses.Add(address);
            db.SaveChanges();
            return PartialView(address);
        }
        [HttpPost]
        public PartialViewResult ReqPayer(RequisitesPayer reqpay)
        {
            db.RequisitesPayers.Add(reqpay);
            db.SaveChanges();


            return PartialView(reqpay);
        }

        public ActionResult GetItems(int id)
        {
            return PartialView(db.Cities.Where(c => c.Region_id == id).ToList());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
//using (FinalDBContext context = new FinalDBContext())
//{
//    RequisitesPayer payer = context.RequisitesPayers.Where(x => x.Id == reqpay.Id).First();
//    payer.Tax_user = reqpay.Tax_user;
//    payer.Surname_user = reqpay.Surname_user;
//    payer.TypeFace_user = reqpay.TypeFace_user;
//    payer.ReqNumber = reqpay.ReqNumber;
//    context.SaveChanges();
//}
//return PartialView();