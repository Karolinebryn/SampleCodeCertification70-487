using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService.AdventureWorks
{
    [ServiceContract]
    public interface IAdventureWorksService
    {

        [OperationContract]
        string GetCustomerName(int id);

        //Customer is WcfService.AdventureWorks.Models.Customer, not the EF-model from Data.AdventureWorks
        [OperationContract]
        IEnumerable<Models.Customer> GetCustomersWithOrders();

        // TODO: Add your service operations here
    }

}
