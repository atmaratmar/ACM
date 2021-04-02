using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {

        //-- Arrange
        //-- Act
        //-- Assert
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expectedObject = new Customer(1)
            {
               // customerId =1,
               // we cant set value because it is private 
               //we do it via constractor

                EmailAddress="atmar@hotmail.dk",
                FirstName ="Atmar",
                LastName = "Kohistany"
            };
            //-- Act
            var ActualObject = customerRepository.Retrieve(1);
            //-- Assert

            Assert.AreEqual(expectedObject.CustomerId, ActualObject.CustomerId);
            Assert.AreEqual(expectedObject.EmailAddress, ActualObject.EmailAddress);
            Assert.AreEqual(expectedObject.FirstName, ActualObject.FirstName);
            Assert.AreEqual(expectedObject.LastName, ActualObject.LastName);
        }
    }
}
