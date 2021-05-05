using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class FootballClubControllerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            FootballClubController FootballClub = new FootballClubController();
            //test to see that it exists
            Assert.IsNotNull(FootballClub);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            FootballClubController FootballClub = new FootballClubController();
            //test to see that it exists           
            Assert.IsNotNull(FootballClub);
        }

        //Passes
        //[TestMethod]
        //public void Rate_Min()
        //{
        //    FootballClubController footballClub = new FootballClubController();
        //    //test data to assign to the test
        //    Int32 passes = 0;
        //    DateTime date = new DateTime(2021, 1, 01);
        //    string valid = footballClub.valid(passes);
        //    //Test
        //    Assert.AreEqual(valid, "");
        //}

    }
}
