using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreContactForm.Models;

namespace MVCCoreContactForm.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactFormModel form)
        {
            form.postData();

            return RedirectToAction("Index", "Home");
        }
    }
}
