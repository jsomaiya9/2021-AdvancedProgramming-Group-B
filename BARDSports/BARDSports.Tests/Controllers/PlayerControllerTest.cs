using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class PlayerControllerTest
    {
       // good test data
        //create some test data to pass to the method
        string Firstname = "Hakim";
        string Lastname = "Ziyech";
        DateTime DateOfBirth = new DateTime(1993, 3, 19);
        string Position = "Midfielder";
        string Goals = "18";
        string Assists = "18";
        string YellowCards = "2";
        string RedCards = "0";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
           PlayerController Player = new PlayerController();
            //test to see that it exists
            Assert.IsNotNull(Player);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //test to see that it exists           
            Assert.IsNotNull(Player);
        }

        [TestMethod]
        public void FirstnameOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string AFirstname = "Hakim";
            //assign the data to the property
            Player.Firstname = AFirstname;
            //test to see that it exists
            Assert.AreEqual(Player.Firstname, AFirstname);

        }

        [TestMethod]
        public void LastnameOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string ALastname = "Khan";
            //assign the data to the property
            Player.Lastname = ALastname;
            //test to see that it exists
            Assert.AreEqual(Player.Lastname, ALastname);

        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
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
            PlayerController Player = new PlayerController();
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
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string AGoals = "18";
            //assign the data to the property
            Player.Goals = AGoals;
            //test to see that it exists
            Assert.AreEqual(Player.Goals, AGoals);

        }

        [TestMethod]
        public void AssistsOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string AAssists= "18";
            //assign the data to the property
            Player.Assists = AAssists;
            //test to see that it exists
            Assert.AreEqual(Player.Assists, AAssists);

        }

        [TestMethod]
        public void YellowCardsOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string AYellowCards = "2";
            //assign the data to the property
            Player.YellowCards = AYellowCards;
            //test to see that it exists
            Assert.AreEqual(Player.YellowCards, AYellowCards);

        }

        [TestMethod]
        public void RedCardsOK()
        {
            //create an instance of the class we want to create
            PlayerController Player = new PlayerController();
            //create some test data to assign to the property
            string ARedCards = "0";
            //assign the data to the property
            Player.RedCards = ARedCards;
            //test to see that it exists
            Assert.AreEqual(Player.RedCards, ARedCards);

        }

        //[TestMethod]
        //public void FirstNameMin()
        //{
        //    //create an instance of the class we want to create
        //    PlayerController Player = new PlayerController();
        //    string Firstname = "a";
        //    string Lastname = "Vardi";           
        //    DateTime DateOfBirth = new DateTime(2001, 1, 13);
        //    string Position = "Midfielder";
        //    int Goals = 14;
        //    int Assists= 5;
        //    int YellowCards = 5;
        //    int RedCards = 2;
        //    int Error = PlayerController.valid(Firstname, Lastname,DateOfBirth, Position,
        //     Goals, Assists, YellowCards, RedCards);
        //    Assert.AreEqual(Error, "Name is too short");
        //}

        //[TestMethod]
        //public void FirstNameMax()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "a";
        //    FirstName = FirstName.PadRight(20);
        //    string LastName = "Khan";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2002, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void FirstNameMinMinusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "";
        //    string LastName = "Khan";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void FirstNameMaxPlusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "a";
        //    FirstName = FirstName.PadRight(20);
        //    string LastName = "Khan";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    //string valid = PersonalDetail.valid(FirstName, testData);
        //    Assert.AreEqual(Error, "too young");
        //}

        //[TestMethod]
        //public void FirstNameMaxMinusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "";
        //    string LastName = "Khan";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void FirstNameMinPlusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "";
        //    string LastName = "Khan";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void FirstNameMid()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "";
        //    string LastName = "Khan";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void FirstNameExtremeMax()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "";
        //    string LastName = "Khan";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}


        //[TestMethod]
        //public void LastNameMin()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "Salman";
        //    string LastName = "";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}

        //[TestMethod]
        //public void LastNameMax()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "Salman";
        //    string LastName = "";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}

        //[TestMethod]
        //public void LastNameMinMinusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "Salman";
        //    string LastName = "";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //    City, Postcode, Telephone);
        //    //string valid = PersonalDetail.valid(LastName, testData);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void LastNameMaxPlusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "Salman";
        //    string LastName = "";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}

        //[TestMethod]
        //public void LastNameMaxMinusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "Salman";
        //    string LastName = "";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void LastNameMinPlusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "Salman";
        //    string LastName = "";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void LastNameMid()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "Salman";
        //    string LastName = "";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void LastNameExtremeMax()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    string FirstName = "Salman";
        //    string LastName = "";
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}
        //[TestMethod]
        //public void DOBMin()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    DateTime testData = DateTime.Now.AddYears(-16);
        //    string Street = "1 Bishops Avenue";
        //    string FirstName = "Salman";
        //    DateTime DOB = new DateTime(2002, 1, 13);
        //    string LastName = "Khan";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void DOBMax()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    DateTime testData = DateTime.Now.AddYears(-110);
        //    string Street = "1 Bishops Avenue";
        //    string FirstName = "Salman";
        //    DateTime DOB = new DateTime(2005, 1, 13);
        //    string LastName = "Khan";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void DOBMinMinusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();

        //    string FirstName = "Salman";
        //    DateTime DOB = new DateTime(2006, 1, 13);
        //    string LastName = "Khan";
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}

        //[TestMethod]
        //public void DOBMaxPlusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();

        //    string FirstName = "Salman";
        //    DateTime DOB = new DateTime(2006, 1, 13);
        //    string LastName = "Khan";
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");
        //}

        //[TestMethod]
        //public void DOBMinPlusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();

        //    string FirstName = "Salman";
        //    DateTime DOB = new DateTime(2004, 1, 13);
        //    string LastName = "Khan";
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void DOBMaxMinusOne()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    DateTime testData = DateTime.Now.AddYears(-109);
        //    string FirstName = "Salman";
        //    string LastName = "aa";
        //    DateTime DOB = new DateTime(2021, 1, 13);
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "too young");

        //}

        //[TestMethod]
        //public void DOBMid()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();


        //    string FirstName = "Salman";
        //    DateTime DOB = new DateTime(1978, 1, 13);
        //    string LastName = "Khan";
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string Error = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void DOBExtremeMax()
        //{
        //    clsPersonalDetail PersonalDetail = new clsPersonalDetail();
        //    DateTime testData = DateTime.Now.AddYears(-120);

        //    string FirstName = "Salman";
        //    DateTime DOB = new DateTime(2099, 1, 13);
        //    string LastName = "Khan";
        //    string Street = "1 Bishops Avenue";
        //    string City = "London";
        //    string Postcode = "N25RF";
        //    string Telephone = "02081234567";
        //    string valid = PersonalDetail.valid(FirstName, DOB, Street, LastName,
        //     City, Postcode, Telephone);
        //    Assert.AreEqual(valid, "too young");
        //}


     

    }
}
