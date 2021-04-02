﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderItemId) { OrderItemId = orderItemId; }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve orderItem by id
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Save OrderItems
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validate the OrderItem Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0)

            {
                isValid = false;
            }
            if (ProductId <= 0)

            {
                isValid = false;
            }
            if (PurchasePrice == null
                )

            {
                isValid = false;
            }

            return isValid;
        }

    }
}
