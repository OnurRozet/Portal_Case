using common.portal.com.Adapter.MernisServiceAdapter;
using common.portal.com.Entity;
using common.portal.com.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.portal.com.Validator
{
    public  class CustomerValidator
    {
        private bool _validateNationalityId;
        MernisServiceAdapter _mernisServiceAdapter;

        public CustomerValidator(bool validateNationalityId = true)
        {
            _validateNationalityId = validateNationalityId;
           _mernisServiceAdapter = new MernisServiceAdapter();
        }

        public bool IsValidRequest(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FirstName) || string.IsNullOrWhiteSpace(customer.LastName) || customer.NationalityId.ToString().Length != 11 || customer.DateOfBirth == DateTime.MinValue)
            {
                return false;
            }
            return true;
        }

        public bool Validate(Customer customer)
        {
            bool isNationalityIdValid = false;
            if (IsValidRequest(customer)==false)
            {
                throw new Exception("Required fields are not provided");
            }

            if (_validateNationalityId)
            {
              
                //Mernis check yap

                //mernis true dönerse değişken oluştur
                if (_mernisServiceAdapter.IsChecked(customer).Result)
                {
                    isNationalityIdValid = true;
                }
                //false dönerse 
                if (isNationalityIdValid==false)
                {
                    throw new Exception("Kps  is not valid");
                }

               
            }

            return isNationalityIdValid;
        }
    }
}
