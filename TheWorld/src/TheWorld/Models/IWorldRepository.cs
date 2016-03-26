using System.Collections.Generic;

namespace TheWorld.Models
{
    public interface IWorldRepository
    {
        // interfaces just have the public method declarations
        IEnumerable<Trip> GetAllTrips();
        IEnumerable<Trip> GetAllTripsWithStops();
        void AddTrip(Trip newTrip);
        bool SaveAll();
    }
}