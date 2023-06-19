using common.portal.com.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataccess.portal.com.Interface
{
    public interface IGenericDal<T> where T : class,new()
    {
        T InsertCustomer(T entity);

    }
}
