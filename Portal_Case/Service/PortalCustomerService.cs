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
    public class PortalCustomerService : IPortalService
    {
     
        private CustomerValidator _customerValidator;
        public PortalCustomerService()
        {
            
            _customerValidator = new CustomerValidator(validateNationalityId:false);
        }
        public  Customer? SaveToDb(Customer customer)
        {

            _customerValidator.Validate(customer);

            return customer;
         
        }
    }
}
