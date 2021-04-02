using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        //-- Arrange
        //-- Act
        //-- Assert
        [TestMethod]
        public void OrderRetrieveTest()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expectedOrder = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0))
        };

            //-- Act
            var ActualOrder = orderRepository.Retrieve(10);
            //-- Assert
            Assert.AreEqual(expectedOrder.OrderDate, ActualOrder.OrderDate);
        }
    }
}
