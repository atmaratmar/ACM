using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class ProductRepository
    {
        /// <summary>
        /// Retrieve one Product
        /// </summary>
   

        public Product Retrieve(int productId)
        {
            /// Create the instance of the Product Class
            /// Pass in the requested id
            Product product  = new Product(productId);

            /// Temporary hard code the valuse to return
            /// a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assert Size of 4";
                product.CurrentPrice = 15.95M;
            }

            return product;
        }

        public bool Save(Product product )
        {
            //code that save 
            return true;
        }
    }
}
