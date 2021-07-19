using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebScrapperMVC.Models;


namespace WebScrapperMVC.Controllers
{
    public class HomeController : Controller
    {
        Scraper scraper;

      
        public ActionResult Index()
        {
           
            return View();
        }


        [HttpPost]
        public ActionResult Index( string teste)
        {
            scraper = new Scraper();

            scraper.ScrapeData(teste);

            return Json(scraper);
        }


 


  


    }
}
