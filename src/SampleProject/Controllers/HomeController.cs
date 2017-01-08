using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World !";
        }

        public ViewResult Index2()
        {
            CustomerViewModel customerViewModel = new CustomerViewModel()
            {
                CustomerId = "01",
                CompanyName = "Bluecom",
                City = "HCM",
                ContactName = "Thanh Nguyen",
                Country = "VN"
            };
            return View(customerViewModel);
        }

        public ViewResult Index3()
        {
            return View();
        }

        public ViewResult Index4()
        {
            return View();
        }
    }
}
