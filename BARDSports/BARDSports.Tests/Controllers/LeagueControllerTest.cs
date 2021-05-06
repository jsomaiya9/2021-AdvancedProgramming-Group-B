using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;
using BARDSports.Models;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class LeagueControllerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            LeagueController League = new LeagueController();
            //test to see that it exists
            Assert.IsNotNull(League);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            LeagueController League = new LeagueController();
            //test to see that it exists           
            Assert.IsNotNull(League);
        }

        //Seaons
        [TestMethod]
        public void Seasons_ExtremeMin()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "a";
            string LeaugeName = "a";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too short");
        }

        [TestMethod]
        public void Seasons_MinMinus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "a";
            string LeaugeName = "a";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too short");
        }

        [TestMethod]
        public void Seasons_Min()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2";
            Seasons = Seasons.PadRight(7);
            string LeaugeName = "a";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too Short");
        }

        [TestMethod]
        public void Seasons_MinPlus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2";
            Seasons = Seasons.PadRight(7);
            string LeaugeName = "aa";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Seasons_MaxMinus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2";
            Seasons = Seasons.PadRight(7);
            string LeaugeName = "aa";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Seasons_Max()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2";
            Seasons = Seasons.PadRight(7);
            string LeaugeName = "aa";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Seasons_MaxPlus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "a";
            Seasons = Seasons.PadRight(31);
            string LeaugeName = "a";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too long");
        }

        [TestMethod]
        public void Seasons_ExtremeMax()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "a";
            Seasons = Seasons.PadRight(50);
            string LeaugeName = "a";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too long");
        }

        [TestMethod]
        public void Seasons_Mid()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "a";
            Seasons = Seasons.PadRight(14);
            string LeaugeName = "a";
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too long");
        }

        //LeaugeName
        [TestMethod]
        public void LeaugeName_ExtremeMin()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(1);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too Short");
        }

        [TestMethod]
        public void LeaugeName_MinMinus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(1);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too Short");
        }

        [TestMethod]
        public void LeaugeName_Min()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(2);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void LeaugeName_MinPlus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(3);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Leauge_MaxMinus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(29);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void LeaugeName_Max()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(30);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void LeaugeName_MaxPlus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(31);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too long");
        }

        [TestMethod]
        public void LeaugeName_ExtremeMax()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(50);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too long");
        }

        [TestMethod]
        public void LeaugeName_Mid()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            LeaugeName = LeaugeName.PadRight(15);
            string Description = "a";
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        //Description
        [TestMethod]
        public void Description_Min()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            string Description = "a";
            LeaugeName = LeaugeName.PadRight(1);
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too Short");
        }

        [TestMethod]
        public void Description_MinPlus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "a";
            string Description = "a";
            LeaugeName = LeaugeName.PadRight(2);
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Description_MaxMinus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "aa";
            string Description = "a";
            Description = Description.PadRight(49);
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Description_Max()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "aa";
            string Description = "a";
            Description = Description.PadRight(50);
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Description_MaxPlus1()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "aa";
            string Description = "a";
            Description = Description.PadRight(51);
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too long");
        }

        [TestMethod]
        public void Description_Mid()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "aa";
            string Description = "a";
            Description = Description.PadRight(25);
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Description_Extreme()
        {
            //create an instance of the class we want to create
            LeagueModel league = new LeagueModel();
            //test data
            string Seasons = "2020/21";
            string LeaugeName = "aa";
            string Description = "a";
            Description = Description.PadRight(1000);
            string valid = league.valid(LeaugeName, Description, Seasons);
            //test to check the length
            //Test
            Assert.AreEqual(valid, "Too long");
        }

        


    }
}
