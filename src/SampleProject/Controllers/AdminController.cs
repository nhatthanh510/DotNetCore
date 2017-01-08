using System;
using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("save")]
        [Route("~/save")]
        public string Save()
        {
            return "Saved";
        }

        [Route("delete/{id?}")]
        public string Delete(int id = 0)
        {
            return String.Format("Deleted : {0}", id);
        }
    }
}
