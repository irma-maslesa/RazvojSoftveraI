using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RS1.Ispit.Web.EF;

namespace RS1.Ispit.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

       
    }
}