using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    //-- Arrange
    //-- Act
    //-- Assert

    [TestClass]
    public class CustomerTest
    {
        #region FullNameTestValid
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange

            Customer customer = new Customer
            {
                FirstName = "Atmar",
                LastName = "Kohistany"
            };
            string expectedValue = "Kohistany,Atmar";

            //-- Act
            string ActualValue = customer.FullNmae;
            //-- Assert

            Assert.AreEqual(expectedValue, ActualValue);
        }

        [TestMethod]
        public void FullNameFirstNameEmptyTestValid()
        {
            //-- Arrange

            Customer customer = new Customer
            {
                LastName = "Kohistany"
            };
            string expectedValue = "Kohistany";

            //-- Act
            string ActualValue = customer.FullNmae;
            //-- Assert

            Assert.AreEqual(expectedValue, ActualValue);
        }
        [TestMethod]
        public void FullNameLastNameEmptyTestValid()
        {
            //-- Arrange

            Customer customer = new Customer
            {
                FirstName = "Atmar"
            };
            string expectedValue = "Atmar";

            //-- Act
            string ActualValue = customer.FullNmae;
            //-- Assert

            Assert.AreEqual(expectedValue, ActualValue);
        }
        #endregion

        #region Methods
        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName="Jazmin",
                EmailAddress="Jaz@Jaz.com"
            };
            var expectedResult = true;
            //-- Act
            var actualResult = customer.Validate();
            //-- Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer
            {
                EmailAddress = "Jaz@Jaz.com"
            };
            var expectedResult = false;
            //-- Act
            var actualResult = customer.Validate();
            //-- Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion


    }
}
