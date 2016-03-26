using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TheWorld.Models;
using TheWorld.ViewModels;
using System.Net;
using AutoMapper;

namespace TheWorld.Controllers.Api
{
    [Route("api/trips")]
    public class TripController : Controller
    {
        private IWorldRepository _repository;

        public TripController(IWorldRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public JsonResult Get()
        {
            //var results = _repository.GetAllTripsWithStops();
            var results = Mapper.Map<IEnumerable<TripViewModel>>(_repository.GetAllTripsWithStops());  // has to say IENumerable
            // return Json(new { name = "Tharnid" });
            return Json(results);
        }

        //[HttpPost("")]
        //public JsonResult Post([FromBody]Trip vm)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        var newTrip = Mapper.Map<Trip>(vm);

        //        // Save to database


        //        Response.StatusCode = (int)HttpStatusCode.Created;
        //        return Json(true);
        //    }

        //    Response.StatusCode = (int)HttpStatusCode.BadRequest;
        //    // return Json("Epic Fail!!!");
        //    return Json(new { Message = "Failed", ModelState = ModelState });
        //}

        [HttpPost("")]
        public JsonResult Post([FromBody]TripViewModel vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newTrip = Mapper.Map<Trip>(vm);

                    // Save to database
                   // _repository.AddTrip(newTrip);


                    Response.StatusCode = (int)HttpStatusCode.Created;
                    return Json(Mapper.Map<TripViewModel>(newTrip));
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json( new { Message = ex.Message });
            }

            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(new { Message = "Failed", ModelState = ModelState});
        }
    }
}
