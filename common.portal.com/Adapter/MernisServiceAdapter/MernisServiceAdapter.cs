using common.portal.com.Entity;
using common.portal.com.Interface;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.portal.com.Adapter.MernisServiceAdapter
{
    public class MernisServiceAdapter : ICheckCustomerService
    {
        public async Task<bool> IsChecked(Customer customer)
        {
            var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);

            return response.Body.TCKimlikNoDogrulaResult;
        }
    }
}
