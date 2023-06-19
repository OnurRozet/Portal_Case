using common.portal.com.Entity;
using dataccess.portal.com.Context;
using dataccess.portal.com.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataccess.portal.com.Repository
{
    public class EfCustomerDal : ICustomerDal
    {
        PortalDb context = new PortalDb();
        public Customer InsertCustomer(Customer entity)
        {
            
                context.Add(entity);
                context.SaveChanges();
            
            return entity;
        }
    }
}
