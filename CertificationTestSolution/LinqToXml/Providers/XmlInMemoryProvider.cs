using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace LinqToXml.Providers
{
    public class XmlInMemoryProvider
    {
        private XElement _contacts;

        public XElement Contacts { get { return _contacts; } }

        public XmlInMemoryProvider()
        {
            //constructing elements with XElement and XAttribute
            _contacts = 
                new XElement("Contacts",
                    new XElement("Contact",
                        new XElement("Name", "Karoline Brynildsen"),
                        new XElement("Phone", "12345678"),
                        new XElement("Address",
                            new XElement("Street1", "Veien 1"),
                            new XElement("City", "Byen"),
                            new XElement("State", "BY"),
                            new XElement("Postal", "1234")
                        )
                    ),
                    new XElement("Contact",
                        new XElement("Name", "Patrick Hines"),
                        new XElement("Phone", "12356987"),
                        new XElement("Address",
                            new XElement("Street1", "Gata 4"),
                            new XElement("City", "Byen"),
                            new XElement("State", "BY"),
                            new XElement("Postal", "1235")
                        )
                    ), new XElement("Contact",
                        new XElement("Name", "Lara Jameston"),
                        new XElement("Phone", "321654987"),
                        new XElement("Address",
                            new XElement("Street1", "Stien 5"),
                            new XElement("City", "Lillebyen"),
                            new XElement("State", "LB"),
                            new XElement("Postal", "6548")
                        )
                    ), new XElement("Contact",
                        new XElement("Name", "John Johnson"),
                        new XElement("Phone", "12345698"),
                        new XElement("Address",
                            new XElement("Street1", "Stien 9"),
                            new XElement("City", "Lillebyen"),
                            new XElement("State", "LB"),
                            new XElement("Postal", "6548")
                        )
                    )
                );
        }
    }
}