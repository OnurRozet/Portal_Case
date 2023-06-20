using common.portal.com.Entity;
using common.portal.com.Interface;
using common.portal.com.Validator;
using MernisServiceReference;
using System.Threading.Tasks;

namespace common.portal.com.Adapter.MernisServiceAdapter
{
    public class MernisServiceAdapter : ICheckCustomerService
    {
        public async Task<bool> IsChecked(Customer customer)
        {
            if (CustomerValidator.IsValidRequest(customer) == false) { return false; }

            var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);

            return response.Body.TCKimlikNoDogrulaResult;
        }
    }
}
