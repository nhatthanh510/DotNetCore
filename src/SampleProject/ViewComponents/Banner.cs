using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using SampleProject.Models;

namespace SampleProject.ViewComponents
{
    public class Banner : ViewComponent
    {
        public ViewViewComponentResult Invoke(string filter)
        {
            List<string> categories = new List<string>()
            {
                "Thanh Nguyen",
                "Trinh Nguyen",
                "Diep Lam"
            };
            categories = categories.Where(c => c.Contains(filter)).ToList();
            return View(new BannerModel {Categories = categories});
        }
    }
}
