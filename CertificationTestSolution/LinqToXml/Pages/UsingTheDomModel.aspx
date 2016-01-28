<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsingTheDomModel.aspx.cs" Inherits="LinqToXml.Pages.UsingTheDomModel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        
        <div class="col-md-12">
            <h2>Process XML Data Using the DOM Model</h2>
            <p>
                The XML Document Object Model (DOM) treats XML data as a standard set of objects and is used to process XML data in memory. 
                The System.Xml namespace provides a programmatic representation of XML documents, fragments, nodes, or node-sets. 
                It is based on the World Wide Web Consortium (W3C) DOM Level 1 Core and the DOM Level 2 Core recommendations. 
                The XmlDocument class represents an XML document. It includes members for retrieving and creating all other XML objects. 
                Using the XmlDocument, and its related classes, you can construct XML documents, load and access data, modify data, 
                and save changes.
            </p>
            <p>
                If an application does not require the structure or editing capabilities provided by the DOM, the XmlReader and XmlWriter classes provide non-cached, forward-only stream access to XML.
                 For fast, non-cached, forward-only stream access to XML, use the XmlReader and XmlWriter.
            </p>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h3>Create a new XmlDocument</h3>
            <asp:Label runat="server" ID="lblResult1"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Read XML into DOM with XmlDocument</h3>
            <asp:Label runat="server" ID="lblResult2"></asp:Label>
        </div>
        <div class="col-md-6">
            <h3>Accessing Attributes In The Dom</h3>
            <asp:Literal runat="server" ID="literalResult3"></asp:Literal>
        </div>
        <div class="col-md-6">
            <h3>Remove node and attribute from the DOM</h3>
            <p><b>Original XML</b></p>
            <textarea runat="server" ID="taBefore" style="width: 100%;height: 100px;"></textarea>
            <p><b>Node and attribute is removed</b></p>
            <textarea runat="server" ID="taAfter" style="width: 100%;height: 100px;"></textarea>
        </div>
        <div class="col-md-6">
            <h3>Select Nodes Using XPath Navigation</h3>
            <p><b>Select and display the first node in which the author's last name is Kingsolver.</b></p>
            <textarea runat="server" ID="Textarea1" style="width: 100%;height: 100px;"></textarea>
            <p><b>Select all nodes where the book price is greater than 10.00.</b></p>
            <textarea runat="server" ID="Textarea2" style="width: 100%;height: 100px;"></textarea>
        </div>
    </div>
</asp:Content>
