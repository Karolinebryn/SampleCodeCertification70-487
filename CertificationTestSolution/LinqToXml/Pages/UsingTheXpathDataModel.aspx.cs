using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace LinqToXml.Pages
{
    public partial class UsingTheXpathDataModel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReadXmlData();
                SelectXmlData();
                QueryAndNamespace();
                EditXmlData();
            }
        }

        private void ReadXmlData()
        {
            try
            {
                var path = Server.MapPath("~/App_Data/books.xml");
                XPathDocument document = new XPathDocument(path);
                lblResult1.Text = "Document successfuly loaded in to DOM";
                lblResult1.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                lblResult1.Text = ex.Message;
                lblResult1.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void SelectXmlData()
        {
            try
            {
                var output = "";
                var path = Server.MapPath("~/App_Data/bookstore2.xml");
                XPathDocument document = new XPathDocument(path);
                XPathNavigator navigator = document.CreateNavigator();
                //output = navigator.InnerXml;
                XPathNodeIterator nodes = navigator.Select("/bookstore/book");

                while (nodes.MoveNext())
                {
                    output += nodes.Current.OuterXml;
                }

                Textarea3.InnerHtml = output;
            }
            catch (Exception ex)
            {
                Textarea3.InnerHtml = ex.Message;
            }
        }

        public void QueryAndNamespace()
        {
            try
            {
                var output = "";
                var path = Server.MapPath("~/App_Data/bookstore.xml");
                XPathDocument document = new XPathDocument(path);
                XPathNavigator navigator = document.CreateNavigator();
                XPathExpression query = navigator.Compile("/bookstore:bookstore/bookstore:book");
                XmlNamespaceManager manager = new XmlNamespaceManager(navigator.NameTable);
                manager.AddNamespace("bookstore", "urn:newbooks-schema");
                query.SetContext(manager);
                XPathNodeIterator nodes = navigator.Select(query);

                while (nodes.MoveNext())
                {
                    output += nodes.Current.OuterXml;
                }

                Textarea4.InnerHtml = output;
            }
            catch (Exception ex)
            {
                Textarea4.InnerHtml = ex.Message;
            }
        }

        public void EditXmlData()
        {
            var path = Server.MapPath("~/App_Data/bookstore.xml");
            XmlDocument document = new XmlDocument();
            document.Load(path);
            XPathNavigator navigator = document.CreateNavigator();

            navigator.MoveToChild("bookstore", "urn:newbooks-schema");
            navigator.MoveToChild("book", "urn:newbooks-schema");
            navigator.MoveToChild("price", "urn:newbooks-schema");

            //insert page-node before price-node on first book node
            navigator.InsertBefore("<pages>100</pages>");

            //update price where price is 11.99
            XmlNamespaceManager manager = new XmlNamespaceManager(navigator.NameTable);
            manager.AddNamespace("bookstore", "urn:newbooks-schema");
            foreach(XPathNavigator nav in navigator.Select("//bookstore:price", manager))
            {
                if(nav.Value == "11.99")
                {
                    nav.SetValue("9999999");
                }
            }

            //delete author-node on first book node
            navigator.MoveToRoot();
            navigator.MoveToChild("bookstore", "urn:newbooks-schema");
            navigator.MoveToChild("book", "urn:newbooks-schema");
            navigator.MoveToChild("author", "urn:newbooks-schema");
            navigator.DeleteSelf();

            navigator.MoveToRoot();
            Textarea5.InnerHtml = navigator.OuterXml;
        }
    }
}