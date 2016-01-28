using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqToXml.Pages
{
    public partial class UsingLinqToXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadXmlFromFile();
                ParseTheString();
            }
        }

        private void LoadXmlFromFile()
        {
            try
            {
                var uri = Server.MapPath("~/App_Data/books.xml");
                XElement booksFromFile = XElement.Load(uri);

                taBox.InnerHtml = booksFromFile.ToString();
            }
            catch (Exception ex)
            {
                taBox.InnerHtml = ex.Message;
            }
        }

        private void ParseTheString()
        {
            var stringToParse = @"<Contacts>
        <Contact>
            <Name>Patrick Hines</Name>
            <Phone Type=""home"">206-555-0144</Phone>
            <Phone type=""work"">425-555-0145</Phone>
            <Address>
            <Street1>123 Main St</Street1>
            <City>Mercer Island</City>
            <State>WA</State>
            <Postal>68042</Postal>
            </Address>
            <NetWorth>10</NetWorth>
        </Contact>
        <Contact>
            <Name>Gretchen Rivas</Name>
            <Phone Type=""mobile"">206-555-0163</Phone>
            <Address>
            <Street1>123 Main St</Street1>
            <City>Mercer Island</City>
            <State>WA</State>
            <Postal>68042</Postal>
            </Address>
            <NetWorth>11</NetWorth>
        </Contact>
    </Contacts>";

            XElement contacts = XElement.Parse(stringToParse);

            taBox2.InnerHtml = contacts.ToString();
        }


    }
}