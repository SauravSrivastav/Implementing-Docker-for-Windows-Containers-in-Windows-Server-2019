using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private CustomerRepository customerRepository;

        public HomeController()
        {
            customerRepository = new CustomerRepository(ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString);
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Let's count donuts";

            var customers = customerRepository.LoadAllCustomers();
            return View(customers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "About our donut app.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This donut app's contact page.";

            return View();
        }
    }
}