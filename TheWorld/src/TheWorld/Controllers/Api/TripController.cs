﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TheWorld.Models;
using TheWorld.ViewModels;
using System.Net;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace TheWorld.Controllers.Api
{
    [Route("api/trips")]
    public class TripController : Controller
    {
        private ILogger<TripController> _logger;
        private IWorldRepository _repository;

        public TripController(IWorldRepository repository, ILogger<TripController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("")]
        public JsonResult Get()
        {
            //var results = _repository.GetAllTripsWithStops();
            var results = Mapper.Map<IEnumerable<TripViewModel>>(_repository.GetAllTripsWithStops());  // has to say IENumerable
            // return Json(new { name = "Tharnid" });
            return Json(results);
        }

        [HttpPost("")]
        public JsonResult Post([FromBody]TripViewModel vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newTrip = Mapper.Map<Trip>(vm);

                    // Save to database
                    _logger.LogInformation("Attempting to save a new trip!!!");
                    _repository.AddTrip(newTrip);

                    if (_repository.SaveAll())
                    {
                        Response.StatusCode = (int)HttpStatusCode.Created;
                        return Json(Mapper.Map<TripViewModel>(newTrip));
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to save new Trip man!!!", ex);
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json( new { Message = ex.Message });
            }

            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(new { Message = "Failed", ModelState = ModelState});
        }
    }
}