using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Models;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class PlayerControllerTest
    {


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //test to see that it exists
            Assert.IsNotNull(Player);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //test to see that it exists           
            Assert.IsNotNull(Player);
        }

        [TestMethod]
        public void FirstnameOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //create some test data to assign to the property
            string AFirstname = "Jamie";
            //assign the data to the property
            Player.Firstname = AFirstname;
            //test to see that it exists
            Assert.AreEqual(Player.Firstname, AFirstname);

        }

        [TestMethod]
        public void LastnameOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //create some test data to assign to the property
            string ALastname = "Vardi";
            //assign the data to the property
            Player.Lastname = ALastname;
            //test to see that it exists
            Assert.AreEqual(Player.Lastname, ALastname);

        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //create some test data to assign to the property
            DateTime ADateOfBirth = new DateTime(1993, 3, 19);
            //assign the data to the property
            Player.DateOfBirth = ADateOfBirth;
            //test to see that it exists
            Assert.AreEqual(Player.DateOfBirth, ADateOfBirth);
        }

        [TestMethod]
        public void PositionOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //create some test data to assign to the property
            string APosition = "Midfielder";
            //assign the data to the property
            Player.Position = APosition;
            //test to see that it exists
            Assert.AreEqual(Player.Position, APosition);

        }

        [TestMethod]
        public void GoalsOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //create some test data to assign to the property
            int AGoals = 18;
            //assign the data to the property
            Player.Goals = AGoals;
            //test to see that it exists
            Assert.AreEqual(Player.Goals, AGoals);

        }

        [TestMethod]
        public void AssistsOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //create some test data to assign to the property
            int AAssists = 18;
            //assign the data to the property
            Player.Assists = AAssists;
            //test to see that it exists
            Assert.AreEqual(Player.Assists, AAssists);

        }

        [TestMethod]
        public void YellowCardsOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //create some test data to assign to the property
            int AYellowCards = 2;
            //assign the data to the property
            Player.YellowCards = AYellowCards;
            //test to see that it exists
            Assert.AreEqual(Player.YellowCards, AYellowCards);

        }

        [TestMethod]
        public void RedCardsOK()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            //create some test data to assign to the property
            int ARedCards = 0;
            //assign the data to the property
            Player.RedCards = ARedCards;
            //test to see that it exists
            Assert.AreEqual(Player.RedCards, ARedCards);

        }

        [TestMethod]
        public void FirstnameMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "aa";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMax()
        {

            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "a";
            Firstname = Firstname.PadRight(20);
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstnameMinMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "a";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Firstname is too short");


        }
        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "a";
            Firstname = Firstname.PadRight(21);
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Firstname is too long");


        }

        [TestMethod]
        public void FirstnameMaxMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "a";
            Firstname = Firstname.PadRight(19);
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void FirstnameMinPlusOne()
        {

            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "aaa";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void FirstnameMid()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "a";
            Firstname = Firstname.PadRight(10);
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstnameExtremeMax()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "";
            Firstname = Firstname.PadRight(50);
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Firstname is too long");


        }

        [TestMethod]
        public void LastnameMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "aa";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMax()
        {

            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";           
            string Lastname = "aa";
            Lastname = Lastname.PadRight(50);
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LastnameMinMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "a";           
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Lastname is too short");


        }
        [TestMethod]
        public void LastnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";           
            string Lastname = "a";
            Lastname = Lastname.PadRight(51);
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Lastname is too long");


        }

        [TestMethod]
        public void LastnameMaxMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";           
            string Lastname = "a";
            Lastname = Lastname.PadRight(49);
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void LastnameMinPlusOne()
        {

            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "aaa";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void LastnameMid()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";           
            string Lastname = "a";
            Lastname = Lastname.PadRight(25);
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LastnameExtremeMax()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";            
            string Lastname = "";
            Lastname = Lastname.PadRight(100);
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Lastname is too long");


        }


        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(-16);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(+100);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateOfBirthMinMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(-17);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "too old");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(+101);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "too young");
            
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(-15);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
                                   
        }
        [TestMethod]
        public void DateOfBirthMaxMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(+99);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");


       

        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(+50);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(+200);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "too young");
        }
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now.AddYears(-100);
            string Position = "Midfielder";
            int Goals = 14;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "too old");
        }

        [TestMethod]
        public void GoalsMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 0;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GoalsMinMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = -1;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Cannot have negative goals");
        }
        [TestMethod]
        public void GoalsMinPlusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 1;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GoalsMid()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 5;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GoalsExtremeMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = -100;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Cannot have negative goals");
        }

        [TestMethod]
        public void AssistsMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 12;
            int Assists = 0;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AssistsMinMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 5;
            int Assists = -1 ;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Cannot have negative assists");
        }
        [TestMethod]
        public void AssistsMinPlusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 5;
            int Assists = 1;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AssistsMid()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 5;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AssistsExtremeMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 5;
            int Assists = -100;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Cannot have negative assists");
        }
        [TestMethod]
        public void YellowCardsMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 1;
            int Assists = 5;
            int YellowCards = 0;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void YellowCardsMinMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 1;
            int Assists = 5;
            int YellowCards = -1;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Cannot have negative yellow cards");
        }
        [TestMethod]
        public void YellowCardsMinPlusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 1;
            int Assists = 5;
            int YellowCards = 1;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void YellowCardsMid()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 5;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void YellowCardsExtremeMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = -100;
            int Assists = 5;
            int YellowCards = -100;
            int RedCards = 2;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Cannot have negative yellow cards");
        }
        [TestMethod]
        public void RedCardsMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 2;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 0;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RedCardsMinMinusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = -1;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = -1;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Cannot have negative red cards");
        }
        [TestMethod]
        public void RedCardsMinPlusOne()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 1;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 1;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RedCardsMid()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = 5;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = 5;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RedCardsExtremeMin()
        {
            //create an instance of the class we want to create
            PlayerModel Player = new PlayerModel();
            string Firstname = "Jamie";
            string Lastname = "Vardi";
            DateTime DateOfBirth = DateTime.Now;
            string Position = "Midfielder";
            int Goals = -100;
            int Assists = 5;
            int YellowCards = 5;
            int RedCards = -100;
            string Error = PlayerModel.valid(Firstname, Lastname, DateOfBirth, Position,
             Goals, Assists, YellowCards, RedCards);
            Assert.AreEqual(Error, "Cannot have negative red cards");
        }


    }
}

