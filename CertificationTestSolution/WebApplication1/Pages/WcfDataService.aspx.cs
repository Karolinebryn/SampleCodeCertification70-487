using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.AdventureWorks_WcfDataService;

namespace WebApplication1.Pages
{
    public partial class WcfDataService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    var uri = new Uri("http://localhost:2193/AdventureWorks_WcfDataService.svc");
                    var context = new AdventureWorksEntities(uri);
                    var orders = (from order in context.SalesOrderHeaders.Expand("Customer")
                                  select order).OrderBy(o => o.CustomerID).Take(10).ToList();

                    var customers = orders.Select(o => o.Customer).ToList();

                    gvAdventureWorks_wcfdataservice.DataSource = customers;
                    gvAdventureWorks_wcfdataservice.DataBind();
                }
                catch (Exception ex)
                {

                }
            }
        }

    }
}