using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestCases;

namespace MyTestProject
{
    [TestClass]
    public class UnitTest1
    {
       Program program = new Program();


        //public void Setup()
        //{
        //    Program program = new Program();
        //}

        [TestCategory("Addition")]
        [TestMethod]
        public void TestAdditionMethod()
        {
            ///AAA Pattern
            ///Arrange

            int first = 10;
            int second = 20;
            int expected = 30;

            //Act
            int actual = program.Addition(first, second);

            //Assert
            Assert.AreEqual(expected, actual);



        }


        [TestCategory("substraction")]
        [TestMethod]
        public void TestSubtractionMethod()
        {
            ///AAA pattern
            ///Arrange
            int first = 30;
            int second = 20;
            int expected = 10;

            //Act
            int actual = program.substraction(first, second);

            //Assert
            Assert.AreEqual(expected, actual);


        }
    }
}

