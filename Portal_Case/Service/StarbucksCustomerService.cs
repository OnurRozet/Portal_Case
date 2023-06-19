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
       
        ICustomerDal _customerDal;
        CustomerValidator _customerValidator;

        public StarbucksCustomerService( ICustomerDal customerDal)
        {
            
            _customerDal = customerDal;
            _customerValidator = new CustomerValidator();
        }

      
        public  Customer? SaveToDb(Customer customer)
        {
            _customerValidator.Validate(customer);
          return  _customerDal.InsertCustomer(customer);
            
        }
    }
}
