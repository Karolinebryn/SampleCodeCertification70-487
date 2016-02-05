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
                CreateXmlDocument();
                LoadXmlFromFile();
                ParseTheString();
            }
        }

        private void CreateXmlDocument()
        {
            try
            {
                XDocument srcTree = new XDocument(
                    new XComment("This is a comment"),
                    new XElement("Root",
                        new XElement("Child1", "data1"),
                        new XElement("Child2", "data2"),
                        new XElement("Child3", "data3"),
                        new XElement("Child2", "data4"),
                        new XElement("Info5", "info5"),
                        new XElement("Info6", "info6"),
                        new XElement("Info7", "info7"),
                        new XElement("Info8", "info8")
                    )
                );

                srcTree.Save(@"C:\TestDoc\test2.xml");
                lblResult1.Text = "Document successfully saved to path: C:\\TestDoc\\test2.xml";
                lblResult1.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                lblResult1.Text = "An error occured: " + ex.Message;
                lblResult1.ForeColor = System.Drawing.Color.Red;
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