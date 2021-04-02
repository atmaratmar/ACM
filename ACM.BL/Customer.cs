using System;
using System.Collections.Generic;

namespace ACM.BL
{
   
   
    public class Customer
    {

        public Customer() {}

        public Customer(int _customerId)
        {
            CustomerId = _customerId;
        }

        #region props
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string FullNmae
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ",";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
            
        }
        #endregion

        #region Methods
        /// <summary>
        /// Validates the customner data
        /// </summary>

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }
        #endregion

        #region move to CustomerRepository
        ///// <summary>
        ///// Reterieve customer by id
        ///// </summary>
        //public Customer Retrieve(int customerId)
        //{
        //    return new Customer();
        //}
        ///// <summary>
        ///// Reterieve all customers
        ///// </summary>
        //public List<Customer> Retrieve()
        //{
        //    return new List<Customer>();
        //}
        ///// <summary>
        ///// Save method
        ///// </summary>
        //public bool Save()
        //{
        //    return true;
        //}

        #endregion

    }

}
