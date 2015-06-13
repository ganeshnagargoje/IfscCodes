using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IfscCodes.DataLibrary;
namespace IfscCodes.Web.Controllers
{
    public class CountryController : Controller
    {
        //
        // GET: /Country/

        public ActionResult Index()
        {
            List<Country> countries = new CountryModel().GetCountries();
            return View(countries);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
