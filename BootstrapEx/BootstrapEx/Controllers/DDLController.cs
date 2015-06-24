using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SamplesData;

namespace BootstrapEx.Controllers
{
    public class DDLController : Controller
    {
        // GET: DDL
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ex2()
        {
            MusicGenre entity = new MusicGenre();

            return View(entity);
        }

        public ActionResult Ex3()
        {
            MusicGenre entity = new MusicGenre();

            return View(entity);
        }

        public ActionResult Ex4()
        {
            MusicGenre entity = new MusicGenre();

            return View(entity);
        }

        public ActionResult DA()
        {
            MusicGenreViewModel vm = new MusicGenreViewModel();

            return View(vm);
        }

        [HttpPost]
        public ActionResult DA(MusicGenreViewModel vm)
        {
            System.Diagnostics.Debugger.Break();

            ModelState.Clear();

            return View(vm);
        }
    }
}