using System;

namespace ACM.BL
{
   
    public class Customer
    {
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

        public bool Validet()
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
    }

}
