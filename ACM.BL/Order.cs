using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class Order
    {
        public Order() { }
        public Order(int orderId) { OrderId = orderId; }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        /// <summary>
        /// Retrieve By ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        /// 
        #region move to order repository
        // public Order Retrieve(int orderId)
        // {
        //     return new Order();
        // }
        ///// <summary>
        ///// Save Orders
        ///// </summary>
        ///// <returns></returns>
        //public bool Save()
        // {
        //     return true;
        // }
        #endregion

        /// <summary>
        /// Validate the Order Date
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
       
            if (OrderDate == null)

            {
                isValid = false;
            }

            return isValid;
        }
    }
}
