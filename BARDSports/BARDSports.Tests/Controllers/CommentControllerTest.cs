using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BARDSports.Controllers;
using BARDSports.Models;

namespace BARDSports.Tests.Controllers
{
    [TestClass]
    public class CommentControllerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            CommentsModel Comment = new CommentsModel();
            //test to see that it exists
            Assert.IsNotNull(Comment);

        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create
            CommentsModel Comment = new CommentsModel();
            //test to see that it exists           
            Assert.IsNotNull(Comment);
        }
        // DATE
        [TestMethod]
        public void DateOK()
        {
            //create an instance of the class we want to create
            CommentsModel comments = new CommentsModel();
            //create some test data to assign to the property
            DateTime date = new DateTime(1993, 3, 19);
            //assign the data to the property
            comments.Date = date;
            //test to see that it exists
            Assert.AreEqual(comments.Date, date);
        }
        //Date
        [TestMethod]
        public void Date_ExtremeMin()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to tests
            DateTime date = new DateTime(2020, 1, 01);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "Too long ago");
        }

        [TestMethod]
        public void Date_MinMinus1()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to tests
            DateTime date = DateTime.Now.AddYears(-1).AddDays(-1);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "Too long ago");
        }

        [TestMethod]
        public void Date_Min()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to tests
            DateTime date = new DateTime(2021, 1, 01);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Date_Minplus1()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to tests
            DateTime date = new DateTime(2021, 1, 02);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Date_MaxMinus1()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the tests
            DateTime date = DateTime.Now.AddYears(+10).AddDays(-1);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Date_Max()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the tests
            DateTime date = DateTime.Now.AddYears(+10);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Date_MaxPlus1()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the tests
            DateTime date = DateTime.Now.AddYears(+10).AddDays(+1);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "Too far in the future");
        }

        [TestMethod]
        public void Date_Mid()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            DateTime date = DateTime.Now.AddYears(+5);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Date_ExtremeMax()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            DateTime date = new DateTime(5315, 1, 01);
            //assign data to the property
            string valid = comments.valid(4, date);
            //test
            Assert.AreEqual(valid, "Too far in the future");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Date_Invalid()
        {
            CommentsModel comments = new CommentsModel();
            comments.Date = Convert.ToDateTime("mayistandunshaken");

        }

        //Rating
        [TestMethod]
        public void Rate_Min()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            Int32 Rating = 0;
            DateTime date = new DateTime(2021, 1, 01);
            string valid = comments.valid(Rating, date);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Rate_MinPlus1()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            Int32 Rating = 1;
            DateTime date = new DateTime(2021, 1, 01);
            string valid = comments.valid(Rating, date);
            //Test
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Rate_MaxMinus1()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            Int32 Rating = 9;
            DateTime date = new DateTime(2021, 1, 01);
            string valid = comments.valid(Rating, date);
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Rate_Max()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            Int32 Rating = 10;
            DateTime date = new DateTime(2021, 1, 01);
            string valid = comments.valid(Rating, date);
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Rate_MaxPlus1()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            Int32 Rating = 11;
            DateTime date = new DateTime(2021, 1, 01);
            string valid = comments.valid(Rating, date);
            Assert.AreEqual(valid, "To high rating");
        }

        [TestMethod]
        public void Rate_Mid()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            Int32 Rating = 5;
            DateTime date = new DateTime(2021, 1, 01);
            string valid = comments.valid(Rating, date);
            Assert.AreEqual(valid, "");
        }

        [TestMethod]
        public void Rate_ExtremeMax()
        {
            CommentsModel comments = new CommentsModel();
            //test data to assign to the test
            Int32 Rating = 20;
            DateTime date = new DateTime(2021, 1, 01);
            string valid = comments.valid(Rating, date);
            Assert.AreEqual(valid, "To high rating");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Rate_Invalid()
        {
            CommentsModel comments = new CommentsModel();
            comments.Rating = Convert.ToInt32("mayistandunshaken");

        }
    }     
}
