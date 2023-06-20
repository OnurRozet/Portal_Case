using common.portal.com.Entity;
using common.portal.com.Interface;
using common.portal.com.Validator;

namespace business.portal.com.Service
{
    public class StarbucksCustomerService : IStarbucksService
    {
        CustomerValidator _customerValidator;

        public StarbucksCustomerService()
        {
            _customerValidator = new CustomerValidator(validateNationalityId: true);
        }

        public Customer? SaveToDb(Customer customer)
        {
            _customerValidator.Validate(customer);
            // TODO: save operation will be handled here
            return customer;
        }
    }
}
