using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.AdventureWorks_WcfService;

namespace WebApplication1.Pages
{
    public partial class WcfService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetDataFromWCFService();
            }
        }

        private void GetDataFromWCFService()
        {
            try
            {
                var service = new AdventureWorks_WcfService.AdventureWorksServiceClient();
                var nameOfCustomer = service.GetCustomerName(1);
                var customers = service.GetCustomersWithOrders();

                gvAdventureWorks_wcfservice.DataSource = customers;
                gvAdventureWorks_wcfservice.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnSearchCustomerById_Click(object sender, EventArgs e)
        {
            try
            {
                var customerId = int.Parse(tbCustomerId.Text);
                var service = new AdventureWorks_WcfService.AdventureWorksServiceClient();
                var customer = service.GetCustomerWithFaultHandling(customerId);
                lblSearchResult.Text = customer.FirstName + " " + customer.LastName;
            }
            catch (FaultException<CustomerNotFoundFault> fEx)
            {
                lblSearchResult.Text = "An error occured: " + fEx.Detail.ErrorMessage;
            }
        }
    }
}