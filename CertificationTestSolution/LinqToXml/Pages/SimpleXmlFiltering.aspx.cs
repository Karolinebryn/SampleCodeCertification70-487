using LinqToXml.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqToXml.Pages
{
    public partial class SimpleXmlFiltering : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillContactGridView("All");
            }
        }

        private void FillContactGridView(string city)
        {
            var provider = new XmlInMemoryProvider();
            IEnumerable<XElement> result = null;
            if (city == "All")
            {
                result = from contact in provider.Contacts.Elements()
                         select contact;
            }
            else
            {
                result = from contact in provider.Contacts.Elements()
                         where contact.Element("Address").Element("City").Value == city
                         select contact;
            }

            gvContacts.DataSource = result;
            gvContacts.DataBind();
        }

        protected void ddlFilterContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = (DropDownList)sender;
            var selected = ddl.SelectedValue;
            FillContactGridView(selected);
        }
    }
}