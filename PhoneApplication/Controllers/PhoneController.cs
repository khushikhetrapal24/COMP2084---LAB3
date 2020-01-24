using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;
namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {

            var phonelist = new List<Phone>
                {
                    new Phone {PhoneId = 01, PhoneName = "Apple", Manufacturer = "Apple"},
                new Phone { PhoneId = 02,PhoneName = "Samsung", Manufacturer= "Samsung"},

                };
            
            return View(phonelist);
        }
    }
}