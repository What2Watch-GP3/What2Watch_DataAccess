﻿using DataAccess.DataAccess;
using DataAccess.Interfaces;
using DataAccess.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataAccess
{
    class ShowTest
    {
        private IShowDataAccess _showDataAccess;

        [OneTimeSetUp]

        public async Task SetUp()
        {
            _showDataAccess = new ShowDataAccess(Configuration.CONNECTION_STRING_TEST);
        }

        [Test]
        public async Task GettingOneShowById1ReturnsAShow()
        {
            //act
            var show = await _showDataAccess.GetByIdAsync(1);
            //assert
            Assert.NotNull(show, $"No Show found by the id 1");
        }

        [Test]
        public async Task GettingAListOfShowsByMovieAndCinemaReturnsListBiggerThan0WithCorrectDate()
        {
            //act
            var shows = (await _showDataAccess.GetListByMovieAndCinemaIdAsync(1, 1)).ToList();
            string expectedStartTime = "17.11.2021 18:00:00";

            //assert
            Assert.IsTrue(shows.Count() > 0, "List of shows is currently 0");
            Assert.AreEqual(expectedStartTime, shows[0].StartTime.ToString("G", CultureInfo.CreateSpecificCulture("de-DE")), "The time was wrong.");
        }

        [Test]
        public async Task InsertingShowInDatabaseReturningId()
        {
            //arrange
            Show show = new() { StartTime = DateTime.Now, MovieId = 1, RoomId = 1 };
            //act
            int actualId = await _showDataAccess.CreateAsync(show);
            //assert
            Assert.IsTrue(actualId > 0, $"Created Show returned wrong id {actualId}");
        }
    }
}
