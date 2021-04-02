using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class CustomerRepository
    {
        /// <summary>
        /// Retrieve Customer
        /// </summary>
        /// <param name="customerId"></param>

        public Customer Retrieve(int customerId)
        {           
            /// Create the instance of the Customer Class
            /// Pass in the requested id
            Customer customer = new Customer(customerId);

            /// Temporary hard code the valuse to return
            /// a populated customer
            if (customerId==1)
            {
                customer.EmailAddress = "atmar@hotmail.dk";
                customer.FirstName = "Atmar";
                customer.LastName = "Kohistany";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            //code that save 
            return true;
        }
    }
}
