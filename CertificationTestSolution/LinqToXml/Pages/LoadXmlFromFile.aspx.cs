using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqToXml.Pages
{
    public partial class LoadXmlFromFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadXmlFromTheFile();
            }
        }

        private void LoadXmlFromTheFile()
        {
            try
            {
                var uri = Server.MapPath("~/App_Data/books.xml");
                XElement booksFromFile = XElement.Load(uri);

                taBox.InnerHtml = booksFromFile.ToString();
            }
            catch(Exception ex)
            {

            }
        }
    }
}