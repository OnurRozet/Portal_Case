using common.portal.com.Entity;
using dataccess.portal.com.Context;
using common.portal.com.Interface;

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
