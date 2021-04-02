using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        //-- Arrange
        //-- Act
        //-- Assert
        [TestMethod]
        public void ProductRetrieveTest()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expectedObject = new Product(2)
            {
                // ProductId =2,
                // we cant set value because it is private 
                //we do it via constractor

                CurrentPrice = 15.95M,
                ProductDescription= "Assert Size of 4",
                ProductName = "Sunflower"
            };
            //-- Act
            var ActualObject = productRepository.Retrieve(2);
            //-- Assert

            Assert.AreEqual(expectedObject.CurrentPrice, ActualObject.CurrentPrice);
            Assert.AreEqual(expectedObject.ProductDescription, ActualObject.ProductDescription);
            Assert.AreEqual(expectedObject.ProductName, ActualObject.ProductName);
           
        }
    }
}
