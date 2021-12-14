﻿using Dapper;
using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class ReservationDataAccess : BaseDataAccess<Reservation>, IReservationDataAccess
    {
        public ReservationDataAccess(string connectionstring) : base(connectionstring)
        {
            Values = new List<string> { "creation_time", "user_id", "seat_id", "show_id" };
            RawValues = new List<string> { "CreationTime", "UserId", "SeatId", "ShowId" };
        } 

        // Overload of the CreateAsync method from BaseDataAccess to accept and return IEnumerables
        public async Task<bool> CreateAsync(IEnumerable<Reservation> reservations)
        {
            string command = $"UPDATE [Reservation] SET creation_time = @CreationTime, user_id = @UserId WHERE seat_id IN @SeatIds AND show_id = @ShowId AND user_id IS NULL;";
            try
            {
                using var connection = CreateConnection();
                connection.Open();
                using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                try
                {
                    int userId = reservations.FirstOrDefault().UserId;
                    int showId = reservations.FirstOrDefault().ShowId;
                    int[] seatIds = reservations.Select(res => res.SeatId).ToArray();
                    int rowsAffected = await connection.ExecuteAsync(command, new { CreationTime = DateTime.Now, UserId = userId, SeatIds = seatIds, ShowId = showId }, transaction);
                    if (rowsAffected < reservations.Count())
                    {
                        transaction.Rollback();
                        return false;
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Error during async creation of 'Reservation'!\nMessage was: '{ex.Message}'\nTable Name: Reservation\nCommand: {command}", ex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during establishing connection. Message was '{ex.Message}'", ex);
            }
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByShowIdAsync(int showId)
        {
            string command = "SELECT * FROM Reservation WHERE show_id=@ShowId AND user_id IS NOT NULL";
            try
            {
                using var connection = CreateConnection();
                connection.Open();
                using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                try
                {
                    return await connection.QueryAsync<Reservation>(command, new { ShowId = showId }, transaction);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Error during async creation of 'Reservation'!\nMessage was: '{ex.Message}'\nTable Name: Reservation\nCommand: {command}", ex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting List of Reservations by selected Show id {showId}. Error: {ex.Message}", ex);
            }
        }
        public async Task<bool> DeleteByShowAndSeatIdAsync(int showId, int seatId)
        {
            string command = $"UPDATE [Reservation] SET creation_time = NULL, user_id = NULL WHERE show_id=@showId AND seat_id=@seatId";
            try
            {
                using var connection = CreateConnection();
                return await connection.ExecuteAsync(command, new { ShowId = showId, SeatId = seatId}) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during async deletion of reservation with Seat-Id:{seatId} and Show-Id:{showId}!\nMessage was: '{ex.Message}'\nTable Name: {TableName}\nCommand: {command}", ex);
            }
        }

        public async Task<IEnumerable<Reservation>> GetByUserAndShowIdAsync(int showId, int userId)
        {
            string command = "SELECT * FROM Reservation WHERE show_id=@ShowId AND user_id=@UserId";
            try
            {
                using var connection = CreateConnection();
                return await connection.QueryAsync<Reservation>(command, new { ShowId = showId, UserId = userId});
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting List of Reservations by selected Show id {showId}. Error: {ex.Message}", ex);
            }
        }

        public async Task<IEnumerable<Reservation>> GetByUserIdAsync(int userId)
        {
            string command = "SELECT * FROM Reservation WHERE user_id=@UserId";
            try
            {
                using var connection = CreateConnection();
                return await connection.QueryAsync<Reservation>(command, new {UserId = userId });
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting List of Reservations by selected User id {userId}. Error: {ex.Message}", ex);
            }
        }
    }
}
