using common.portal.com.Entity;
using common.portal.com.Interface;
using common.portal.com.Validator;
using dataccess.portal.com.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.portal.com.Service
{
    public class StarbucksCustomerService : IStarbucksService
    {
        CustomerValidator _customerValidator;

        public StarbucksCustomerService()
        {
          
            _customerValidator = new CustomerValidator(validateNationalityId:true);
        }

      
        public  Customer? SaveToDb(Customer customer)
        {
            _customerValidator.Validate(customer);

            return customer;
            
        }
    }
}
