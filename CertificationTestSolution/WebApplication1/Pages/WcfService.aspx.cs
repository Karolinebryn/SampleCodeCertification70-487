using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}