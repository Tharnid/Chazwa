using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    // Repository pattern to separate controller from database code
    // you don't want to hard code actual db into controllers

    public class WorldRepository : IWorldRepository
    {
        private WorldContext _context;

        // Constructor Injection
        public WorldRepository(WorldContext context)
        {
            _context = context;
        }

        public IEnumerable<Trip> GetAllTrips()
        {
            return _context.Trips.OrderBy(t => t.Name).ToList();
        }

        public IEnumerable<Trip> GetAllTripsWithStops()
        {
            return _context.Trips
            .Include(t => t.Stops)
            .OrderBy(t => t.Name)
            .ToList();
        }
    }
}
