using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
  public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>


        public Order Retrieve(int orderId)
        {
            /// Create the instance of the Order Class
            /// Pass in the requested id
            Order order  = new Order(orderId);

            /// Temporary hard code the valuse to return
            /// a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save(Order order)
        {
            //code that save 
            return true;
        }
    }
}
