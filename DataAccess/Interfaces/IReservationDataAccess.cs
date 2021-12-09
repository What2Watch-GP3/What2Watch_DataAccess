﻿using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IReservationDataAccess : IBaseDataAccess<Reservation>
    {
        Task<bool> CreateAsync(IEnumerable<Reservation> reservations);
        Task<bool> DeleteByShowAndSeatIdAsync(int showId, int seatId);
    }
}
