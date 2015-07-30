using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InformIT.Domain;
using InformIT.Infrastructure;
using InformIT.Models;

namespace InformIT.Controllers
{
    public class ConferenceController : Controller
    {
        private readonly IConferenceRepository _repository;

        public ConferenceController(IConferenceRepository repository)
        {
            _repository = repository;
        }

        // GET: Conference
        public ActionResult Index()
        {
            IEnumerable<Conference> conferences = _repository.GetAll();
            ConferenceListModel[] models = MapToListModel(conferences);
            return View();
        }

        private ConferenceListModel[] MapToListModel(IEnumerable<Conference> conferences)
        {
            conferences.Select(c => new ConferenceListModel())
        }
    }
}