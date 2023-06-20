using common.portal.com.Entity;
using common.portal.com.Interface;
using common.portal.com.Validator;

namespace business.portal.com.Service
{
    public class PortalCustomerService : IPortalService
    {
        private CustomerValidator _customerValidator;
        public PortalCustomerService()
        {
            _customerValidator = new CustomerValidator(validateNationalityId: false);
        }
        public Customer? SaveToDb(Customer customer)
        {
            _customerValidator.Validate(customer);
            // TODO: save operation will be handled here
            return customer;
        }
    }
}
