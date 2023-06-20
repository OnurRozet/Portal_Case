using common.portal.com.Entity;
using System.Threading.Tasks;

namespace common.portal.com.Interface
{
    public interface ICheckCustomerService
    {
        Task<bool> IsChecked(Customer customer);
    }
}
