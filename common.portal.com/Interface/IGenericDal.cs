namespace common.portal.com.Interface
{
    public interface IGenericDal<T> where T : class,new()
    {
        T InsertCustomer(T entity);

    }
}
