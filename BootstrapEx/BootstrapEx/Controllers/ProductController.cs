using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapEx.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly ICurrentUser _currentUser;

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}