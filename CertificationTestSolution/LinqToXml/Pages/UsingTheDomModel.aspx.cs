using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace LinqToXml.Pages
{
    public partial class UsingTheDomModel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CreateXmlDocument();
                ReadXmlDocumentIntoDom();
                AccessAttributesInTheDom();
                RemoveNodeAndAttributeFromTheDom();
            }
        }

        private void CreateXmlDocument()
        {
            try
            {
                var document = new XmlDocument();
                var root = document.CreateElement("Items");
                var item1 = document.CreateElement("Item");
                var item1text = document.CreateTextNode("item 1");

                //set attribute1
                item1.SetAttribute("attr1", "thisisanattribute");

                //set attribute2
                XmlAttribute attr2 = document.CreateAttribute("attr2");
                attr2.Value = "thisisanotherattribute";
                item1.SetAttributeNode(attr2);

                root.AppendChild(item1);
                root.LastChild.AppendChild(item1text);
                document.AppendChild(root);

                document.Save(@"C:\TestDoc\test1.xml");

                lblResult1.Text = "Document successfully saved to path: C:\\TestDoc\\test1.xml";
                lblResult1.ForeColor = System.Drawing.Color.Black;
            }
            catch(Exception ex)
            {
                lblResult1.Text = ex.Message;
                lblResult1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ReadXmlDocumentIntoDom()
        {
            try
            {
                //from string
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<book genre='novel' ISBN='1-861001-57-5'>" +
                            "<title>Pride And Prejudice</title></book>");

                //from file
                var path = Server.MapPath("~/App_Data/books.xml");
                XmlDocument doc2 = new XmlDocument();
                doc2.Load(path);

                lblResult2.Text = "Documents successfully loaded into DOM.";
                lblResult2.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                lblResult2.Text = ex.Message;
                lblResult2.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void AccessAttributesInTheDom()
        {
            var output = "";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<book genre='novel' ISBN='1-861001-57-5' misc='sale item'>" +
                          "<title>The Handmaid's Tale</title>" +
                          "<price>14.95</price>" +
                          "</book>");

            // Move to an element.
            XmlElement myElement = doc.DocumentElement;

            // Create an attribute collection from the element.
            XmlAttributeCollection attrColl = myElement.Attributes;

            // Show the collection by iterating over it.
            output += "<p><b>Display all the attributes in the collection:</b><br />";
            for (int i = 0; i < attrColl.Count; i++)
            {
                output += string.Format("{0} = ", attrColl[i].Name);
                output += string.Format("{0}<br />", attrColl[i].Value);
            }
            output += "</p>";

            // Retrieve a single attribute from the collection; specifically, the
            // attribute with the name "misc".
            XmlAttribute attr = attrColl["misc"];

            // Retrieve the value from that attribute.
            var miscValue = attr.InnerXml;

            output += "<p><b>Display one attribute information:</b><br />";
            output += miscValue + "</p>";

            literalResult3.Text = output;
        }

        private void RemoveNodeAndAttributeFromTheDom()
        {
            var path = Server.MapPath("~/App_Data/books.xml");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<books genre='novel'>" +
                    "<book subgenra='lovenovel' ISBN='1-861001-57-5'><title>Pride And Prejudice</title></book>" +
                    "<book subgenra='mystery' ISBN='1-861001-57-5'><title>The DaVinci Code</title></book>" +
                            "</books>");

            var root = doc.DocumentElement;
            taBefore.InnerHtml = root.OuterXml;

            //Remove the first child
            root.RemoveChild(root.FirstChild);
            root.RemoveAttribute("genre");

            taAfter.InnerHtml = root.OuterXml;
        }

    }
}