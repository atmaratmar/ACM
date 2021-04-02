using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
       public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        #region move to productRepository
        ///// <summary>
        /////  Get product by id
        ///// </summary>
        ///// <param name="productId"></param>
        ///// <returns></returns>
        //public Product Retrieve(int productId)
        //{
        //    return new Product();
        //}

        ///// <summary>
        ///// Save Products
        ///// </summary>
        ///// <returns></returns>
        //public bool Save()
        //{
        //    return true;
        //}

        /// <summary>
        /// Validate the product data
        /// </summary>
        /// <returns></returns>
        #endregion



        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if (CurrentPrice==null)

            {
                isValid = false;
            }

            return isValid;
        }

    }
}
