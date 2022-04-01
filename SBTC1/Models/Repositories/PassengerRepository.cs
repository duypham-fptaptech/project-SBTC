﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SBTC1.Models.Entilities;
using SBTC1.Models.IEntityRepositories;

namespace SBTC1.Models.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly AppDbContext context;
        public PassengerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Passenger Add(Passenger passenger)
        {
            context.Passenger.Add(passenger);
            context.SaveChanges();
            return passenger;
        }

        public bool Delete(string passengerUserId)
        {
            Passenger user = GetPassenger(passengerUserId);
            if (user != null)
            {
                context.Passenger.Remove(user);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Passenger GetPassenger(string passengerUserId)
        {
            return context.Passenger.Find(passengerUserId);
        }

        public IEnumerable<Passenger> GetPassengerList()
        {
            return context.Passenger;
        }

        public Passenger Update(Passenger passengerChanges)
        {
            var administrator = context.Passenger.Attach(passengerChanges);
            administrator.State = EntityState.Modified;
            context.SaveChanges();
            return passengerChanges;
        }
    }
}
