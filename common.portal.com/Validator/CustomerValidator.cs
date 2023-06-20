using common.portal.com.Adapter.MernisServiceAdapter;
using common.portal.com.Entity;
using System;


namespace common.portal.com.Validator
{
    public class CustomerValidator
    {
        private bool _validateNationalityId;
        MernisServiceAdapter _mernisServiceAdapter;

        public CustomerValidator(bool validateNationalityId = false)
        {
            _validateNationalityId = validateNationalityId;
            _mernisServiceAdapter = new MernisServiceAdapter();

        }

        public static bool IsValidRequest(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FirstName) || string.IsNullOrWhiteSpace(customer.LastName) || customer.NationalityId.ToString().Length != 11 || customer.DateOfBirth == DateTime.MinValue)
            {
                return false;
            }
            return true;
        }

        public bool Validate(Customer customer)
        {
            bool isNationalityIdValid = true;
            if (IsValidRequest(customer) == false)
            {
                throw new ApplicationException("Required fields are not provided");
            }

            if (_validateNationalityId)
            {
                isNationalityIdValid = false;

                if (_mernisServiceAdapter.IsChecked(customer).Result)
                {
                    isNationalityIdValid = true;
                }


                if (isNationalityIdValid == false)
                {
                    throw new ApplicationException("Kps is not valid");
                }
            }

            return isNationalityIdValid;
        }
    }
}
