using Data.AdventureWorks;
using System.Collections.Generic;
using System.Linq;
using System;
using WcfService.AdventureWorks.Models;
using System.ServiceModel;

namespace WcfService.AdventureWorks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdventureWorksService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdventureWorksService.svc or AdventureWorksService.svc.cs at the Solution Explorer and start debugging.
    public class AdventureWorksService : IAdventureWorksService
    {
        private AdventureWorksEntities _context;

        public AdventureWorksService()
        {
            _context = new AdventureWorksEntities();
        }

        public string GetCustomerName(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerID == id);
            return customer.FirstName + " " + customer.LastName;
        }

        //Customer is WcfService.AdventureWorks.Models.Customer, not the EF-model from Data.AdventureWorks
        public IEnumerable<Models.Customer> GetCustomersWithOrders()
        {
            var customersWithOrders = _context.Customers.Where(c => c.SalesOrderHeaders.Count() > 0).OrderBy(c => c.CustomerID).Take(10).ToList();
            var result = new List<Models.Customer>();

            //wrap to exposable model
            foreach(var customer in customersWithOrders)
            {
                result.Add(new Models.Customer
                {
                    Id = customer.CustomerID, 
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Phone = customer.Phone, 
                    Title = customer.Title
                });
            }

            return result;
        }

        public Models.Customer GetCustomerWithFaultHandling(int id)
        {
            try
            {
                var customer = _context.Customers.Find(id);
                var result = new Models.Customer
                {
                    Id = customer.CustomerID,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Phone = customer.Phone,
                    Title = customer.Title
                };
                return result;

            }
            catch(NullReferenceException ex)
            {
                var fault = new CustomerNotFoundFault
                {
                    CustomerId = id,
                    ErrorMessage = "Customer with id " + id + " does not exist"
                };
                throw new FaultException<CustomerNotFoundFault>(fault, new FaultReason(ex.Message));
            }   
        }
    }
}
