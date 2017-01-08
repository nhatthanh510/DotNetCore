using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Save()
        {
            CustomerViewModel customerViewModel = new CustomerViewModel
            {
                ContactName = "Thanh Nguyen",
                CompanyName = "Bluecom",
                City = "HCM",
                Country = "Turkey"
            };
            return View(customerViewModel);
        }

        [HttpPost]
        public string Save(CustomerViewModel customerViewModel)
        {
            return customerViewModel.ContactName + " is saved";
        }
    }
}
