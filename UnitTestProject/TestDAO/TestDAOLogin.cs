using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BusinessClassPortable;
using EncodingDll;

namespace UnitTestProject.TestDAO
{
    [TestClass]
    public class TestDAOLogin
    {
        [TestMethod]
        public void Test_CheckAccess_ReturnPerson()
        {
            // Arrange
            string personLogin = "Jean";
            string personPass = Convert.ToBase64String(EncodingPass.SalAndHash("0000"));
            Person PersonExpected = new Person(1, "Jean", "Moderator", "jm@gmail.com", personPass, 1);
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");

            // Act
            Person PersonActual = Controller.CheckAccess(personLogin, personPass);

            // Assert
            Assert.AreEqual(PersonExpected, PersonActual);
        }

        [TestMethod]
        public void Test_Login_Click_Fail()
        {
            // Arrange
            string personLogin = "Jea";
            string personPass = "0000";
            Person Person = new Person();
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");

            // Act
            Person = Controller.CheckAccess(personLogin, personPass);

            // Assert
            Assert.IsTrue(Person == null);
        }

        [TestMethod]
        public void Test_UpdatePassword()
        {
            // Arrange
            int personId = 1;
            string personPass = "0000";
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");

            // Act // Assert
            Assert.IsTrue(Controller.UpdatePassword(personId, personPass));

            // Assert
            //Assert.IsTrue(result > 0);
        }
    }
}
