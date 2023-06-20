using common.portal.com.Entity;

namespace common.portal.com.Interface
{
    public interface IPortalService
    {
        Customer? SaveToDb(Customer customer);
    }
}
