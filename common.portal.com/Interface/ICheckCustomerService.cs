using common.portal.com.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.portal.com.Interface
{
    public interface ICheckCustomerService
    {
        Task<bool> IsChecked(Customer customer);
    }
}
