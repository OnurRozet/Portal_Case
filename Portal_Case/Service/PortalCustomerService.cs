using common.portal.com.Entity;
using common.portal.com.Interface;
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
        ICustomerDal _customerDal;

        public PortalCustomerService(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public bool isValidCustomer(Customer customer)
        {
            if (customer.Id == 0 && string.IsNullOrWhiteSpace(customer.FirstName) && string.IsNullOrWhiteSpace(customer.LastName) && customer.NationalityId.ToString().Length != 11 && customer.DateOfBirth == null)
            {
                return false;
            }
            return true;
        }
        public async Task<Customer?> SaveToDb(Customer customer)
        {
            isValidCustomer(customer);

            Customer addedCustomer = _customerDal.InsertCustomer(customer);
            return addedCustomer;
        }
    }
}
