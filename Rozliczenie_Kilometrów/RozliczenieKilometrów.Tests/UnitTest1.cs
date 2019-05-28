using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RozliczenieKilometrów;
using Settlement_of_kilometers;

namespace RozliczenieKilometrów.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNewRideTests()
        {
            // Do wymyślenia testy wczytywane z pliku
            var ride = new Ride();
            fill(ride, 10, 20, 1, DateTime.Now);

            Assert.IsTrue(ride.DataCompleted());
        }

        public void fill(Ride ride, double start, double end, double capacity, DateTime date)
        {
            ride.StardRoad = start;

            ride.EndRoad = end;
            ride.Capacity = capacity;
            ride.Date = date;
        }
    }
}
